namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drivesListBox = new System.Windows.Forms.ListBox();
            this.directoriesListBox = new System.Windows.Forms.ListBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.propertiesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.createDirectoryButton = new System.Windows.Forms.Button();
            this.copyDirectoryButton = new System.Windows.Forms.Button();
            this.deleteDirectoryButton = new System.Windows.Forms.Button();
            this.createFileButton = new System.Windows.Forms.Button();
            this.copyFileButton = new System.Windows.Forms.Button();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.editAttributesButton = new System.Windows.Forms.Button();
            this.newDirectoryNameTextBox = new System.Windows.Forms.TextBox();
            this.newFileNameTextBox = new System.Windows.Forms.TextBox();
            this.editFileButton = new System.Windows.Forms.Button();
            this.compressButton = new System.Windows.Forms.Button();
            this.decompressButton = new System.Windows.Forms.Button();
            this.moveFileButton = new System.Windows.Forms.Button();
            this.moveDirectoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drivesListBox
            // 
            this.drivesListBox.FormattingEnabled = true;
            this.drivesListBox.Location = new System.Drawing.Point(13, 45);
            this.drivesListBox.Name = "drivesListBox";
            this.drivesListBox.Size = new System.Drawing.Size(148, 147);
            this.drivesListBox.TabIndex = 0;
            this.drivesListBox.SelectedIndexChanged += new System.EventHandler(this.drivesListBox_SelectedIndexChanged);
            // 
            // directoriesListBox
            // 
            this.directoriesListBox.FormattingEnabled = true;
            this.directoriesListBox.Location = new System.Drawing.Point(640, 33);
            this.directoriesListBox.Name = "directoriesListBox";
            this.directoriesListBox.Size = new System.Drawing.Size(521, 173);
            this.directoriesListBox.TabIndex = 1;
            this.directoriesListBox.SelectedIndexChanged += new System.EventHandler(this.directoriesListBox_SelectedIndexChanged);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(640, 227);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(521, 186);
            this.filesListBox.TabIndex = 2;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
            // 
            // propertiesTextBox
            // 
            this.propertiesTextBox.Location = new System.Drawing.Point(244, 33);
            this.propertiesTextBox.Multiline = true;
            this.propertiesTextBox.Name = "propertiesTextBox";
            this.propertiesTextBox.Size = new System.Drawing.Size(368, 96);
            this.propertiesTextBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(63, 330);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(534, 262);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(244, 164);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(368, 113);
            this.contentTextBox.TabIndex = 5;
            // 
            // createDirectoryButton
            // 
            this.createDirectoryButton.Location = new System.Drawing.Point(640, 469);
            this.createDirectoryButton.Name = "createDirectoryButton";
            this.createDirectoryButton.Size = new System.Drawing.Size(134, 23);
            this.createDirectoryButton.TabIndex = 6;
            this.createDirectoryButton.Text = "createDirectory";
            this.createDirectoryButton.UseVisualStyleBackColor = true;
            this.createDirectoryButton.Click += new System.EventHandler(this.createDirectoryButton_Click);
            // 
            // copyDirectoryButton
            // 
            this.copyDirectoryButton.Location = new System.Drawing.Point(780, 469);
            this.copyDirectoryButton.Name = "copyDirectoryButton";
            this.copyDirectoryButton.Size = new System.Drawing.Size(134, 23);
            this.copyDirectoryButton.TabIndex = 7;
            this.copyDirectoryButton.Text = "copyDirectory";
            this.copyDirectoryButton.UseVisualStyleBackColor = true;
            this.copyDirectoryButton.Click += new System.EventHandler(this.copyDirectoryButton_Click);
            // 
            // deleteDirectoryButton
            // 
            this.deleteDirectoryButton.Location = new System.Drawing.Point(640, 513);
            this.deleteDirectoryButton.Name = "deleteDirectoryButton";
            this.deleteDirectoryButton.Size = new System.Drawing.Size(134, 23);
            this.deleteDirectoryButton.TabIndex = 8;
            this.deleteDirectoryButton.Text = "deleteDirectory";
            this.deleteDirectoryButton.UseVisualStyleBackColor = true;
            this.deleteDirectoryButton.Click += new System.EventHandler(this.deleteDirectoryButton_Click);
            // 
            // createFileButton
            // 
            this.createFileButton.Location = new System.Drawing.Point(920, 469);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(133, 23);
            this.createFileButton.TabIndex = 9;
            this.createFileButton.Text = "createFileButton";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // copyFileButton
            // 
            this.copyFileButton.Location = new System.Drawing.Point(780, 513);
            this.copyFileButton.Name = "copyFileButton";
            this.copyFileButton.Size = new System.Drawing.Size(134, 23);
            this.copyFileButton.TabIndex = 10;
            this.copyFileButton.Text = "copyFileButton";
            this.copyFileButton.UseVisualStyleBackColor = true;
            this.copyFileButton.Click += new System.EventHandler(this.copyFileButton_Click);
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Location = new System.Drawing.Point(921, 513);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(133, 23);
            this.deleteFileButton.TabIndex = 11;
            this.deleteFileButton.Text = "deleteFileButton";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // editAttributesButton
            // 
            this.editAttributesButton.Location = new System.Drawing.Point(352, 135);
            this.editAttributesButton.Name = "editAttributesButton";
            this.editAttributesButton.Size = new System.Drawing.Size(134, 23);
            this.editAttributesButton.TabIndex = 12;
            this.editAttributesButton.Text = "editAttributes";
            this.editAttributesButton.UseVisualStyleBackColor = true;
            this.editAttributesButton.Click += new System.EventHandler(this.editAttributesButton_Click);
            // 
            // newDirectoryNameTextBox
            // 
            this.newDirectoryNameTextBox.Location = new System.Drawing.Point(640, 443);
            this.newDirectoryNameTextBox.Name = "newDirectoryNameTextBox";
            this.newDirectoryNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.newDirectoryNameTextBox.TabIndex = 13;
            // 
            // newFileNameTextBox
            // 
            this.newFileNameTextBox.Location = new System.Drawing.Point(920, 443);
            this.newFileNameTextBox.Name = "newFileNameTextBox";
            this.newFileNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.newFileNameTextBox.TabIndex = 14;
            // 
            // editFileButton
            // 
            this.editFileButton.Location = new System.Drawing.Point(343, 283);
            this.editFileButton.Name = "editFileButton";
            this.editFileButton.Size = new System.Drawing.Size(134, 23);
            this.editFileButton.TabIndex = 15;
            this.editFileButton.Text = "editFileButton";
            this.editFileButton.UseVisualStyleBackColor = true;
            this.editFileButton.Click += new System.EventHandler(this.editFileButton_Click);
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(640, 554);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(134, 23);
            this.compressButton.TabIndex = 16;
            this.compressButton.Text = "compressButton";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // decompressButton
            // 
            this.decompressButton.Location = new System.Drawing.Point(919, 553);
            this.decompressButton.Name = "decompressButton";
            this.decompressButton.Size = new System.Drawing.Size(134, 23);
            this.decompressButton.TabIndex = 17;
            this.decompressButton.Text = "decompressButton";
            this.decompressButton.UseVisualStyleBackColor = true;
            this.decompressButton.Click += new System.EventHandler(this.decompressButton_Click);
            // 
            // moveFileButton
            // 
            this.moveFileButton.Location = new System.Drawing.Point(640, 583);
            this.moveFileButton.Name = "moveFileButton";
            this.moveFileButton.Size = new System.Drawing.Size(134, 23);
            this.moveFileButton.TabIndex = 18;
            this.moveFileButton.Text = "moveFile";
            this.moveFileButton.UseVisualStyleBackColor = true;
            this.moveFileButton.Click += new System.EventHandler(this.moveFileButton_Click);
            // 
            // moveDirectoryButton
            // 
            this.moveDirectoryButton.Location = new System.Drawing.Point(919, 583);
            this.moveDirectoryButton.Name = "moveDirectoryButton";
            this.moveDirectoryButton.Size = new System.Drawing.Size(134, 23);
            this.moveDirectoryButton.TabIndex = 19;
            this.moveDirectoryButton.Text = "moveDirectory";
            this.moveDirectoryButton.UseVisualStyleBackColor = true;
            this.moveDirectoryButton.Click += new System.EventHandler(this.moveDirectoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 653);
            this.Controls.Add(this.moveDirectoryButton);
            this.Controls.Add(this.moveFileButton);
            this.Controls.Add(this.decompressButton);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.editFileButton);
            this.Controls.Add(this.newFileNameTextBox);
            this.Controls.Add(this.newDirectoryNameTextBox);
            this.Controls.Add(this.editAttributesButton);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.copyFileButton);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.deleteDirectoryButton);
            this.Controls.Add(this.copyDirectoryButton);
            this.Controls.Add(this.createDirectoryButton);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.propertiesTextBox);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.directoriesListBox);
            this.Controls.Add(this.drivesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox drivesListBox;
        private System.Windows.Forms.ListBox directoriesListBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.TextBox propertiesTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button createDirectoryButton;
        private System.Windows.Forms.Button copyDirectoryButton;
        private System.Windows.Forms.Button deleteDirectoryButton;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Button copyFileButton;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button editAttributesButton;
        private System.Windows.Forms.TextBox newDirectoryNameTextBox;
        private System.Windows.Forms.TextBox newFileNameTextBox;
        private System.Windows.Forms.Button editFileButton;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button decompressButton;
        private System.Windows.Forms.Button moveFileButton;
        private System.Windows.Forms.Button moveDirectoryButton;
    }
}

