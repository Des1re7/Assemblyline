using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using Emgu.CV.Structure;
using Emgu.CV;
using System.Xml.Serialization;
using System.IO.Ports;
using Microsoft.Win32;

using AssemblyLine.Classes;

using DirectShowLib;
using System.Threading;

namespace AssemblyLine
{
    public partial class MainForm : Form
    {
        private SerialPort comArduino = new SerialPort("COM6", 9600);

        private bool trainingMode = false;
        private bool cameraIsCapturing = false;
        private bool arduinoIsWorking = false;

        private static bool carGo = false;
        private static bool carGoBack = false;

        private double recognitionThreshold = 0;

        private Image[] imgHistory = new Image[10];
        private int imgNumber = 0;

        private Capture camera;

        Thread threadCarGoing;

        public MainForm()
        {
            InitializeComponent();

            initializeSettings();

            threadCarGoing = new Thread(this.carGoing);
        }

        private void initializeSettings()
        {
            try
            {
                trainingMode = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "TrainingMode", false));
                recognitionThreshold = Convert.ToDouble(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "RecognitionThreshold", 60));
            }
            catch {
                MessageBox.Show("Ну удалось считать все настройки!", "Ошибка чтения настроек", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void carGoing()
        {
            SerialPort comCar = new SerialPort("COM4", 9600);
            try
            {
                comCar.Open();
            }
            catch
            {
                MessageBox.Show("Неудалось включить ленту", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            while (arduinoIsWorking)
                {
                    while (carGo)
                    {
                        comCar.Write("1");
                        Thread.Sleep(300);
                    }
                    if (carGoBack)
                    {
                        comCar.Write("000000000");
                        carGoBack = false;
                    }
                    Thread.Sleep(100);
                }
            
            comCar.Close();
        }

        private void Recognition(out string figureName, out double figurePercent)
        {
            ShapeRecognition SR = new ShapeRecognition();

            SR.DetectObject(pictureWebCam.Image, "Templates", out figureName, out figurePercent);
        }

        private void ToImgHistory()
        {
            if (imgNumber < 10)
            {
                imgHistory[imgNumber] = pictureWebCam.Image;
                imgNumber++;
                trackBar1.Maximum = imgNumber;
            }
            else
            {
                for(int i = 0; i < 9; i++)
                {
                    imgHistory[i] = imgHistory[i + 1];
                }
                imgHistory[9] = pictureWebCam.Image;
            }
        }
        
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            labelStatusBar.Text = "Открыто окно настрек";
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "CameraPath", settingsForm.cameraPath);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "TrainingMode", settingsForm.trainingMode);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "RecognitionThreshold", settingsForm.recognitionThreshold);

                trainingMode = settingsForm.trainingMode;
                recognitionThreshold = Convert.ToDouble(settingsForm.recognitionThreshold);
                labelStatusBar.Text = "Настройки сохранены!";
            }
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            if (!cameraIsCapturing)
            {
                string camPath = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "CameraPath", "").ToString();
                int camId = -1;

                DsDevice[] systemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
                for (int i = 0; i < systemCamereas.Length; i++)
                {
                    if (systemCamereas[i].DevicePath == camPath)
                    {
                        camId = i;
                        break;
                    }
                }

                if (camId >= 0)
                {
                    
                    camera = new Capture(camId);
                    cameraIsCapturing = true;
                    buttonCamera.Text = "Выключить камеру";
                    timerWebCam.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Не выбрана камера!\nНеобходимо выбрать камеру в настроках.", "Не выбрана камера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonSettings_Click(null, null);
                }
            }
            else
            {
                camera.Dispose();
                timerWebCam.Enabled = false;
                cameraIsCapturing = false;
                buttonCamera.Text = "Включить камеру";
            }
            labelStatusBar.Text = "Камера: " + cameraIsCapturing.ToString();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            if (carGo)
            {
                carGo = false;
                buttonLine.Text = "Включить ленту";
            }
            else
            {
                carGo = true;
                buttonLine.Text = "Выключить ленту";
            }
            labelStatusBar.Text = "Лента: " + carGo.ToString();
        }

        private void timerListenCOM_Tick(object sender, EventArgs e)
        {
            if (comArduino.BytesToRead > 0)
            {
                int command = comArduino.ReadByte();
                switch (command)
                {
                    case 7: // Предмет перед сенсором
                        {
                            carGo = false;
                            buttonLine.Text = "Включить ленту"; // Включить машинку

                            
                            if (trainingMode)
                            {
                                TrainingForm trainingForm = new TrainingForm(pictureWebCam.Image);
                                if (trainingForm.ShowDialog() == DialogResult.OK)
                                    labelStatusBar.Text = "Обучение успешно выполнено";

                                comArduino.Write("3");
                            }
                            else
                            {
                                string figureName;
                                double figurePercent;


                                timerWebCam_Tick(null, null);
                                timerWebCam_Tick(null, null);
                                ToImgHistory();
                                trackBar1.Value = trackBar1.Maximum;

                                Recognition(out figureName, out figurePercent);

                                labelStatusBar.Text = figureName + " found with " + Math.Round(figurePercent*100, 2) + "%";

                                if (figurePercent * 100 < recognitionThreshold)
                                {
                                    carGoBack = true;
                                    comArduino.Write("3");
                                    return;
                                }

                                DirectoryInfo dir = Directory.CreateDirectory(Path.Combine("Templates", figureName));
                                string pathObjInfo = Path.Combine(dir.FullName, "ObjectInfo.xml");

                                Stream stream = new FileStream(pathObjInfo, FileMode.Open);
                                XmlSerializer serializer = new XmlSerializer(typeof(ObjectInfo));
                                ObjectInfo objInfo = (ObjectInfo)serializer.Deserialize(stream);
                                stream.Close();

                                switch (objInfo.Direction)
                                {
                                    case "Left":
                                        comArduino.Write("1");
                                        break;
                                    case "Right":
                                        comArduino.Write("2");
                                        break;

                                    default:
                                        comArduino.Write("3");
                                        break;
                                }
                                
                            }
                        }
                        break;
                    case 8: // все выполнено
                        carGoBack = true;
                        break;

                    default:
                        break;
                }
            }
        }

        private void timerWebCam_Tick(object sender, EventArgs e)
        {
            Image<Bgr, Byte> img = camera.QueryFrame().ToImage<Bgr, Byte>();
            pictureWebCam.Image = img.ToBitmap();

            img.Dispose();

        }

        private void buttonArduino_Click(object sender, EventArgs e)
        {
            try
            {
                if (!arduinoIsWorking)
                {
                    // arduino
                    comArduino.Open();
                    timerListenCOM.Enabled = true;
                    comArduino.Write("47");

                    // car
                    threadCarGoing.Start();


                    buttonArduino.Text = "Выключить Arduino";
                    arduinoIsWorking = true;

                }
                else
                {
                    buttonArduino.Text = "Включить Arduino";
                    arduinoIsWorking = false;

                    // arduino
                    timerListenCOM.Enabled = false;
                    comArduino.Close();
                }
                labelStatusBar.Text = "Arduino: " + arduinoIsWorking.ToString();
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к Arduino", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTemplates_Click(object sender, EventArgs e)
        {
            labelStatusBar.Text = "Открыто окно шаблонов";
            TemplatesArchive templatesArchive = new TemplatesArchive();
            templatesArchive.ShowDialog();
        }

        private void labelBtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент РКСИ \nгруппы ПОКС-41 Анатолий Кукуюк", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            if (trackBar.Value != trackBar.Maximum)
            {
                timerWebCam.Enabled = false;
                pictureWebCam.Image = imgHistory[trackBar.Value];
                labelStatusBar.Text = "Открыто изображение №" + (trackBar.Value + 1);
            }
            else
            {
                timerWebCam.Enabled = true;
                labelStatusBar.Text = "Переход к вебкамере";
            }
        }

        private void buttonToWebcam_Click(object sender, EventArgs e)
        { trackBar1.Value = trackBar1.Maximum; }

        private void buttonToFirst_Click(object sender, EventArgs e)
        { trackBar1.Value = 0;}
        
    }
}