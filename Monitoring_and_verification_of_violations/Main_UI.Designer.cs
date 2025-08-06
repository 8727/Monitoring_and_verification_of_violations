namespace Monitoring_and_verification_of_violations
{
    partial class Main_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_UI));
            this.Drop = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Verification_Correct = new System.Windows.Forms.Button();
            this.Verification_Incorrect = new System.Windows.Forms.Button();
            this.Video = new System.Windows.Forms.Button();
            this.Verification_CheckBox = new System.Windows.Forms.CheckBox();
            this.Recognition_CheckBox = new System.Windows.Forms.CheckBox();
            this.number_regno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Count_Files = new System.Windows.Forms.TextBox();
            this.Count_Files_Label = new System.Windows.Forms.Label();
            this.Cars_List = new System.Windows.Forms.ListBox();
            this.img_photo_ts = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.img_photo_grz = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.Select_Factor_Source = new System.Windows.Forms.Button();
            this.Select_Folder_Source = new System.Windows.Forms.Button();
            this.Drop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_photo_ts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_photo_grz)).BeginInit();
            this.SuspendLayout();
            // 
            // Drop
            // 
            this.Drop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drop.Controls.Add(this.progressBar);
            this.Drop.Controls.Add(this.Verification_Correct);
            this.Drop.Controls.Add(this.Verification_Incorrect);
            this.Drop.Controls.Add(this.img_photo_ts);
            this.Drop.Controls.Add(this.Video);
            this.Drop.Controls.Add(this.Verification_CheckBox);
            this.Drop.Controls.Add(this.Recognition_CheckBox);
            this.Drop.Controls.Add(this.Save);
            this.Drop.Controls.Add(this.number_regno);
            this.Drop.Controls.Add(this.img_photo_grz);
            this.Drop.Controls.Add(this.groupBox1);
            this.Drop.Controls.Add(this.Cars_List);
            this.Drop.Location = new System.Drawing.Point(2, 2);
            this.Drop.Margin = new System.Windows.Forms.Padding(6);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(1496, 815);
            this.Drop.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(213, 89);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1280, 10);
            this.progressBar.TabIndex = 30;
            this.progressBar.Visible = false;
            // 
            // Verification_Correct
            // 
            this.Verification_Correct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Verification_Correct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Verification_Correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Verification_Correct.Location = new System.Drawing.Point(873, 740);
            this.Verification_Correct.Name = "Verification_Correct";
            this.Verification_Correct.Size = new System.Drawing.Size(140, 50);
            this.Verification_Correct.TabIndex = 28;
            this.Verification_Correct.Text = "Correct";
            this.Verification_Correct.UseVisualStyleBackColor = false;
            this.Verification_Correct.Click += new System.EventHandler(this.Verification_Correct_Click);
            // 
            // Verification_Incorrect
            // 
            this.Verification_Incorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Verification_Incorrect.BackColor = System.Drawing.Color.Red;
            this.Verification_Incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Verification_Incorrect.Location = new System.Drawing.Point(693, 740);
            this.Verification_Incorrect.Name = "Verification_Incorrect";
            this.Verification_Incorrect.Size = new System.Drawing.Size(140, 50);
            this.Verification_Incorrect.TabIndex = 29;
            this.Verification_Incorrect.Text = "Incorrect";
            this.Verification_Incorrect.UseVisualStyleBackColor = false;
            this.Verification_Incorrect.Click += new System.EventHandler(this.Verification_Incorrect_Click);
            // 
            // Video
            // 
            this.Video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Video.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Video.Enabled = false;
            this.Video.FlatAppearance.BorderSize = 0;
            this.Video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Video.ForeColor = System.Drawing.Color.White;
            this.Video.Location = new System.Drawing.Point(778, 6);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(80, 80);
            this.Video.TabIndex = 26;
            this.Video.UseVisualStyleBackColor = false;
            this.Video.Click += new System.EventHandler(this.Video_Click);
            // 
            // Verification_CheckBox
            // 
            this.Verification_CheckBox.AutoSize = true;
            this.Verification_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Verification_CheckBox.Location = new System.Drawing.Point(617, 53);
            this.Verification_CheckBox.Name = "Verification_CheckBox";
            this.Verification_CheckBox.Size = new System.Drawing.Size(133, 28);
            this.Verification_CheckBox.TabIndex = 25;
            this.Verification_CheckBox.Text = "Verification";
            this.Verification_CheckBox.UseVisualStyleBackColor = true;
            this.Verification_CheckBox.Click += new System.EventHandler(this.Verification_CheckBox_CheckedChanged);
            // 
            // Recognition_CheckBox
            // 
            this.Recognition_CheckBox.AutoSize = true;
            this.Recognition_CheckBox.Checked = true;
            this.Recognition_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Recognition_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_CheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Recognition_CheckBox.Location = new System.Drawing.Point(617, 13);
            this.Recognition_CheckBox.Name = "Recognition_CheckBox";
            this.Recognition_CheckBox.Size = new System.Drawing.Size(141, 28);
            this.Recognition_CheckBox.TabIndex = 24;
            this.Recognition_CheckBox.Text = "Recognition";
            this.Recognition_CheckBox.UseVisualStyleBackColor = true;
            this.Recognition_CheckBox.Click += new System.EventHandler(this.Recognition_CheckBox_CheckedChanged);
            // 
            // number_regno
            // 
            this.number_regno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.number_regno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.number_regno.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_regno.Location = new System.Drawing.Point(1173, 11);
            this.number_regno.Name = "number_regno";
            this.number_regno.ReadOnly = true;
            this.number_regno.Size = new System.Drawing.Size(320, 67);
            this.number_regno.TabIndex = 22;
            this.number_regno.Text = "*001аА%";
            this.number_regno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number_regno.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Count_Files);
            this.groupBox1.Controls.Add(this.Count_Files_Label);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Filter);
            this.groupBox1.Controls.Add(this.Select_Factor_Source);
            this.groupBox1.Controls.Add(this.Select_Folder_Source);
            this.groupBox1.Location = new System.Drawing.Point(213, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 87);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Count_Files
            // 
            this.Count_Files.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Count_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Count_Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_Files.Location = new System.Drawing.Point(230, 48);
            this.Count_Files.Name = "Count_Files";
            this.Count_Files.ReadOnly = true;
            this.Count_Files.Size = new System.Drawing.Size(89, 37);
            this.Count_Files.TabIndex = 15;
            this.Count_Files.Text = "0";
            this.Count_Files.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Count_Files_Label
            // 
            this.Count_Files_Label.AutoSize = true;
            this.Count_Files_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_Files_Label.Location = new System.Drawing.Point(230, 14);
            this.Count_Files_Label.Name = "Count_Files_Label";
            this.Count_Files_Label.Size = new System.Drawing.Size(89, 37);
            this.Count_Files_Label.TabIndex = 13;
            this.Count_Files_Label.Text = "Files";
            // 
            // Cars_List
            // 
            this.Cars_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Cars_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cars_List.FormattingEnabled = true;
            this.Cars_List.ItemHeight = 20;
            this.Cars_List.Location = new System.Drawing.Point(3, 5);
            this.Cars_List.Name = "Cars_List";
            this.Cars_List.Size = new System.Drawing.Size(204, 804);
            this.Cars_List.TabIndex = 0;
            this.Cars_List.SelectedIndexChanged += new System.EventHandler(this.Cars_List_SelectedIndexChanged);
            // 
            // img_photo_ts
            // 
            this.img_photo_ts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_photo_ts.BackColor = System.Drawing.Color.Gray;
            this.img_photo_ts.Location = new System.Drawing.Point(213, 89);
            this.img_photo_ts.Name = "img_photo_ts";
            this.img_photo_ts.Size = new System.Drawing.Size(1280, 720);
            this.img_photo_ts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_photo_ts.TabIndex = 27;
            this.img_photo_ts.TabStop = false;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Save.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.save;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(875, 6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 80);
            this.Save.TabIndex = 23;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // img_photo_grz
            // 
            this.img_photo_grz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_photo_grz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.img_photo_grz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_photo_grz.Location = new System.Drawing.Point(959, 2);
            this.img_photo_grz.Name = "img_photo_grz";
            this.img_photo_grz.Size = new System.Drawing.Size(208, 85);
            this.img_photo_grz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_photo_grz.TabIndex = 21;
            this.img_photo_grz.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Clear.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.tash;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(322, 14);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(70, 70);
            this.Clear.TabIndex = 11;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Filter.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.filter;
            this.Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Filter.FlatAppearance.BorderSize = 0;
            this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.Location = new System.Drawing.Point(155, 14);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(70, 70);
            this.Filter.TabIndex = 12;
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Select_Factor_Source
            // 
            this.Select_Factor_Source.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Select_Factor_Source.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.search;
            this.Select_Factor_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Select_Factor_Source.FlatAppearance.BorderSize = 0;
            this.Select_Factor_Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Factor_Source.ForeColor = System.Drawing.Color.White;
            this.Select_Factor_Source.Location = new System.Drawing.Point(80, 14);
            this.Select_Factor_Source.Name = "Select_Factor_Source";
            this.Select_Factor_Source.Size = new System.Drawing.Size(70, 70);
            this.Select_Factor_Source.TabIndex = 1;
            this.Select_Factor_Source.UseVisualStyleBackColor = false;
            this.Select_Factor_Source.Click += new System.EventHandler(this.Select_Factor_Source_Click);
            // 
            // Select_Folder_Source
            // 
            this.Select_Folder_Source.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Select_Folder_Source.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.folder;
            this.Select_Folder_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Select_Folder_Source.FlatAppearance.BorderSize = 0;
            this.Select_Folder_Source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Folder_Source.ForeColor = System.Drawing.Color.White;
            this.Select_Folder_Source.Location = new System.Drawing.Point(3, 14);
            this.Select_Folder_Source.Name = "Select_Folder_Source";
            this.Select_Folder_Source.Size = new System.Drawing.Size(70, 70);
            this.Select_Folder_Source.TabIndex = 0;
            this.Select_Folder_Source.UseVisualStyleBackColor = false;
            this.Select_Folder_Source.Click += new System.EventHandler(this.Select_Folder_Source_Click);
            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1500, 816);
            this.Controls.Add(this.Drop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1516, 855);
            this.Name = "Main_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring and verification of violations";
            this.Load += new System.EventHandler(this.Main_UI_Load);
            this.Drop.ResumeLayout(false);
            this.Drop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_photo_ts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_photo_grz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drop;
        private System.Windows.Forms.ListBox Cars_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Count_Files;
        private System.Windows.Forms.Label Count_Files_Label;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Select_Factor_Source;
        private System.Windows.Forms.Button Select_Folder_Source;
        private System.Windows.Forms.Button Video;
        private System.Windows.Forms.CheckBox Verification_CheckBox;
        private System.Windows.Forms.CheckBox Recognition_CheckBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox number_regno;
        private System.Windows.Forms.PictureBox img_photo_grz;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Verification_Correct;
        private System.Windows.Forms.Button Verification_Incorrect;
        private System.Windows.Forms.PictureBox img_photo_ts;
    }
}

