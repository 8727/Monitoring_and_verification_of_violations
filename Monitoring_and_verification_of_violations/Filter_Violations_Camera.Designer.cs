namespace Monitoring_and_verification_of_violations
{
    partial class Filter_Violations_Camera
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
            this.Violations = new System.Windows.Forms.GroupBox();
            this.btnClearAll_V = new System.Windows.Forms.Button();
            this.btnSelectAll_V = new System.Windows.Forms.Button();
            this.violationsList = new System.Windows.Forms.CheckedListBox();
            this.Cameras = new System.Windows.Forms.GroupBox();
            this.btnClearAll_C = new System.Windows.Forms.Button();
            this.btnSelectAll_C = new System.Windows.Forms.Button();
            this.camerasList = new System.Windows.Forms.CheckedListBox();
            this.Recognition_Selected = new System.Windows.Forms.TextBox();
            this.Recognition_Selected_P = new System.Windows.Forms.Button();
            this.Recognition_Selected_M = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.Violations.SuspendLayout();
            this.Cameras.SuspendLayout();
            this.SuspendLayout();
            // 
            // Violations
            // 
            this.Violations.Controls.Add(this.btnClearAll_V);
            this.Violations.Controls.Add(this.btnSelectAll_V);
            this.Violations.Controls.Add(this.violationsList);
            this.Violations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Violations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Violations.ForeColor = System.Drawing.SystemColors.Window;
            this.Violations.Location = new System.Drawing.Point(12, 11);
            this.Violations.Name = "Violations";
            this.Violations.Size = new System.Drawing.Size(286, 319);
            this.Violations.TabIndex = 1;
            this.Violations.TabStop = false;
            this.Violations.Text = "Violations";
            // 
            // btnClearAll_V
            // 
            this.btnClearAll_V.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClearAll_V.Location = new System.Drawing.Point(206, 280);
            this.btnClearAll_V.Name = "btnClearAll_V";
            this.btnClearAll_V.Size = new System.Drawing.Size(75, 36);
            this.btnClearAll_V.TabIndex = 2;
            this.btnClearAll_V.Text = "Сlear";
            this.btnClearAll_V.UseVisualStyleBackColor = false;
            this.btnClearAll_V.Click += new System.EventHandler(this.btnClearAll_V_Click);
            // 
            // btnSelectAll_V
            // 
            this.btnSelectAll_V.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelectAll_V.Location = new System.Drawing.Point(6, 280);
            this.btnSelectAll_V.Name = "btnSelectAll_V";
            this.btnSelectAll_V.Size = new System.Drawing.Size(75, 36);
            this.btnSelectAll_V.TabIndex = 1;
            this.btnSelectAll_V.Text = "All";
            this.btnSelectAll_V.UseVisualStyleBackColor = false;
            this.btnSelectAll_V.Click += new System.EventHandler(this.btnSelectAll_V_Click);
            // 
            // violationsList
            // 
            this.violationsList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.violationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.violationsList.FormattingEnabled = true;
            this.violationsList.Location = new System.Drawing.Point(6, 22);
            this.violationsList.Name = "violationsList";
            this.violationsList.Size = new System.Drawing.Size(274, 256);
            this.violationsList.Sorted = true;
            this.violationsList.TabIndex = 0;
            // 
            // Cameras
            // 
            this.Cameras.Controls.Add(this.btnClearAll_C);
            this.Cameras.Controls.Add(this.btnSelectAll_C);
            this.Cameras.Controls.Add(this.camerasList);
            this.Cameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cameras.ForeColor = System.Drawing.SystemColors.Window;
            this.Cameras.Location = new System.Drawing.Point(314, 12);
            this.Cameras.Name = "Cameras";
            this.Cameras.Size = new System.Drawing.Size(172, 318);
            this.Cameras.TabIndex = 2;
            this.Cameras.TabStop = false;
            this.Cameras.Text = "Cameras";
            // 
            // btnClearAll_C
            // 
            this.btnClearAll_C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClearAll_C.Location = new System.Drawing.Point(91, 280);
            this.btnClearAll_C.Name = "btnClearAll_C";
            this.btnClearAll_C.Size = new System.Drawing.Size(75, 35);
            this.btnClearAll_C.TabIndex = 2;
            this.btnClearAll_C.Text = "Сlear";
            this.btnClearAll_C.UseVisualStyleBackColor = false;
            this.btnClearAll_C.Click += new System.EventHandler(this.btnClearAll_C_Click);
            // 
            // btnSelectAll_C
            // 
            this.btnSelectAll_C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelectAll_C.Location = new System.Drawing.Point(6, 280);
            this.btnSelectAll_C.Name = "btnSelectAll_C";
            this.btnSelectAll_C.Size = new System.Drawing.Size(75, 35);
            this.btnSelectAll_C.TabIndex = 1;
            this.btnSelectAll_C.Text = "All";
            this.btnSelectAll_C.UseVisualStyleBackColor = false;
            this.btnSelectAll_C.Click += new System.EventHandler(this.btnSelectAll_C_Click);
            // 
            // camerasList
            // 
            this.camerasList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.camerasList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.camerasList.FormattingEnabled = true;
            this.camerasList.Location = new System.Drawing.Point(6, 22);
            this.camerasList.Name = "camerasList";
            this.camerasList.Size = new System.Drawing.Size(160, 256);
            this.camerasList.Sorted = true;
            this.camerasList.TabIndex = 0;
            // 
            // Recognition_Selected
            // 
            this.Recognition_Selected.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recognition_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_Selected.Location = new System.Drawing.Point(48, 355);
            this.Recognition_Selected.Name = "Recognition_Selected";
            this.Recognition_Selected.ReadOnly = true;
            this.Recognition_Selected.Size = new System.Drawing.Size(299, 44);
            this.Recognition_Selected.TabIndex = 5;
            this.Recognition_Selected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Recognition_Selected_P
            // 
            this.Recognition_Selected_P.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recognition_Selected_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_Selected_P.ForeColor = System.Drawing.SystemColors.Control;
            this.Recognition_Selected_P.Location = new System.Drawing.Point(12, 345);
            this.Recognition_Selected_P.Name = "Recognition_Selected_P";
            this.Recognition_Selected_P.Size = new System.Drawing.Size(30, 65);
            this.Recognition_Selected_P.TabIndex = 6;
            this.Recognition_Selected_P.Text = "<";
            this.Recognition_Selected_P.UseVisualStyleBackColor = false;
            this.Recognition_Selected_P.Click += new System.EventHandler(this.Recognition_Selected_P_Click);
            // 
            // Recognition_Selected_M
            // 
            this.Recognition_Selected_M.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recognition_Selected_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_Selected_M.ForeColor = System.Drawing.SystemColors.Control;
            this.Recognition_Selected_M.Location = new System.Drawing.Point(353, 345);
            this.Recognition_Selected_M.Name = "Recognition_Selected_M";
            this.Recognition_Selected_M.Size = new System.Drawing.Size(30, 65);
            this.Recognition_Selected_M.TabIndex = 7;
            this.Recognition_Selected_M.Text = ">";
            this.Recognition_Selected_M.UseVisualStyleBackColor = false;
            this.Recognition_Selected_M.Click += new System.EventHandler(this.Recognition_Selected_M_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnApply.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.save_2;
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(406, 339);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 80);
            this.btnApply.TabIndex = 0;
            this.btnApply.UseMnemonic = false;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Filter_Violations_Camera
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(498, 428);
            this.ControlBox = false;
            this.Controls.Add(this.Recognition_Selected_M);
            this.Controls.Add(this.Recognition_Selected_P);
            this.Controls.Add(this.Recognition_Selected);
            this.Controls.Add(this.Cameras);
            this.Controls.Add(this.Violations);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Filter_Violations_Camera";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filret_Violations_Camera";
            this.Violations.ResumeLayout(false);
            this.Cameras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Violations;
        private System.Windows.Forms.GroupBox Cameras;
        private System.Windows.Forms.CheckedListBox violationsList;
        private System.Windows.Forms.CheckedListBox camerasList;
        private System.Windows.Forms.Button btnClearAll_V;
        private System.Windows.Forms.Button btnSelectAll_V;
        private System.Windows.Forms.Button btnClearAll_C;
        private System.Windows.Forms.Button btnSelectAll_C;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox Recognition_Selected;
        private System.Windows.Forms.Button Recognition_Selected_P;
        private System.Windows.Forms.Button Recognition_Selected_M;
    }
}