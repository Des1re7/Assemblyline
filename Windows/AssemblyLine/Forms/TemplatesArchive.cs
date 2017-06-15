using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyLine
{
    public partial class TemplatesArchive : Form
    {
        public TemplatesArchive()
        {
            InitializeComponent();

            FillRows();
        }

        private void FillRows()
        {
            try
            {
                List<string> templatesFolders = null;
                int templates = 0;
                int templatesRemained = 0;

                if (Directory.Exists("Templates"))
                {
                    templatesFolders = new List<string>(Directory.EnumerateDirectories("Templates"));
                    templates = templatesFolders.Count();
                }
                else
                    templates = 0;

                templatesRemained = templates;

                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.RowCount = (int)Math.Ceiling(templates / 5.0);
                tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 100;

                for (int r = 0; r < tableLayoutPanel1.RowCount; r++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                    for (int c = 0; c < ((templatesRemained > 5) ? (5) : (templatesRemained)); c++)
                    {
                        Panel panel = new Panel() { BorderStyle = BorderStyle.FixedSingle, Dock = DockStyle.Fill };
                        PictureBox picBox = new PictureBox() { SizeMode = PictureBoxSizeMode.Zoom, Cursor = Cursors.Hand, Height = 80, Width = 80, Dock = DockStyle.Top };
                        Label label = new Label() { TextAlign = ContentAlignment.BottomCenter, Dock = DockStyle.Bottom };

                        picBox.Click += new System.EventHandler(PicBoxTemplateClick);

                        string tmpPath = (new DirectoryInfo(templatesFolders[(r + 1) * c])).ToString();
                        label.Text = (new DirectoryInfo(templatesFolders[(r + 1) * c])).Name;

                        List<string> tempates = new List<string>(Directory.EnumerateFiles(tmpPath, "*.jpg"));

                        picBox.Image = new Bitmap(tempates[0]);

                        panel.Controls.Add(picBox);
                        panel.Controls.Add(label);

                        tableLayoutPanel1.Controls.Add(panel, c, r);

                    }
                    templatesRemained -= 5;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось заполнить окно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PicBoxTemplateClick(object sender, EventArgs e)
        {
            /*PictureBox picBox = (PictureBox)sender;
            Panel panel = (Panel)picBox.Parent;
            string templateName = ((Label)panel.Controls[1]).Text;*/
        }
    }
}
