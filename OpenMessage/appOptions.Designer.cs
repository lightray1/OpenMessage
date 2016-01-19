namespace OpenMessage
{
    partial class appOptions
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
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.notificationSound = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.notificationSound);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(871, 435);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Options";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(759, 12);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 0;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "MP3 Files (.mp3)|*.mp3|WAV (*.wav)|*.wav";
            this.openFileDialog1.Title = "Choose a new Notification Sound:";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(12, 70);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(110, 15);
            this.monoFlat_Label1.TabIndex = 1;
            this.monoFlat_Label1.Text = "Notification Sound:";
            // 
            // notificationSound
            // 
            this.notificationSound.BackColor = System.Drawing.Color.Transparent;
            this.notificationSound.Font = new System.Drawing.Font("Tahoma", 11F);
            this.notificationSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.notificationSound.Image = null;
            this.notificationSound.Location = new System.Drawing.Point(15, 88);
            this.notificationSound.MaxLength = 32767;
            this.notificationSound.Multiline = false;
            this.notificationSound.Name = "notificationSound";
            this.notificationSound.ReadOnly = false;
            this.notificationSound.Size = new System.Drawing.Size(691, 41);
            this.notificationSound.TabIndex = 2;
            this.notificationSound.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.notificationSound.UseSystemPasswordChar = false;
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(712, 88);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(146, 41);
            this.monoFlat_Button1.TabIndex = 3;
            this.monoFlat_Button1.Text = "Change Sound";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.Location = new System.Drawing.Point(713, 382);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.Size = new System.Drawing.Size(146, 41);
            this.monoFlat_Button2.TabIndex = 4;
            this.monoFlat_Button2.Text = "Save";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // appOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 435);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appOptions";
            this.Text = "Options";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.appOptions_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_TextBox notificationSound;
        private MonoFlat.MonoFlat_Button monoFlat_Button2;
    }
}