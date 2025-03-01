namespace NGPlayerNET
{
    partial class PlayerAboutBox
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
            this.programInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.playerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerVersionLabel = new System.Windows.Forms.Label();
            this.playerSourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.playerSourcePrefixLabel = new System.Windows.Forms.Label();
            this.osInfoLabel = new System.Windows.Forms.Label();
            this.flashInfoLabel = new System.Windows.Forms.Label();
            this.playingStatusLabel = new System.Windows.Forms.Label();
            this.playingURLLabel = new System.Windows.Forms.TextBox();
            this.updateCheckLinkLabel = new System.Windows.Forms.LinkLabel();
            this.programInfoGroupBox.SuspendLayout();
            this.playerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // programInfoGroupBox
            // 
            this.programInfoGroupBox.Controls.Add(this.updateCheckLinkLabel);
            this.programInfoGroupBox.Controls.Add(this.playerSourcePrefixLabel);
            this.programInfoGroupBox.Controls.Add(this.playerSourceLinkLabel);
            this.programInfoGroupBox.Controls.Add(this.playerVersionLabel);
            this.programInfoGroupBox.Controls.Add(this.playerNameLabel);
            this.programInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.programInfoGroupBox.Name = "programInfoGroupBox";
            this.programInfoGroupBox.Size = new System.Drawing.Size(363, 100);
            this.programInfoGroupBox.TabIndex = 0;
            this.programInfoGroupBox.TabStop = false;
            this.programInfoGroupBox.Text = "Program Information";
            // 
            // playerInfoGroupBox
            // 
            this.playerInfoGroupBox.Controls.Add(this.playingURLLabel);
            this.playerInfoGroupBox.Controls.Add(this.playingStatusLabel);
            this.playerInfoGroupBox.Controls.Add(this.flashInfoLabel);
            this.playerInfoGroupBox.Controls.Add(this.osInfoLabel);
            this.playerInfoGroupBox.Location = new System.Drawing.Point(12, 118);
            this.playerInfoGroupBox.Name = "playerInfoGroupBox";
            this.playerInfoGroupBox.Size = new System.Drawing.Size(363, 107);
            this.playerInfoGroupBox.TabIndex = 1;
            this.playerInfoGroupBox.TabStop = false;
            this.playerInfoGroupBox.Text = "Player Information";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(13, 22);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(222, 26);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "NGPlayerNET by Emma / InvoxiPlayGames\r\nnot affiliated with or endorsed by Newgrou" +
    "nds";
            // 
            // playerVersionLabel
            // 
            this.playerVersionLabel.AutoSize = true;
            this.playerVersionLabel.Location = new System.Drawing.Point(13, 53);
            this.playerVersionLabel.Name = "playerVersionLabel";
            this.playerVersionLabel.Size = new System.Drawing.Size(97, 13);
            this.playerVersionLabel.TabIndex = 1;
            this.playerVersionLabel.Text = "version W.W.W.W";
            // 
            // playerSourceLinkLabel
            // 
            this.playerSourceLinkLabel.AutoSize = true;
            this.playerSourceLinkLabel.Location = new System.Drawing.Point(92, 75);
            this.playerSourceLinkLabel.Name = "playerSourceLinkLabel";
            this.playerSourceLinkLabel.Size = new System.Drawing.Size(253, 13);
            this.playerSourceLinkLabel.TabIndex = 2;
            this.playerSourceLinkLabel.TabStop = true;
            this.playerSourceLinkLabel.Text = "https://github.com/InvoxiPlayGames/NGPlayerNET";
            this.playerSourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playerSourceLinkLabel_LinkClicked);
            // 
            // playerSourcePrefixLabel
            // 
            this.playerSourcePrefixLabel.AutoSize = true;
            this.playerSourcePrefixLabel.Location = new System.Drawing.Point(13, 75);
            this.playerSourcePrefixLabel.Name = "playerSourcePrefixLabel";
            this.playerSourcePrefixLabel.Size = new System.Drawing.Size(80, 13);
            this.playerSourcePrefixLabel.TabIndex = 3;
            this.playerSourcePrefixLabel.Text = "Open source at";
            // 
            // osInfoLabel
            // 
            this.osInfoLabel.AutoSize = true;
            this.osInfoLabel.Location = new System.Drawing.Point(13, 21);
            this.osInfoLabel.Name = "osInfoLabel";
            this.osInfoLabel.Size = new System.Drawing.Size(331, 13);
            this.osInfoLabel.TabIndex = 0;
            this.osInfoLabel.Text = "Running on Xbox 360 (2.0.17559.0), .NET Framework 2.0.1738 CLR";
            // 
            // flashInfoLabel
            // 
            this.flashInfoLabel.AutoSize = true;
            this.flashInfoLabel.Location = new System.Drawing.Point(13, 40);
            this.flashInfoLabel.Name = "flashInfoLabel";
            this.flashInfoLabel.Size = new System.Drawing.Size(230, 13);
            this.flashInfoLabel.TabIndex = 1;
            this.flashInfoLabel.Text = "Macradobe Flash Player version 69.420.0.1337";
            // 
            // playingStatusLabel
            // 
            this.playingStatusLabel.AutoSize = true;
            this.playingStatusLabel.Location = new System.Drawing.Point(13, 59);
            this.playingStatusLabel.Name = "playingStatusLabel";
            this.playingStatusLabel.Size = new System.Drawing.Size(383, 13);
            this.playingStatusLabel.TabIndex = 2;
            this.playingStatusLabel.Text = "Playing NG movie 55555: \"PLACEHOLDER PLACEHOLDER PLACEHOLDER\"";
            // 
            // playingURLLabel
            // 
            this.playingURLLabel.Location = new System.Drawing.Point(16, 75);
            this.playingURLLabel.Name = "playingURLLabel";
            this.playingURLLabel.ReadOnly = true;
            this.playingURLLabel.Size = new System.Drawing.Size(329, 20);
            this.playingURLLabel.TabIndex = 3;
            this.playingURLLabel.Text = "http://placeholderinsdustries.example.com/PLACEHOLDER.SWF";
            // 
            // updateCheckLinkLabel
            // 
            this.updateCheckLinkLabel.AutoSize = true;
            this.updateCheckLinkLabel.Location = new System.Drawing.Point(116, 53);
            this.updateCheckLinkLabel.Name = "updateCheckLinkLabel";
            this.updateCheckLinkLabel.Size = new System.Drawing.Size(99, 13);
            this.updateCheckLinkLabel.TabIndex = 4;
            this.updateCheckLinkLabel.TabStop = true;
            this.updateCheckLinkLabel.Text = "check for updates?";
            this.updateCheckLinkLabel.Visible = false;
            // 
            // PlayerAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 237);
            this.Controls.Add(this.playerInfoGroupBox);
            this.Controls.Add(this.programInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PlayerAboutBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About NGPlayerNET";
            this.programInfoGroupBox.ResumeLayout(false);
            this.programInfoGroupBox.PerformLayout();
            this.playerInfoGroupBox.ResumeLayout(false);
            this.playerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox programInfoGroupBox;
        private System.Windows.Forms.Label playerSourcePrefixLabel;
        private System.Windows.Forms.LinkLabel playerSourceLinkLabel;
        private System.Windows.Forms.Label playerVersionLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.GroupBox playerInfoGroupBox;
        private System.Windows.Forms.TextBox playingURLLabel;
        private System.Windows.Forms.Label playingStatusLabel;
        private System.Windows.Forms.Label flashInfoLabel;
        private System.Windows.Forms.Label osInfoLabel;
        private System.Windows.Forms.LinkLabel updateCheckLinkLabel;
    }
}