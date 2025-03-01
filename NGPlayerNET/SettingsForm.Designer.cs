namespace NGPlayerNET
{
    partial class SettingsForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.visualSettingsGroup = new System.Windows.Forms.GroupBox();
            this.xTheEverythingLabel = new System.Windows.Forms.Label();
            this.resHeightTextBox = new System.Windows.Forms.TextBox();
            this.resWidthTextBox = new System.Windows.Forms.TextBox();
            this.defaultResLabel = new System.Windows.Forms.Label();
            this.defaultQualityLabel = new System.Windows.Forms.Label();
            this.defaultQualityBox = new System.Windows.Forms.ComboBox();
            this.connectionSettingsGroup = new System.Windows.Forms.GroupBox();
            this.connectionInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.alwaysHttpsRadio = new System.Windows.Forms.RadioButton();
            this.alwaysFallbackRadio = new System.Windows.Forms.RadioButton();
            this.ngHttpsWithFallbackRadio = new System.Windows.Forms.RadioButton();
            this.installHandlerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.visualSettingsGroup.SuspendLayout();
            this.connectionSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(371, 121);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(290, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // visualSettingsGroup
            // 
            this.visualSettingsGroup.Controls.Add(this.xTheEverythingLabel);
            this.visualSettingsGroup.Controls.Add(this.resHeightTextBox);
            this.visualSettingsGroup.Controls.Add(this.resWidthTextBox);
            this.visualSettingsGroup.Controls.Add(this.defaultResLabel);
            this.visualSettingsGroup.Controls.Add(this.defaultQualityLabel);
            this.visualSettingsGroup.Controls.Add(this.defaultQualityBox);
            this.visualSettingsGroup.Location = new System.Drawing.Point(223, 12);
            this.visualSettingsGroup.Name = "visualSettingsGroup";
            this.visualSettingsGroup.Size = new System.Drawing.Size(223, 82);
            this.visualSettingsGroup.TabIndex = 3;
            this.visualSettingsGroup.TabStop = false;
            this.visualSettingsGroup.Text = "Visual Settings";
            // 
            // xTheEverythingLabel
            // 
            this.xTheEverythingLabel.AutoSize = true;
            this.xTheEverythingLabel.Location = new System.Drawing.Point(155, 51);
            this.xTheEverythingLabel.Name = "xTheEverythingLabel";
            this.xTheEverythingLabel.Size = new System.Drawing.Size(14, 13);
            this.xTheEverythingLabel.TabIndex = 4;
            this.xTheEverythingLabel.Text = "X";
            // 
            // resHeightTextBox
            // 
            this.resHeightTextBox.Location = new System.Drawing.Point(174, 48);
            this.resHeightTextBox.Name = "resHeightTextBox";
            this.resHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.resHeightTextBox.TabIndex = 4;
            this.resHeightTextBox.Text = "720";
            this.resHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resHeightTextBox_KeyPress);
            // 
            // resWidthTextBox
            // 
            this.resWidthTextBox.Location = new System.Drawing.Point(108, 48);
            this.resWidthTextBox.Name = "resWidthTextBox";
            this.resWidthTextBox.Size = new System.Drawing.Size(43, 20);
            this.resWidthTextBox.TabIndex = 3;
            this.resWidthTextBox.Text = "1280";
            this.resWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resWidthTextBox_KeyPress);
            // 
            // defaultResLabel
            // 
            this.defaultResLabel.AutoSize = true;
            this.defaultResLabel.Location = new System.Drawing.Point(6, 51);
            this.defaultResLabel.Name = "defaultResLabel";
            this.defaultResLabel.Size = new System.Drawing.Size(95, 13);
            this.defaultResLabel.TabIndex = 2;
            this.defaultResLabel.Text = "Default Local Res:";
            // 
            // defaultQualityLabel
            // 
            this.defaultQualityLabel.AutoSize = true;
            this.defaultQualityLabel.Location = new System.Drawing.Point(6, 22);
            this.defaultQualityLabel.Name = "defaultQualityLabel";
            this.defaultQualityLabel.Size = new System.Drawing.Size(79, 13);
            this.defaultQualityLabel.TabIndex = 1;
            this.defaultQualityLabel.Text = "Default Quality:";
            // 
            // defaultQualityBox
            // 
            this.defaultQualityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultQualityBox.FormattingEnabled = true;
            this.defaultQualityBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.defaultQualityBox.Location = new System.Drawing.Point(91, 19);
            this.defaultQualityBox.Name = "defaultQualityBox";
            this.defaultQualityBox.Size = new System.Drawing.Size(126, 21);
            this.defaultQualityBox.TabIndex = 0;
            // 
            // connectionSettingsGroup
            // 
            this.connectionSettingsGroup.Controls.Add(this.connectionInfoLinkLabel);
            this.connectionSettingsGroup.Controls.Add(this.alwaysHttpsRadio);
            this.connectionSettingsGroup.Controls.Add(this.alwaysFallbackRadio);
            this.connectionSettingsGroup.Controls.Add(this.ngHttpsWithFallbackRadio);
            this.connectionSettingsGroup.Location = new System.Drawing.Point(12, 12);
            this.connectionSettingsGroup.Name = "connectionSettingsGroup";
            this.connectionSettingsGroup.Size = new System.Drawing.Size(204, 132);
            this.connectionSettingsGroup.TabIndex = 4;
            this.connectionSettingsGroup.TabStop = false;
            this.connectionSettingsGroup.Text = "Connection Settings";
            // 
            // connectionInfoLinkLabel
            // 
            this.connectionInfoLinkLabel.AutoSize = true;
            this.connectionInfoLinkLabel.Location = new System.Drawing.Point(6, 113);
            this.connectionInfoLinkLabel.Name = "connectionInfoLinkLabel";
            this.connectionInfoLinkLabel.Size = new System.Drawing.Size(113, 13);
            this.connectionInfoLinkLabel.TabIndex = 3;
            this.connectionInfoLinkLabel.TabStop = true;
            this.connectionInfoLinkLabel.Text = "What does this mean?";
            this.connectionInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.connectionInfoLinkLabel_LinkClicked);
            // 
            // alwaysHttpsRadio
            // 
            this.alwaysHttpsRadio.AutoSize = true;
            this.alwaysHttpsRadio.Location = new System.Drawing.Point(6, 78);
            this.alwaysHttpsRadio.Name = "alwaysHttpsRadio";
            this.alwaysHttpsRadio.Size = new System.Drawing.Size(164, 30);
            this.alwaysHttpsRadio.TabIndex = 2;
            this.alwaysHttpsRadio.Text = "Always use Newgrounds.com\r\nover HTTPS";
            this.alwaysHttpsRadio.UseVisualStyleBackColor = true;
            // 
            // alwaysFallbackRadio
            // 
            this.alwaysFallbackRadio.AutoSize = true;
            this.alwaysFallbackRadio.Location = new System.Drawing.Point(6, 55);
            this.alwaysFallbackRadio.Name = "alwaysFallbackRadio";
            this.alwaysFallbackRadio.Size = new System.Drawing.Size(159, 17);
            this.alwaysFallbackRadio.TabIndex = 1;
            this.alwaysFallbackRadio.Text = "Always use HTTP third-party";
            this.alwaysFallbackRadio.UseVisualStyleBackColor = true;
            // 
            // ngHttpsWithFallbackRadio
            // 
            this.ngHttpsWithFallbackRadio.AutoSize = true;
            this.ngHttpsWithFallbackRadio.Checked = true;
            this.ngHttpsWithFallbackRadio.Location = new System.Drawing.Point(6, 19);
            this.ngHttpsWithFallbackRadio.Name = "ngHttpsWithFallbackRadio";
            this.ngHttpsWithFallbackRadio.Size = new System.Drawing.Size(192, 30);
            this.ngHttpsWithFallbackRadio.TabIndex = 0;
            this.ngHttpsWithFallbackRadio.TabStop = true;
            this.ngHttpsWithFallbackRadio.Text = "Try Newgrounds.com over HTTPS,\r\nwith a fallback to HTTP third-party";
            this.ngHttpsWithFallbackRadio.UseVisualStyleBackColor = true;
            // 
            // installHandlerLinkLabel
            // 
            this.installHandlerLinkLabel.AutoSize = true;
            this.installHandlerLinkLabel.Location = new System.Drawing.Point(229, 100);
            this.installHandlerLinkLabel.Name = "installHandlerLinkLabel";
            this.installHandlerLinkLabel.Size = new System.Drawing.Size(198, 13);
            this.installHandlerLinkLabel.TabIndex = 5;
            this.installHandlerLinkLabel.TabStop = true;
            this.installHandlerLinkLabel.Text = "Install newgroundsplayer: URL handler...";
            this.installHandlerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.installHandlerLinkLabel_LinkClicked);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(458, 156);
            this.Controls.Add(this.installHandlerLinkLabel);
            this.Controls.Add(this.connectionSettingsGroup);
            this.Controls.Add(this.visualSettingsGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NGPlayerNET Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.visualSettingsGroup.ResumeLayout(false);
            this.visualSettingsGroup.PerformLayout();
            this.connectionSettingsGroup.ResumeLayout(false);
            this.connectionSettingsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox visualSettingsGroup;
        private System.Windows.Forms.Label xTheEverythingLabel;
        private System.Windows.Forms.TextBox resHeightTextBox;
        private System.Windows.Forms.TextBox resWidthTextBox;
        private System.Windows.Forms.Label defaultResLabel;
        private System.Windows.Forms.Label defaultQualityLabel;
        private System.Windows.Forms.ComboBox defaultQualityBox;
        private System.Windows.Forms.GroupBox connectionSettingsGroup;
        private System.Windows.Forms.LinkLabel connectionInfoLinkLabel;
        private System.Windows.Forms.RadioButton alwaysHttpsRadio;
        private System.Windows.Forms.RadioButton alwaysFallbackRadio;
        private System.Windows.Forms.RadioButton ngHttpsWithFallbackRadio;
        private System.Windows.Forms.LinkLabel installHandlerLinkLabel;
    }
}