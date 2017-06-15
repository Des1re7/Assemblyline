namespace AssemblyLine
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonToWebcam = new DevExpress.XtraEditors.SimpleButton();
            this.buttonToFirst = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLine = new DevExpress.XtraEditors.SimpleButton();
            this.buttonArduino = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCamera = new DevExpress.XtraEditors.SimpleButton();
            this.buttonTemplates = new DevExpress.XtraEditors.SimpleButton();
            this.pictureWebCam = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelStatusBar = new System.Windows.Forms.Label();
            this.labelBtnInfo = new System.Windows.Forms.Label();
            this.buttonSettings = new DevExpress.XtraEditors.SimpleButton();
            this.timerListenCOM = new System.Windows.Forms.Timer(this.components);
            this.timerWebCam = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonToWebcam, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonToFirst, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonLine, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonArduino, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCamera, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTemplates, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureWebCam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelStatusBar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelBtnInfo, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonSettings, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonToWebcam
            // 
            this.buttonToWebcam.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToWebcam.Appearance.Options.UseFont = true;
            this.buttonToWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToWebcam.Enabled = false;
            this.buttonToWebcam.Location = new System.Drawing.Point(411, 374);
            this.buttonToWebcam.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonToWebcam.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonToWebcam.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonToWebcam.Name = "buttonToWebcam";
            this.buttonToWebcam.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonToWebcam.Size = new System.Drawing.Size(130, 91);
            this.buttonToWebcam.TabIndex = 20;
            this.buttonToWebcam.Text = "К вебкамере";
            this.buttonToWebcam.Click += new System.EventHandler(this.buttonToWebcam_Click);
            // 
            // buttonToFirst
            // 
            this.buttonToFirst.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToFirst.Appearance.Options.UseFont = true;
            this.buttonToFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToFirst.Enabled = false;
            this.buttonToFirst.Location = new System.Drawing.Point(139, 374);
            this.buttonToFirst.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonToFirst.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonToFirst.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonToFirst.Name = "buttonToFirst";
            this.buttonToFirst.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonToFirst.Size = new System.Drawing.Size(130, 91);
            this.buttonToFirst.TabIndex = 19;
            this.buttonToFirst.Text = "К первому";
            this.buttonToFirst.Click += new System.EventHandler(this.buttonToFirst_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLine.Appearance.Options.UseFont = true;
            this.buttonLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLine.Location = new System.Drawing.Point(3, 237);
            this.buttonLine.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonLine.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonLine.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonLine.Size = new System.Drawing.Size(130, 91);
            this.buttonLine.TabIndex = 18;
            this.buttonLine.Text = "Включить ленту";
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonArduino
            // 
            this.buttonArduino.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArduino.Appearance.Options.UseFont = true;
            this.buttonArduino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonArduino.Location = new System.Drawing.Point(3, 140);
            this.buttonArduino.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonArduino.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonArduino.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonArduino.Name = "buttonArduino";
            this.buttonArduino.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonArduino.Size = new System.Drawing.Size(130, 91);
            this.buttonArduino.TabIndex = 17;
            this.buttonArduino.Text = "Включить Arduino";
            this.buttonArduino.Click += new System.EventHandler(this.buttonArduino_Click);
            // 
            // buttonCamera
            // 
            this.buttonCamera.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCamera.Appearance.Options.UseFont = true;
            this.buttonCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCamera.Location = new System.Drawing.Point(3, 43);
            this.buttonCamera.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonCamera.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonCamera.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonCamera.Size = new System.Drawing.Size(130, 91);
            this.buttonCamera.TabIndex = 16;
            this.buttonCamera.Text = "Включить камеру";
            this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
            // 
            // buttonTemplates
            // 
            this.buttonTemplates.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTemplates.Appearance.Options.UseFont = true;
            this.buttonTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTemplates.Location = new System.Drawing.Point(547, 140);
            this.buttonTemplates.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonTemplates.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonTemplates.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonTemplates.Name = "buttonTemplates";
            this.buttonTemplates.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonTemplates.Size = new System.Drawing.Size(134, 91);
            this.buttonTemplates.TabIndex = 15;
            this.buttonTemplates.Text = "Архив \r\nшаблонов";
            this.buttonTemplates.Click += new System.EventHandler(this.buttonTemplates_Click);
            // 
            // pictureWebCam
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureWebCam, 3);
            this.pictureWebCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureWebCam.Location = new System.Drawing.Point(136, 40);
            this.pictureWebCam.Margin = new System.Windows.Forms.Padding(0);
            this.pictureWebCam.Name = "pictureWebCam";
            this.tableLayoutPanel1.SetRowSpan(this.pictureWebCam, 3);
            this.pictureWebCam.Size = new System.Drawing.Size(408, 291);
            this.pictureWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWebCam.TabIndex = 0;
            this.pictureWebCam.TabStop = false;
            // 
            // trackBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar1, 3);
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(136, 331);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 0;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(408, 40);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // labelStatusBar
            // 
            this.labelStatusBar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelStatusBar, 4);
            this.labelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatusBar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusBar.Location = new System.Drawing.Point(3, 489);
            this.labelStatusBar.Name = "labelStatusBar";
            this.labelStatusBar.Size = new System.Drawing.Size(538, 22);
            this.labelStatusBar.TabIndex = 9;
            // 
            // labelBtnInfo
            // 
            this.labelBtnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBtnInfo.AutoSize = true;
            this.labelBtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBtnInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtnInfo.Location = new System.Drawing.Point(651, 479);
            this.labelBtnInfo.Name = "labelBtnInfo";
            this.labelBtnInfo.Size = new System.Drawing.Size(30, 32);
            this.labelBtnInfo.TabIndex = 10;
            this.labelBtnInfo.Text = "?";
            this.labelBtnInfo.Click += new System.EventHandler(this.labelBtnInfo_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Appearance.Options.UseFont = true;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSettings.Location = new System.Drawing.Point(547, 43);
            this.buttonSettings.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.buttonSettings.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.buttonSettings.LookAndFeel.UseDefaultLookAndFeel = false;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonSettings.Size = new System.Drawing.Size(134, 91);
            this.buttonSettings.TabIndex = 14;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // timerListenCOM
            // 
            this.timerListenCOM.Tick += new System.EventHandler(this.timerListenCOM_Tick);
            // 
            // timerWebCam
            // 
            this.timerWebCam.Interval = 40;
            this.timerWebCam.Tick += new System.EventHandler(this.timerWebCam_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Сортировочная станция";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureWebCam;
        private System.Windows.Forms.Label labelStatusBar;
        private System.Windows.Forms.Label labelBtnInfo;
        private System.Windows.Forms.Timer timerListenCOM;
        private System.Windows.Forms.Timer timerWebCam;
        private DevExpress.XtraEditors.SimpleButton buttonSettings;
        private DevExpress.XtraEditors.SimpleButton buttonTemplates;
        private DevExpress.XtraEditors.SimpleButton buttonCamera;
        private DevExpress.XtraEditors.SimpleButton buttonLine;
        private DevExpress.XtraEditors.SimpleButton buttonArduino;
        private DevExpress.XtraEditors.SimpleButton buttonToWebcam;
        private DevExpress.XtraEditors.SimpleButton buttonToFirst;
    }
}