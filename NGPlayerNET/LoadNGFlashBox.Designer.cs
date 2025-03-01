namespace NGPlayerNET
{
    partial class LoadNGFlashBox
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.portalURLTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.fetchInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(218, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Enter or paste a Newgrounds portal URL/ID:";
            // 
            // portalURLTextBox
            // 
            this.portalURLTextBox.Location = new System.Drawing.Point(15, 25);
            this.portalURLTextBox.Name = "portalURLTextBox";
            this.portalURLTextBox.Size = new System.Drawing.Size(459, 20);
            this.portalURLTextBox.TabIndex = 1;
            this.portalURLTextBox.TextChanged += new System.EventHandler(this.portalURLTextBox_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(399, 51);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // fetchInfoLinkLabel
            // 
            this.fetchInfoLinkLabel.AutoSize = true;
            this.fetchInfoLinkLabel.Enabled = false;
            this.fetchInfoLinkLabel.Location = new System.Drawing.Point(299, 56);
            this.fetchInfoLinkLabel.Name = "fetchInfoLinkLabel";
            this.fetchInfoLinkLabel.Size = new System.Drawing.Size(94, 13);
            this.fetchInfoLinkLabel.TabIndex = 3;
            this.fetchInfoLinkLabel.TabStop = true;
            this.fetchInfoLinkLabel.Text = "View Information...";
            this.fetchInfoLinkLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(15, 51);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoadNGFlashBox
            // 
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(486, 83);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fetchInfoLinkLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.portalURLTextBox);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadNGFlashBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Newgrounds Flash";
            this.Load += new System.EventHandler(this.LoadNGFlashBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox portalURLTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.LinkLabel fetchInfoLinkLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}