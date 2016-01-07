namespace OpenMessage
{
    partial class newMsgb
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
            this.messageFrm = new MonoFlat.MonoFlat_ThemeContainer();
            this.message = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.messageFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageFrm
            // 
            this.messageFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.messageFrm.Controls.Add(this.message);
            this.messageFrm.Controls.Add(this.monoFlat_Button1);
            this.messageFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageFrm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.messageFrm.Location = new System.Drawing.Point(0, 0);
            this.messageFrm.Name = "messageFrm";
            this.messageFrm.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.messageFrm.RoundCorners = true;
            this.messageFrm.Sizable = true;
            this.messageFrm.Size = new System.Drawing.Size(468, 364);
            this.messageFrm.SmartBounds = true;
            this.messageFrm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.messageFrm.TabIndex = 0;
            this.messageFrm.Text = "Error";
            this.messageFrm.Click += new System.EventHandler(this.messageFrm_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Tahoma", 11F);
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.message.Image = null;
            this.message.Location = new System.Drawing.Point(13, 73);
            this.message.MaxLength = 32767;
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(442, 232);
            this.message.TabIndex = 1;
            this.message.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.message.UseSystemPasswordChar = false;
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(369, 311);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(87, 41);
            this.monoFlat_Button1.TabIndex = 0;
            this.monoFlat_Button1.Text = "OK";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // newMsgb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 364);
            this.Controls.Add(this.messageFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newMsgb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.messageFrm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer messageFrm;
        private MonoFlat.MonoFlat_TextBox message;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
    }
}