using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NGPlayerNET
{
    public partial class LoadNGFlashBox : Form
    {
        private int _enteredPortalId = 0;
        private string _enteredPortalAuth = null;

        public LoadNGFlashBox()
        {
            InitializeComponent();
        }

        private void portalURLTextBox_TextChanged(object sender, EventArgs e)
        {
            string discardAuth = null;
            if (NGAPI.GetPortalIDFromURL(portalURLTextBox.Text, out discardAuth) != 0)
            {
                loadButton.Enabled = true;
                fetchInfoLinkLabel.Enabled = true;
            }
            else
            {
                loadButton.Enabled = false;
                fetchInfoLinkLabel.Enabled = false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            _enteredPortalId = NGAPI.GetPortalIDFromURL(portalURLTextBox.Text, out _enteredPortalAuth);
            Close();
        }

        public int GetEnteredPortalID()
        {
            return _enteredPortalId;
        }

        public string GetEnteredPortalAuthentication()
        {
            return _enteredPortalAuth;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadNGFlashBox_Load(object sender, EventArgs e)
        {

        }
    }
}
