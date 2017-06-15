using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

using AssemblyLine.Classes;

namespace AssemblyLine
{
    public partial class TrainingForm : Form
    {
        private bool bSelectingImage = false;
        private Rectangle rectCropImage;
        private Point ptStartMouse;
        private float xScalingImage = 0, yScalingImage = 0;

        public TrainingForm()
        {
            InitializeComponent();
        }
        public TrainingForm(Image image)
        {
            InitializeComponent();

            //pictureBoxImage.Image = ResizeImage(image, pictureBoxImage.Width, pictureBoxImage.Height);
            //imgDefault = pictureBoxImage.Image;

            displayLayoutNew(false);
            pictureBoxImage.Image = image;
            fillComboBox("Templates");
            comboBoxDirection.SelectedIndex = 0;
            //calcScalingImage();
        }

        private void fillComboBox(string templatesFolder)
        {
            try
            {
                List<string> templatesFolders;
                if (Directory.Exists("Templates"))
                {
                    templatesFolders = new List<string>(Directory.EnumerateDirectories(templatesFolder));

                    foreach (var tmpFld in templatesFolders)
                    {
                        comboBoxTemplates.Items.Add(Path.GetFileName(tmpFld));
                    }
                    comboBoxTemplates.SelectedIndex = 0;
                }
                else
                {
                    DirectoryInfo dir = Directory.CreateDirectory("Templates");
                    fillComboBox(templatesFolder);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось заполнить поле с названиями шаблонов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcScalingImage()
        {
            xScalingImage = pictureBoxImage.Image.Width / pictureBoxImage.Width;
            yScalingImage = pictureBoxImage.Image.Height / pictureBoxImage.Height;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rectCropImage.Width == 0 || rectCropImage.Height == 0)
                {
                    MessageBox.Show("Необходимо выделить фигуру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxTemplates.SelectedIndex > 0 || textBoxNewName.Text != string.Empty)
                {
                    string pathTemplate;

                    if (comboBoxTemplates.SelectedIndex == 0)
                    {
                        DirectoryInfo dir = Directory.CreateDirectory(Path.Combine("Templates", textBoxNewName.Text));
                        pathTemplate = dir.FullName;

                        ObjectInfo objInfo = new ObjectInfo(textBoxNewName.Text, comboBoxDirection.SelectedItem.ToString());
                        Stream writer = new FileStream(Path.Combine(pathTemplate, "ObjectInfo.xml"), FileMode.Create);
                        XmlSerializer serializer = new XmlSerializer(typeof(ObjectInfo));
                        serializer.Serialize(writer, objInfo);
                        writer.Close();
                    }
                    else
                        pathTemplate = Path.Combine("Templates", comboBoxTemplates.SelectedItem.ToString());

                    int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                    Bitmap newBmp = new Bitmap(rectCropImage.Width, rectCropImage.Height);
                    Bitmap image = new Bitmap(pictureBoxImage.Image);

                    for (int i = 0; i < newBmp.Width; i++)
                        for (int j = 0; j < newBmp.Height; j++)
                            if (rectCropImage.X + i < image.Width & rectCropImage.Y + j < image.Height)
                                newBmp.SetPixel(i, j, image.GetPixel(rectCropImage.X + i, rectCropImage.Y + j));
                            else
                                newBmp.SetPixel(i, j, Color.Black);

                    newBmp.Save(Path.Combine(pathTemplate, unixTimestamp.ToString() + ".jpg"), ImageFormat.Jpeg);

                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Выберите готовый шаблон или впишите новое имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения шаблона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex == 0)
                displayLayoutNew();
            else
                displayLayoutNew(false);

            buttonSave.Enabled = true;
        }
        private void displayLayoutNew(bool display = true)
        {
            try
            {
                if (display)
                {
                    tableLayoutMain.RowStyles[2].Height = 60;
                    tableLayoutNew.Visible = true;
                    this.Size = new Size(this.Size.Width, 645);
                }
                else
                {
                    tableLayoutMain.RowStyles[2].Height = 0;
                    tableLayoutNew.Visible = false;
                    this.Size = new Size(this.Size.Width, 585);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось настроить отображение окна!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            bSelectingImage = true;

            ptStartMouse.X = e.X;
            ptStartMouse.Y = e.Y;
            rectCropImage = new Rectangle(new Point(e.X, e.Y), new Size());
        }

        private void pictureBoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            bSelectingImage = false;

            ptStartMouse.X = -1;
            ptStartMouse.Y = -1;
        }

        private void pictureBoxImage_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (bSelectingImage)
                {
                    Point ptCurrent = new Point(e.X, e.Y);

                    if (ptCurrent.X > pictureBoxImage.Image.Width)
                        ptCurrent.X = pictureBoxImage.Image.Width;
                    else if (ptCurrent.X < 0)
                        ptCurrent.X = 0;

                    if (ptCurrent.Y > pictureBoxImage.Image.Height)
                        ptCurrent.Y = pictureBoxImage.Image.Height;
                    else if (ptCurrent.Y < 0)
                        ptCurrent.Y = 0;

                    if (ptStartMouse.X == ptCurrent.X || ptStartMouse.Y == ptCurrent.Y)
                        return;


                    if (ptCurrent.X > ptStartMouse.X && ptCurrent.Y > ptStartMouse.Y)
                    {
                        rectCropImage.Width = ptCurrent.X - ptStartMouse.X;
                        rectCropImage.Height = ptCurrent.Y - ptStartMouse.Y;
                    }
                    else if (ptCurrent.X < ptStartMouse.X && ptCurrent.Y > ptStartMouse.Y)
                    {
                        rectCropImage.Width = ptStartMouse.X - ptCurrent.X;
                        rectCropImage.Height = ptCurrent.Y - ptStartMouse.Y;
                        rectCropImage.X = ptCurrent.X;
                        rectCropImage.Y = ptStartMouse.Y;
                    }
                    else if (ptCurrent.X > ptStartMouse.X && ptCurrent.Y < ptStartMouse.Y)
                    {
                        rectCropImage.Width = ptCurrent.X - ptStartMouse.X;
                        rectCropImage.Height = ptStartMouse.Y - ptCurrent.Y;
                        rectCropImage.X = ptStartMouse.X;
                        rectCropImage.Y = ptCurrent.Y;
                    }
                    else
                    {
                        rectCropImage.Width = ptStartMouse.X - ptCurrent.X;
                        rectCropImage.Height = ptStartMouse.Y - ptCurrent.Y;
                        rectCropImage.X = ptCurrent.X;
                        rectCropImage.Y = ptCurrent.Y;
                    }

                    pictureBoxImage.Refresh();
                    Graphics g = pictureBoxImage.CreateGraphics();
                    g.DrawRectangle(new Pen(Color.Red), rectCropImage);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при выделении фигуры!\nПопробуйте выделить заново.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}