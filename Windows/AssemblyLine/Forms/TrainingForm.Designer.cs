namespace AssemblyLine
{
    partial class TrainingForm
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutNew = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.tableLayoutMain.SetColumnSpan(this.pictureBoxImage, 2);
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(854, 420);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseDown);
            this.pictureBoxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseMove);
            this.pictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseUp);
            // 
            // comboBoxTemplates
            // 
            this.tableLayoutMain.SetColumnSpan(this.comboBoxTemplates, 2);
            this.comboBoxTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Items.AddRange(new object[] {
            "Новый шаблон"});
            this.comboBoxTemplates.Location = new System.Drawing.Point(3, 429);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(854, 21);
            this.comboBoxTemplates.TabIndex = 1;
            this.comboBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplates_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(3, 519);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(424, 24);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.Controls.Add(this.pictureBoxImage, 0, 0);
            this.tableLayoutMain.Controls.Add(this.buttonSave, 0, 3);
            this.tableLayoutMain.Controls.Add(this.comboBoxTemplates, 0, 1);
            this.tableLayoutMain.Controls.Add(this.buttonCancel, 1, 3);
            this.tableLayoutMain.Controls.Add(this.tableLayoutNew, 0, 2);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 4;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutMain.Size = new System.Drawing.Size(860, 546);
            this.tableLayoutMain.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(433, 519);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(424, 24);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutNew
            // 
            this.tableLayoutNew.ColumnCount = 2;
            this.tableLayoutMain.SetColumnSpan(this.tableLayoutNew, 2);
            this.tableLayoutNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutNew.Controls.Add(this.label4, 0, 1);
            this.tableLayoutNew.Controls.Add(this.comboBoxDirection, 0, 1);
            this.tableLayoutNew.Controls.Add(this.label1, 0, 0);
            this.tableLayoutNew.Controls.Add(this.textBoxNewName, 1, 0);
            this.tableLayoutNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutNew.Location = new System.Drawing.Point(0, 456);
            this.tableLayoutNew.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutNew.Name = "tableLayoutNew";
            this.tableLayoutNew.RowCount = 2;
            this.tableLayoutNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutNew.Size = new System.Drawing.Size(860, 60);
            this.tableLayoutNew.TabIndex = 4;
            this.tableLayoutNew.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "В какую сторону толкать";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.comboBoxDirection.Location = new System.Drawing.Point(153, 33);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(704, 21);
            this.comboBoxDirection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новое имя:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewName.Location = new System.Drawing.Point(153, 3);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(704, 20);
            this.textBoxNewName.TabIndex = 1;
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 546);
            this.Controls.Add(this.tableLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обучение программы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutNew.ResumeLayout(false);
            this.tableLayoutNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label label4;
    }
}