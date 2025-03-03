namespace NGPlayerNET
{
    partial class PlayerMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNewgroundsFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSWFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.unloadSWFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.currentFlashNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentFlashAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnNewgroundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nGPlayerNETSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNGPlayerNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashContainerPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNewgroundsFlashToolStripMenuItem,
            this.loadSWFToolStripMenuItem,
            this.toolStripSeparator2,
            this.unloadSWFToolStripMenuItem,
            this.toolStripSeparator3,
            this.currentFlashNameToolStripMenuItem,
            this.currentFlashAuthorToolStripMenuItem,
            this.viewOnNewgroundsToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // loadNewgroundsFlashToolStripMenuItem
            // 
            this.loadNewgroundsFlashToolStripMenuItem.Name = "loadNewgroundsFlashToolStripMenuItem";
            this.loadNewgroundsFlashToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.loadNewgroundsFlashToolStripMenuItem.Text = "Load Newgrounds Flash...";
            this.loadNewgroundsFlashToolStripMenuItem.Click += new System.EventHandler(this.loadNewgroundsFlashToolStripMenuItem_Click);
            // 
            // loadSWFToolStripMenuItem
            // 
            this.loadSWFToolStripMenuItem.Name = "loadSWFToolStripMenuItem";
            this.loadSWFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.loadSWFToolStripMenuItem.Text = "Load local SWF...";
            this.loadSWFToolStripMenuItem.Click += new System.EventHandler(this.loadSWFToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // unloadSWFToolStripMenuItem
            // 
            this.unloadSWFToolStripMenuItem.Name = "unloadSWFToolStripMenuItem";
            this.unloadSWFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.unloadSWFToolStripMenuItem.Text = "Unload SWF";
            this.unloadSWFToolStripMenuItem.Click += new System.EventHandler(this.unloadSWFToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // currentFlashNameToolStripMenuItem
            // 
            this.currentFlashNameToolStripMenuItem.Enabled = false;
            this.currentFlashNameToolStripMenuItem.Name = "currentFlashNameToolStripMenuItem";
            this.currentFlashNameToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.currentFlashNameToolStripMenuItem.Text = "Current Flash Name";
            // 
            // currentFlashAuthorToolStripMenuItem
            // 
            this.currentFlashAuthorToolStripMenuItem.Enabled = false;
            this.currentFlashAuthorToolStripMenuItem.Name = "currentFlashAuthorToolStripMenuItem";
            this.currentFlashAuthorToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.currentFlashAuthorToolStripMenuItem.Text = "Current Flash Author";
            this.currentFlashAuthorToolStripMenuItem.Visible = false;
            // 
            // viewOnNewgroundsToolStripMenuItem
            // 
            this.viewOnNewgroundsToolStripMenuItem.Name = "viewOnNewgroundsToolStripMenuItem";
            this.viewOnNewgroundsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.viewOnNewgroundsToolStripMenuItem.Text = "View on Newgrounds";
            this.viewOnNewgroundsToolStripMenuItem.Visible = false;
            this.viewOnNewgroundsToolStripMenuItem.Click += new System.EventHandler(this.viewOnNewgroundsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashQualityToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // flashQualityToolStripMenuItem
            // 
            this.flashQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highQualityToolStripMenuItem,
            this.mediumQualityToolStripMenuItem,
            this.lowQualityToolStripMenuItem,
            this.otherQualityToolStripMenuItem});
            this.flashQualityToolStripMenuItem.Name = "flashQualityToolStripMenuItem";
            this.flashQualityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.flashQualityToolStripMenuItem.Text = "Flash Quality";
            this.flashQualityToolStripMenuItem.DropDownOpening += new System.EventHandler(this.flashQualityToolStripMenuItem_DropDownOpening);
            // 
            // highQualityToolStripMenuItem
            // 
            this.highQualityToolStripMenuItem.Name = "highQualityToolStripMenuItem";
            this.highQualityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.highQualityToolStripMenuItem.Text = "High";
            this.highQualityToolStripMenuItem.Click += new System.EventHandler(this.highQualityToolStripMenuItem_Click);
            // 
            // mediumQualityToolStripMenuItem
            // 
            this.mediumQualityToolStripMenuItem.Name = "mediumQualityToolStripMenuItem";
            this.mediumQualityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mediumQualityToolStripMenuItem.Text = "Medium";
            this.mediumQualityToolStripMenuItem.Click += new System.EventHandler(this.mediumQualityToolStripMenuItem_Click);
            // 
            // lowQualityToolStripMenuItem
            // 
            this.lowQualityToolStripMenuItem.Name = "lowQualityToolStripMenuItem";
            this.lowQualityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lowQualityToolStripMenuItem.Text = "Low";
            this.lowQualityToolStripMenuItem.Click += new System.EventHandler(this.lowQualityToolStripMenuItem_Click);
            // 
            // otherQualityToolStripMenuItem
            // 
            this.otherQualityToolStripMenuItem.Enabled = false;
            this.otherQualityToolStripMenuItem.Name = "otherQualityToolStripMenuItem";
            this.otherQualityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherQualityToolStripMenuItem.Text = "Other Quality";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nGPlayerNETSettingsToolStripMenuItem,
            this.aboutNGPlayerNETToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // nGPlayerNETSettingsToolStripMenuItem
            // 
            this.nGPlayerNETSettingsToolStripMenuItem.Name = "nGPlayerNETSettingsToolStripMenuItem";
            this.nGPlayerNETSettingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.nGPlayerNETSettingsToolStripMenuItem.Text = "NGPlayerNET Settings";
            this.nGPlayerNETSettingsToolStripMenuItem.Click += new System.EventHandler(this.nGPlayerNETSettingsToolStripMenuItem_Click);
            // 
            // aboutNGPlayerNETToolStripMenuItem
            // 
            this.aboutNGPlayerNETToolStripMenuItem.Name = "aboutNGPlayerNETToolStripMenuItem";
            this.aboutNGPlayerNETToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutNGPlayerNETToolStripMenuItem.Text = "About NGPlayerNET...";
            this.aboutNGPlayerNETToolStripMenuItem.Click += new System.EventHandler(this.aboutNGPlayerNETToolStripMenuItem_Click);
            // 
            // flashContainerPanel
            // 
            this.flashContainerPanel.BackColor = System.Drawing.Color.Black;
            this.flashContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flashContainerPanel.Location = new System.Drawing.Point(0, 24);
            this.flashContainerPanel.Name = "flashContainerPanel";
            this.flashContainerPanel.Size = new System.Drawing.Size(489, 286);
            this.flashContainerPanel.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Flash files|*.swf";
            this.openFileDialog1.Title = "Load local SWF";
            // 
            // PlayerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 310);
            this.Controls.Add(this.flashContainerPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayerMain";
            this.Text = "NGPlayerNET";
            this.Load += new System.EventHandler(this.PlayerMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNewgroundsFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSWFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutNGPlayerNETToolStripMenuItem;
        private System.Windows.Forms.Panel flashContainerPanel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nGPlayerNETSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem unloadSWFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem currentFlashNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentFlashAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOnNewgroundsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

