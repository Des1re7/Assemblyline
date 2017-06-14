namespace AssemblyLine
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxTrainingMode = new System.Windows.Forms.CheckBox();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            this.labelCam = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericRecognitionThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericRecognitionThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxTrainingMode
            // 
            this.checkBoxTrainingMode.AutoSize = true;
            this.checkBoxTrainingMode.Location = new System.Drawing.Point(13, 79);
            this.checkBoxTrainingMode.Name = "checkBoxTrainingMode";
            this.checkBoxTrainingMode.Size = new System.Drawing.Size(110, 17);
            this.checkBoxTrainingMode.TabIndex = 0;
            this.checkBoxTrainingMode.Text = "Режим обучения";
            this.checkBoxTrainingMode.UseVisualStyleBackColor = true;
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Location = new System.Drawing.Point(12, 28);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(260, 21);
            this.comboBoxCamera.TabIndex = 1;
            // 
            // labelCam
            // 
            this.labelCam.AutoSize = true;
            this.labelCam.Location = new System.Drawing.Point(13, 12);
            this.labelCam.Name = "labelCam";
            this.labelCam.Size = new System.Drawing.Size(46, 13);
            this.labelCam.TabIndex = 2;
            this.labelCam.Text = "Камера";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericRecognitionThreshold
            // 
            this.numericRecognitionThreshold.Location = new System.Drawing.Point(222, 54);
            this.numericRecognitionThreshold.Name = "numericRecognitionThreshold";
            this.numericRecognitionThreshold.Size = new System.Drawing.Size(50, 20);
            this.numericRecognitionThreshold.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Минимальный порог распознования, %";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericRecognitionThreshold);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCam);
            this.Controls.Add(this.comboBoxCamera);
            this.Controls.Add(this.checkBoxTrainingMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.numericRecognitionThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTrainingMode;
        private System.Windows.Forms.ComboBox comboBoxCamera;
        private System.Windows.Forms.Label labelCam;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericRecognitionThreshold;
        private System.Windows.Forms.Label label1;
    }
}