namespace Monitoring_and_verification_of_violations
{
    partial class Filter_Factor
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
            this.RangeIP = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.StopIP = new System.Windows.Forms.TextBox();
            this.StartIP = new System.Windows.Forms.TextBox();
            this.LebelStopIP = new System.Windows.Forms.Label();
            this.LebelStartIP = new System.Windows.Forms.Label();
            this.auti = new System.Windows.Forms.GroupBox();
            this.sshPort = new System.Windows.Forms.TextBox();
            this.labelSshPort = new System.Windows.Forms.Label();
            this.webPort = new System.Windows.Forms.TextBox();
            this.sshPass = new System.Windows.Forms.TextBox();
            this.labelWebPort = new System.Windows.Forms.Label();
            this.sshLogin = new System.Windows.Forms.TextBox();
            this.LebelPass = new System.Windows.Forms.Label();
            this.LebelLogin = new System.Windows.Forms.Label();
            this.Violations = new System.Windows.Forms.GroupBox();
            this.btnClearAll_V = new System.Windows.Forms.Button();
            this.btnSelectAll_V = new System.Windows.Forms.Button();
            this.violationsList = new System.Windows.Forms.CheckedListBox();
            this.Recognition_Selected_M = new System.Windows.Forms.Button();
            this.Recognition_Selected_P = new System.Windows.Forms.Button();
            this.Recognition_Selected = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RangeIP.SuspendLayout();
            this.auti.SuspendLayout();
            this.Violations.SuspendLayout();
            this.SuspendLayout();
            // 
            // RangeIP
            // 
            this.RangeIP.Controls.Add(this.Search);
            this.RangeIP.Controls.Add(this.StopIP);
            this.RangeIP.Controls.Add(this.StartIP);
            this.RangeIP.Controls.Add(this.LebelStopIP);
            this.RangeIP.Controls.Add(this.LebelStartIP);
            this.RangeIP.Location = new System.Drawing.Point(323, 3);
            this.RangeIP.Margin = new System.Windows.Forms.Padding(5);
            this.RangeIP.Name = "RangeIP";
            this.RangeIP.Padding = new System.Windows.Forms.Padding(5);
            this.RangeIP.Size = new System.Drawing.Size(310, 100);
            this.RangeIP.TabIndex = 2;
            this.RangeIP.TabStop = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.BackgroundImage = global::Monitoring_and_verification_of_violations.Properties.Resources.search;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(225, 13);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 80);
            this.Search.TabIndex = 7;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // StopIP
            // 
            this.StopIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopIP.Location = new System.Drawing.Point(75, 57);
            this.StopIP.Margin = new System.Windows.Forms.Padding(5);
            this.StopIP.Name = "StopIP";
            this.StopIP.Size = new System.Drawing.Size(147, 26);
            this.StopIP.TabIndex = 3;
            this.StopIP.Text = "10.158.1.20";
            this.StopIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartIP
            // 
            this.StartIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartIP.Location = new System.Drawing.Point(75, 21);
            this.StartIP.Margin = new System.Windows.Forms.Padding(5);
            this.StartIP.Name = "StartIP";
            this.StartIP.Size = new System.Drawing.Size(147, 26);
            this.StartIP.TabIndex = 2;
            this.StartIP.Text = "10.158.1.2";
            this.StartIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LebelStopIP
            // 
            this.LebelStopIP.AutoSize = true;
            this.LebelStopIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelStopIP.ForeColor = System.Drawing.SystemColors.Control;
            this.LebelStopIP.Location = new System.Drawing.Point(1, 60);
            this.LebelStopIP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelStopIP.Name = "LebelStopIP";
            this.LebelStopIP.Size = new System.Drawing.Size(74, 20);
            this.LebelStopIP.TabIndex = 1;
            this.LebelStopIP.Text = "Stop IP:";
            // 
            // LebelStartIP
            // 
            this.LebelStartIP.AutoSize = true;
            this.LebelStartIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelStartIP.ForeColor = System.Drawing.SystemColors.Control;
            this.LebelStartIP.Location = new System.Drawing.Point(1, 24);
            this.LebelStartIP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelStartIP.Name = "LebelStartIP";
            this.LebelStartIP.Size = new System.Drawing.Size(76, 20);
            this.LebelStartIP.TabIndex = 0;
            this.LebelStartIP.Text = "Start IP:";
            // 
            // auti
            // 
            this.auti.Controls.Add(this.sshPort);
            this.auti.Controls.Add(this.labelSshPort);
            this.auti.Controls.Add(this.webPort);
            this.auti.Controls.Add(this.sshPass);
            this.auti.Controls.Add(this.labelWebPort);
            this.auti.Controls.Add(this.sshLogin);
            this.auti.Controls.Add(this.LebelPass);
            this.auti.Controls.Add(this.LebelLogin);
            this.auti.Location = new System.Drawing.Point(323, 103);
            this.auti.Margin = new System.Windows.Forms.Padding(5);
            this.auti.Name = "auti";
            this.auti.Padding = new System.Windows.Forms.Padding(5);
            this.auti.Size = new System.Drawing.Size(310, 100);
            this.auti.TabIndex = 9;
            this.auti.TabStop = false;
            // 
            // sshPort
            // 
            this.sshPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sshPort.Location = new System.Drawing.Point(226, 58);
            this.sshPort.Margin = new System.Windows.Forms.Padding(5);
            this.sshPort.Name = "sshPort";
            this.sshPort.Size = new System.Drawing.Size(60, 26);
            this.sshPort.TabIndex = 12;
            this.sshPort.Text = "22";
            this.sshPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSshPort
            // 
            this.labelSshPort.AutoSize = true;
            this.labelSshPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSshPort.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSshPort.Location = new System.Drawing.Point(176, 61);
            this.labelSshPort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSshPort.Name = "labelSshPort";
            this.labelSshPort.Size = new System.Drawing.Size(51, 20);
            this.labelSshPort.TabIndex = 11;
            this.labelSshPort.Text = "SSH:";
            // 
            // webPort
            // 
            this.webPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webPort.Location = new System.Drawing.Point(227, 21);
            this.webPort.Margin = new System.Windows.Forms.Padding(5);
            this.webPort.Name = "webPort";
            this.webPort.Size = new System.Drawing.Size(60, 26);
            this.webPort.TabIndex = 10;
            this.webPort.Text = "80";
            this.webPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sshPass
            // 
            this.sshPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sshPass.Location = new System.Drawing.Point(55, 57);
            this.sshPass.Margin = new System.Windows.Forms.Padding(5);
            this.sshPass.Name = "sshPass";
            this.sshPass.PasswordChar = '*';
            this.sshPass.Size = new System.Drawing.Size(100, 26);
            this.sshPass.TabIndex = 3;
            this.sshPass.Text = "user";
            this.sshPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWebPort
            // 
            this.labelWebPort.AutoSize = true;
            this.labelWebPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWebPort.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWebPort.Location = new System.Drawing.Point(174, 24);
            this.labelWebPort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWebPort.Name = "labelWebPort";
            this.labelWebPort.Size = new System.Drawing.Size(54, 20);
            this.labelWebPort.TabIndex = 9;
            this.labelWebPort.Text = "WEB:";
            // 
            // sshLogin
            // 
            this.sshLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sshLogin.Location = new System.Drawing.Point(55, 21);
            this.sshLogin.Margin = new System.Windows.Forms.Padding(5);
            this.sshLogin.Name = "sshLogin";
            this.sshLogin.Size = new System.Drawing.Size(100, 26);
            this.sshLogin.TabIndex = 2;
            this.sshLogin.Text = "user";
            this.sshLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LebelPass
            // 
            this.LebelPass.AutoSize = true;
            this.LebelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelPass.ForeColor = System.Drawing.SystemColors.Control;
            this.LebelPass.Location = new System.Drawing.Point(6, 60);
            this.LebelPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelPass.Name = "LebelPass";
            this.LebelPass.Size = new System.Drawing.Size(53, 20);
            this.LebelPass.TabIndex = 1;
            this.LebelPass.Text = "Pass:";
            // 
            // LebelLogin
            // 
            this.LebelLogin.AutoSize = true;
            this.LebelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.LebelLogin.Location = new System.Drawing.Point(1, 24);
            this.LebelLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelLogin.Name = "LebelLogin";
            this.LebelLogin.Size = new System.Drawing.Size(58, 20);
            this.LebelLogin.TabIndex = 0;
            this.LebelLogin.Text = "Login:";
            // 
            // Violations
            // 
            this.Violations.Controls.Add(this.btnClearAll_V);
            this.Violations.Controls.Add(this.btnSelectAll_V);
            this.Violations.Controls.Add(this.violationsList);
            this.Violations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Violations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Violations.ForeColor = System.Drawing.SystemColors.Window;
            this.Violations.Location = new System.Drawing.Point(7, -1);
            this.Violations.Name = "Violations";
            this.Violations.Size = new System.Drawing.Size(310, 455);
            this.Violations.TabIndex = 10;
            this.Violations.TabStop = false;
            this.Violations.Text = "Violations";
            // 
            // btnClearAll_V
            // 
            this.btnClearAll_V.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClearAll_V.Location = new System.Drawing.Point(230, 411);
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
            this.btnSelectAll_V.Location = new System.Drawing.Point(6, 411);
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
            this.violationsList.Size = new System.Drawing.Size(298, 382);
            this.violationsList.Sorted = true;
            this.violationsList.TabIndex = 0;
            // 
            // Recognition_Selected_M
            // 
            this.Recognition_Selected_M.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recognition_Selected_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_Selected_M.ForeColor = System.Drawing.SystemColors.Control;
            this.Recognition_Selected_M.Location = new System.Drawing.Point(604, 207);
            this.Recognition_Selected_M.Name = "Recognition_Selected_M";
            this.Recognition_Selected_M.Size = new System.Drawing.Size(30, 65);
            this.Recognition_Selected_M.TabIndex = 14;
            this.Recognition_Selected_M.Text = ">";
            this.Recognition_Selected_M.UseVisualStyleBackColor = false;
            this.Recognition_Selected_M.Click += new System.EventHandler(this.Recognition_Selected_M_Click);
            // 
            // Recognition_Selected_P
            // 
            this.Recognition_Selected_P.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recognition_Selected_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_Selected_P.ForeColor = System.Drawing.SystemColors.Control;
            this.Recognition_Selected_P.Location = new System.Drawing.Point(323, 207);
            this.Recognition_Selected_P.Name = "Recognition_Selected_P";
            this.Recognition_Selected_P.Size = new System.Drawing.Size(30, 65);
            this.Recognition_Selected_P.TabIndex = 13;
            this.Recognition_Selected_P.Text = "<";
            this.Recognition_Selected_P.UseVisualStyleBackColor = false;
            this.Recognition_Selected_P.Click += new System.EventHandler(this.Recognition_Selected_P_Click);
            // 
            // Recognition_Selected
            // 
            this.Recognition_Selected.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Recognition_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recognition_Selected.Location = new System.Drawing.Point(358, 217);
            this.Recognition_Selected.Name = "Recognition_Selected";
            this.Recognition_Selected.ReadOnly = true;
            this.Recognition_Selected.Size = new System.Drawing.Size(240, 44);
            this.Recognition_Selected.TabIndex = 12;
            this.Recognition_Selected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnApply.Location = new System.Drawing.Point(554, 378);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 80);
            this.btnApply.TabIndex = 11;
            this.btnApply.UseMnemonic = false;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(323, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 35);
            this.progressBar1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(322, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(307, 44);
            this.textBox1.TabIndex = 16;
            // 
            // Filter_Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(641, 466);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Recognition_Selected_M);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.Recognition_Selected_P);
            this.Controls.Add(this.Violations);
            this.Controls.Add(this.auti);
            this.Controls.Add(this.Recognition_Selected);
            this.Controls.Add(this.RangeIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Filter_Factor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter_Factor";
            this.RangeIP.ResumeLayout(false);
            this.RangeIP.PerformLayout();
            this.auti.ResumeLayout(false);
            this.auti.PerformLayout();
            this.Violations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RangeIP;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox StopIP;
        private System.Windows.Forms.TextBox StartIP;
        private System.Windows.Forms.Label LebelStopIP;
        private System.Windows.Forms.Label LebelStartIP;
        private System.Windows.Forms.GroupBox auti;
        private System.Windows.Forms.TextBox sshPort;
        private System.Windows.Forms.Label labelSshPort;
        private System.Windows.Forms.TextBox webPort;
        private System.Windows.Forms.TextBox sshPass;
        private System.Windows.Forms.Label labelWebPort;
        private System.Windows.Forms.TextBox sshLogin;
        private System.Windows.Forms.Label LebelPass;
        private System.Windows.Forms.Label LebelLogin;
        private System.Windows.Forms.GroupBox Violations;
        private System.Windows.Forms.Button btnClearAll_V;
        private System.Windows.Forms.Button btnSelectAll_V;
        private System.Windows.Forms.CheckedListBox violationsList;
        private System.Windows.Forms.Button Recognition_Selected_M;
        private System.Windows.Forms.Button Recognition_Selected_P;
        private System.Windows.Forms.TextBox Recognition_Selected;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}