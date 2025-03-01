using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NGPlayerNET
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            PlayerConfig.LoadSettings();
        }

        private void PopulateConnectionSettingsGroup()
        {
            if (PlayerConfig.DisallowHTTPMirror)
            {
                ngHttpsWithFallbackRadio.Checked = false;
                alwaysFallbackRadio.Checked = false;
                alwaysHttpsRadio.Checked = true;
            }
            else if (PlayerConfig.AlwaysUseHTTPMirror)
            {
                ngHttpsWithFallbackRadio.Checked = false;
                alwaysFallbackRadio.Checked = true;
                alwaysHttpsRadio.Checked = false;
            }
            else
            {
                ngHttpsWithFallbackRadio.Checked = true;
                alwaysFallbackRadio.Checked = false;
                alwaysHttpsRadio.Checked = false;
            }

            if (Program.IsSecureOperatingSystem())
            {
                PlayerConfig.DisallowHTTPMirror = true;
                PlayerConfig.AlwaysUseHTTPMirror = false;
                ngHttpsWithFallbackRadio.Checked = false;
                ngHttpsWithFallbackRadio.Enabled = false;
                alwaysFallbackRadio.Checked = false;
                alwaysFallbackRadio.Enabled = false;
                alwaysHttpsRadio.Checked = true;
            }
        }

        private void PopulateVisualSettingsGroup()
        {
            defaultQualityBox.SelectedItem = PlayerConfig.DefaultQuality;
            resWidthTextBox.Text = PlayerConfig.DefaultExternalWidth.ToString();
            resHeightTextBox.Text = PlayerConfig.DefaultExternalHeight.ToString();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            PopulateVisualSettingsGroup();
            PopulateConnectionSettingsGroup();
        }

        private void connectionInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string thirdPartyList = "";
            foreach (string mirror in NGAPI.NG_PORTAL_META_MIRRORS)
            {
                string host = mirror.Split('/')[2];
                if (thirdPartyList.Length > 1) thirdPartyList += ", ";
                thirdPartyList += host;
            }

            string messageIntro =
@"When given a Newgrounds Portal link or launched via the Newgrounds website, NGPlayerNET has to ask Newgrounds.com to fetch information about and download the given movie or game.

Older computers may fail to connect to the modern HTTPS site used by Newgrounds.com, so you can choose to use a third-party fallback using the less secure HTTP protocol.

";

            string messageContinued = 
@"Note that the Newgrounds medals and leaderboards system will not work if a fallback was used. Additionally your internet service provider, anyone on your network and the randomly selected third-party host might be able to see or change what animations you're viewing.

Current third-party hosts: " + thirdPartyList;

            if (Program.IsSecureOperatingSystem())
            {
                messageContinued =
@"Because you're on a modern version of Windows, using Newgrounds.com over HTTPS is enabled by default and can not be disabled.";
            }

            MessageBox.Show(this, messageIntro + messageContinued, "What does this mean?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PlayerConfig.DefaultQuality = (string)defaultQualityBox.SelectedItem;

            int resWint = 0;
            int resHint = 0;
            if (int.TryParse(resWidthTextBox.Text, out resWint) &&
                int.TryParse(resHeightTextBox.Text, out resHint))
            {
                PlayerConfig.DefaultExternalWidth = resWint;
                PlayerConfig.DefaultExternalHeight = resHint;
            }

            if (alwaysHttpsRadio.Checked)
            {
                PlayerConfig.AlwaysUseHTTPMirror = false;
                PlayerConfig.DisallowHTTPMirror = true;
            }
            else if (alwaysFallbackRadio.Checked)
            {
                PlayerConfig.AlwaysUseHTTPMirror = true;
                PlayerConfig.DisallowHTTPMirror = false;
            }
            else
            {
                PlayerConfig.AlwaysUseHTTPMirror = false;
                PlayerConfig.DisallowHTTPMirror = false;
            }

            PlayerConfig.SaveSettings();

            Close();
        }

        private void resWidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void resHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void installHandlerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult r = MessageBox.Show(
@"Do you want to add a URL handler for NGPlayerNET?
This will make ""Open in Newgrounds Player"" links from Newgrounds.com open in NGPlayerNET.

This will replace the official Newgrounds Player if you have it installed.", "Install URI Handler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (URIHandlerManager.InstallURIHandler(Environment.OSVersion.Platform == PlatformID.Win32Windows))
                {
                    MessageBox.Show("Successfully installed NGPlayerNET URL handler!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to install NGPlayerNET URL handler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
