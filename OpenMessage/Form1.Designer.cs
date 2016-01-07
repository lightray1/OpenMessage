namespace OpenMessage
{
    partial class Form1
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
            this.loginFrm = new MonoFlat.MonoFlat_ThemeContainer();
            this.serverFQDN = new MonoFlat.MonoFlat_TextBox();
            this.useTLSCheck = new MonoFlat.MonoFlat_CheckBox();
            this.verLabel = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.remember = new MonoFlat.MonoFlat_CheckBox();
            this.cancelBtn = new MonoFlat.MonoFlat_Button();
            this.loginBtn = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameTxt = new MonoFlat.MonoFlat_TextBox();
            this.passwordTxt = new MonoFlat.MonoFlat_TextBox();
            this.loginFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginFrm
            // 
            this.loginFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.loginFrm.Controls.Add(this.serverFQDN);
            this.loginFrm.Controls.Add(this.useTLSCheck);
            this.loginFrm.Controls.Add(this.verLabel);
            this.loginFrm.Controls.Add(this.monoFlat_Label3);
            this.loginFrm.Controls.Add(this.remember);
            this.loginFrm.Controls.Add(this.cancelBtn);
            this.loginFrm.Controls.Add(this.loginBtn);
            this.loginFrm.Controls.Add(this.monoFlat_Label2);
            this.loginFrm.Controls.Add(this.monoFlat_Label1);
            this.loginFrm.Controls.Add(this.pictureBox2);
            this.loginFrm.Controls.Add(this.pictureBox1);
            this.loginFrm.Controls.Add(this.usernameTxt);
            this.loginFrm.Controls.Add(this.passwordTxt);
            this.loginFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFrm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginFrm.Location = new System.Drawing.Point(0, 0);
            this.loginFrm.Name = "loginFrm";
            this.loginFrm.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.loginFrm.RoundCorners = true;
            this.loginFrm.Sizable = true;
            this.loginFrm.Size = new System.Drawing.Size(363, 350);
            this.loginFrm.SmartBounds = true;
            this.loginFrm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.loginFrm.TabIndex = 0;
            this.loginFrm.Text = "Sign-In";
            // 
            // serverFQDN
            // 
            this.serverFQDN.BackColor = System.Drawing.Color.Transparent;
            this.serverFQDN.Font = new System.Drawing.Font("Tahoma", 11F);
            this.serverFQDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.serverFQDN.Image = null;
            this.serverFQDN.Location = new System.Drawing.Point(69, 206);
            this.serverFQDN.MaxLength = 32767;
            this.serverFQDN.Multiline = false;
            this.serverFQDN.Name = "serverFQDN";
            this.serverFQDN.ReadOnly = false;
            this.serverFQDN.Size = new System.Drawing.Size(282, 41);
            this.serverFQDN.TabIndex = 2;
            this.serverFQDN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.serverFQDN.UseSystemPasswordChar = false;
            // 
            // useTLSCheck
            // 
            this.useTLSCheck.Checked = false;
            this.useTLSCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.useTLSCheck.Location = new System.Drawing.Point(97, 292);
            this.useTLSCheck.Name = "useTLSCheck";
            this.useTLSCheck.Size = new System.Drawing.Size(148, 16);
            this.useTLSCheck.TabIndex = 11;
            this.useTLSCheck.Text = "Use TLS";
            this.useTLSCheck.CheckedChanged += new MonoFlat.MonoFlat_CheckBox.CheckedChangedEventHandler(this.useTLSCheck_CheckedChanged);
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.BackColor = System.Drawing.Color.Transparent;
            this.verLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.verLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.verLabel.Location = new System.Drawing.Point(293, 332);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(36, 12);
            this.verLabel.TabIndex = 10;
            this.verLabel.Text = "version";
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(13, 330);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(176, 12);
            this.monoFlat_Label3.TabIndex = 9;
            this.monoFlat_Label3.Text = "Built and Maintained by OpenMessage";
            // 
            // remember
            // 
            this.remember.Checked = false;
            this.remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.remember.Location = new System.Drawing.Point(97, 270);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(148, 16);
            this.remember.TabIndex = 8;
            this.remember.Text = "Remember Username";
            this.remember.CheckedChanged += new MonoFlat.MonoFlat_CheckBox.CheckedChangedEventHandler(this.remember_CheckedChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(295, 304);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(56, 25);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginBtn.Image = null;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(251, 257);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 41);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Sign-In";
            this.loginBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(122, 91);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(118, 15);
            this.monoFlat_Label2.TabIndex = 5;
            this.monoFlat_Label2.Text = "Please sign-in below:";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(105, 70);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(152, 15);
            this.monoFlat_Label1.TabIndex = 4;
            this.monoFlat_Label1.Text = "Welcome to OpenMessage!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OpenMessage.Properties.Resources.Lock;
            this.pictureBox2.Location = new System.Drawing.Point(13, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenMessage.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(13, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.Transparent;
            this.usernameTxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.usernameTxt.Image = null;
            this.usernameTxt.Location = new System.Drawing.Point(69, 112);
            this.usernameTxt.MaxLength = 32767;
            this.usernameTxt.Multiline = false;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.ReadOnly = false;
            this.usernameTxt.Size = new System.Drawing.Size(282, 41);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTxt.UseSystemPasswordChar = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.passwordTxt.Image = null;
            this.passwordTxt.Location = new System.Drawing.Point(69, 159);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.ReadOnly = false;
            this.passwordTxt.Size = new System.Drawing.Size(281, 41);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 350);
            this.Controls.Add(this.loginFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign-In";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.loginFrm.ResumeLayout(false);
            this.loginFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer loginFrm;
        private MonoFlat.MonoFlat_TextBox usernameTxt;
        private MonoFlat.MonoFlat_TextBox passwordTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MonoFlat.MonoFlat_Button loginBtn;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Button cancelBtn;
        private MonoFlat.MonoFlat_CheckBox remember;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_Label verLabel;
        private MonoFlat.MonoFlat_CheckBox useTLSCheck;
        private MonoFlat.MonoFlat_TextBox serverFQDN;
    }
}

