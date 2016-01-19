namespace OpenMessage
{
    partial class roster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roster));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developedByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitchellUrgeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRGEROORGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSourceLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherProjectsUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s22XmppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freePikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.friendView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.usernameLabel = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testUPnPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "OpenMessage";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.openWindowToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 76);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developedByToolStripMenuItem,
            this.openSourceLicenseToolStripMenuItem,
            this.otherProjectsUsedToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About:";
            // 
            // developedByToolStripMenuItem
            // 
            this.developedByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitchellUrgeroToolStripMenuItem,
            this.uRGEROORGToolStripMenuItem});
            this.developedByToolStripMenuItem.Name = "developedByToolStripMenuItem";
            this.developedByToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.developedByToolStripMenuItem.Text = "Developed by";
            // 
            // mitchellUrgeroToolStripMenuItem
            // 
            this.mitchellUrgeroToolStripMenuItem.Name = "mitchellUrgeroToolStripMenuItem";
            this.mitchellUrgeroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mitchellUrgeroToolStripMenuItem.Text = "Mitchell Urgero";
            // 
            // uRGEROORGToolStripMenuItem
            // 
            this.uRGEROORGToolStripMenuItem.Name = "uRGEROORGToolStripMenuItem";
            this.uRGEROORGToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.uRGEROORGToolStripMenuItem.Text = "URGERO.ORG";
            // 
            // openSourceLicenseToolStripMenuItem
            // 
            this.openSourceLicenseToolStripMenuItem.Name = "openSourceLicenseToolStripMenuItem";
            this.openSourceLicenseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openSourceLicenseToolStripMenuItem.Text = "Open Source License";
            // 
            // otherProjectsUsedToolStripMenuItem
            // 
            this.otherProjectsUsedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s22XmppToolStripMenuItem,
            this.freePikToolStripMenuItem});
            this.otherProjectsUsedToolStripMenuItem.Name = "otherProjectsUsedToolStripMenuItem";
            this.otherProjectsUsedToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.otherProjectsUsedToolStripMenuItem.Text = "Other Projects Used:";
            // 
            // s22XmppToolStripMenuItem
            // 
            this.s22XmppToolStripMenuItem.Name = "s22XmppToolStripMenuItem";
            this.s22XmppToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.s22XmppToolStripMenuItem.Text = "S22.Xmpp";
            // 
            // freePikToolStripMenuItem
            // 
            this.freePikToolStripMenuItem.Name = "freePikToolStripMenuItem";
            this.freePikToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.freePikToolStripMenuItem.Text = "FreePik";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            this.openWindowToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openWindowToolStripMenuItem.Text = "Open Window";
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.friendView);
            this.monoFlat_ThemeContainer1.Controls.Add(this.label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.usernameLabel);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.menuStrip1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(317, 532);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "OpenMessage IM";
            // 
            // friendView
            // 
            this.friendView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.friendView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.friendView.ForeColor = System.Drawing.SystemColors.Window;
            this.friendView.Location = new System.Drawing.Point(10, 98);
            this.friendView.MultiSelect = false;
            this.friendView.Name = "friendView";
            this.friendView.Size = new System.Drawing.Size(297, 398);
            this.friendView.TabIndex = 7;
            this.friendView.UseCompatibleStateImageBehavior = false;
            this.friendView.View = System.Windows.Forms.View.SmallIcon;
            this.friendView.SelectedIndexChanged += new System.EventHandler(this.friendView_SelectedIndexChanged);
            this.friendView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.friendView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(231, 66);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(74, 24);
            this.monoFlat_Button1.TabIndex = 4;
            this.monoFlat_Button1.Text = "Sign Out";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.usernameLabel.Location = new System.Drawing.Point(94, 70);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(69, 15);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "-username-";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(12, 70);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(76, 15);
            this.monoFlat_Label1.TabIndex = 1;
            this.monoFlat_Label1.Text = "Signed in as: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 499);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFriendToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // addFriendToolStripMenuItem
            // 
            this.addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            this.addFriendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFriendToolStripMenuItem.Text = "Add Friend";
            this.addFriendToolStripMenuItem.Click += new System.EventHandler(this.addFriendToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testUPnPToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // testUPnPToolStripMenuItem
            // 
            this.testUPnPToolStripMenuItem.Name = "testUPnPToolStripMenuItem";
            this.testUPnPToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.testUPnPToolStripMenuItem.Text = "Test UPnP";
            this.testUPnPToolStripMenuItem.Click += new System.EventHandler(this.testUPnPToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // roster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 532);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "roster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenMessage IM";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.roster_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Label usernameLabel;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private System.Windows.Forms.Timer timer1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developedByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitchellUrgeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRGEROORGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherProjectsUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s22XmppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freePikToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem;
        private System.Windows.Forms.ListView friendView;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testUPnPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
    }
}