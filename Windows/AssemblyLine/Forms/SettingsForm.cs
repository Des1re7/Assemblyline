using System;
using System.Windows.Forms;

using DirectShowLib;
using Microsoft.Win32;

namespace AssemblyLine
{
    public partial class SettingsForm : Form
    {
        private DsDevice[] systemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

        public string cameraPath = "";
        public bool trainingMode = false;
        public decimal recognitionThreshold = 60;


        public SettingsForm()
        {
            InitializeComponent();

            foreach(DsDevice camera in systemCamereas)
            {
                comboBoxCamera.Items.Add(camera.Name);
            }

            initializeSettings();
        }
        private void initializeSettings()
        {
            try
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
                comboBoxCamera.SelectedIndex = camId;

                trainingMode = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "TrainingMode", false));
                checkBoxTrainingMode.Checked = trainingMode;

                recognitionThreshold = Convert.ToDecimal(Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Des1re Programs\AssemblyLine", "RecognitionThreshold", 60));
                numericRecognitionThreshold.Value = recognitionThreshold;
            }
            catch
            {
                checkBoxTrainingMode.Checked = trainingMode;
                numericRecognitionThreshold.Value = recognitionThreshold;
                MessageBox.Show("Не удалось считать все настройки!\nУстановка настроек по дефолту!", "Ошибка чтения настроек", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                cameraPath = systemCamereas[comboBoxCamera.SelectedIndex].DevicePath;
                trainingMode = checkBoxTrainingMode.Checked;
                recognitionThreshold = numericRecognitionThreshold.Value;
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить все настройки!", "Ошибка сохранения настроек", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
