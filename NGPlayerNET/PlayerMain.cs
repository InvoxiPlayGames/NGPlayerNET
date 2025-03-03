using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxShockwaveFlashObjects;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace NGPlayerNET
{
    public partial class PlayerMain : Form
    {
        AxShockwaveFlash flash = null;

        PortalSWFMeta cachedMeta = null;
        string loadedFilename = null;

        int flashVersion = 0;

        public PlayerMain()
        {
            InitializeComponent();
            SetToolBarFlashInfo(null);
            EnableDisableControls(false);

            PlayerConfig.LoadSettings();
            PlayerConfig.SaveSettings();
        }

        private void EnableDisableControls(bool isFlashLoaded)
        {
            flashQualityToolStripMenuItem.Enabled = isFlashLoaded;
            unloadSWFToolStripMenuItem.Enabled = isFlashLoaded;
            if (flash != null)
                flash.Visible = isFlashLoaded;
        }

        private void SetToolBarFlashInfo(string moviePath = null)
        {
            if (cachedMeta == null)
            {
                currentFlashAuthorToolStripMenuItem.Visible = false;
                viewOnNewgroundsToolStripMenuItem.Visible = false;
                if (moviePath == null || moviePath == "")
                    currentFlashNameToolStripMenuItem.Text = "No movie loaded";
                else
                    currentFlashNameToolStripMenuItem.Text = Path.GetFileName(flash.Movie);
            }
            else
            {
                currentFlashAuthorToolStripMenuItem.Visible = true;
                viewOnNewgroundsToolStripMenuItem.Visible = true;

                currentFlashNameToolStripMenuItem.Text = cachedMeta.title;
                currentFlashAuthorToolStripMenuItem.Text = string.Format("by {0}", cachedMeta.author);
            }
        }

        private void LoadNGFlash(int portalId, string authentication = "")
        {
            // try to fetch the metadata from Newgrounds
            PortalSWFMeta meta = null;
            try
            {
                meta = NGAPI.GetMetadata(portalId, authentication);
            }
            // lots of error handling!
            catch (Exception ex) // i've never seen an exception but they can happen.
            {
                MessageBox.Show("An error occurred when fetching information from Newgrounds.com.\n\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableControls(false);
                return;
            }
            if (meta == null) // if the network connection fails then the getmetadata function fails without error
            {
                MessageBox.Show("Failed to get info from Newgrounds.com, likely due to a connection issue.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnableDisableControls(false);
                return;
            }
            if (meta.error != null) // if the newgrounds api itself has returned an error code
            {
                string err = string.Format("{0}: {1}", meta.error.code, meta.error.msg);
                MessageBox.Show("Failed to get info from Newgrounds.com due to an error.\n\n" + err, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnableDisableControls(false);
                return;
            }

            EnableDisableControls(true);

            // keep hold of our metadata
            cachedMeta = meta;

            // reset the current flash state
            flash.Stop();
            flash.Movie = "about:blank";

            // if we have flashVars (authenticated via ng) set them, else clear them
            if (meta.flashVars != null && meta.flashVars != "")
                flash.FlashVars = meta.flashVars;
            else
                flash.FlashVars = "";

            // load the movie and set the quality
            flash.Movie = meta.swf;
            loadedFilename = meta.swf;
            flash.Quality2 = PlayerConfig.DefaultQuality;

            // set the window title and size
            this.ClientSize = new Size(Convert.ToInt32(meta.width), Convert.ToInt32(meta.height) + menuStrip1.ClientSize.Height);
            this.Text = meta.title + " (Newgrounds) - NGPlayerNET";

            SetToolBarFlashInfo();
        }

        private void LoadGenericSWF(string filePath)
        {
            EnableDisableControls(true);

            // clear newgrounds metadata cache
            cachedMeta = null;

            // reset the current flash state
            flash.Stop();
            flash.Movie = "about:blank";
            flash.FlashVars = "";

            // load the movie and set the quality
            flash.Movie = filePath;
            loadedFilename = filePath;
            flash.Quality2 = PlayerConfig.DefaultQuality;

            // set the window title and size
            this.ClientSize = new Size(PlayerConfig.DefaultExternalWidth, PlayerConfig.DefaultExternalHeight + menuStrip1.ClientSize.Height);
            this.Text = Path.GetFileNameWithoutExtension(filePath) + " (Local) - NGPlayerNET";

            SetToolBarFlashInfo(filePath);
        }

        private void UnloadSWF()
        {
            cachedMeta = null;
            flash.Stop();
            flash.Movie = "about:blank";
            loadedFilename = null;
            EnableDisableControls(false);
            SetToolBarFlashInfo(null);
            this.Text = "NGPlayerNET";
        }

        private void PlayerMain_Load(object sender, EventArgs e)
        {
            // if we're running a debug build we want useful logs for this bull shit
#if !DEBUG
            try
#endif
            {
                flash = new EmmasAxShockwaveFlash();
                flashContainerPanel.Controls.Add(flash);
                flash.Dock = DockStyle.Fill;
                flash.Visible = true;
                Update();
                flashVersion = ((flash.FlashVersion() >> 16) & 0x7F);
                flash.Movie = "about:blank";
            }
#if !DEBUG
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialise Flash Player! Please make sure all the files are extracted, and you have Flash Player 9 or later installed.\n\n" + ex.Message, "Fatal Error - NGPlayerNET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
#endif

            EnableDisableControls(false);

            if (Program.Arguments.Length >= 1)
            {
                if (File.Exists(Program.Arguments[0]))
                {
                    LoadGenericSWF(Program.Arguments[0]);
                }
                else
                {
                    string auth = null;
                    int issuedPortalID = NGAPI.GetPortalIDFromURL(Program.Arguments[0], out auth);
                    if (issuedPortalID > 0)
                        LoadNGFlash(issuedPortalID, auth);
                }
            }
        }

        private void flashQualityToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            highQualityToolStripMenuItem.Checked = flash.Quality2 == "High";
            mediumQualityToolStripMenuItem.Checked = flash.Quality2 == "Medium";
            lowQualityToolStripMenuItem.Checked = flash.Quality2 == "Low";
            if (flash.Quality2 != "High" && flash.Quality2 != "Medium" && flash.Quality2 != "Low")
            {
                otherQualityToolStripMenuItem.Checked = true;
                otherQualityToolStripMenuItem.Text = flash.Quality2 + " (" + flash.Quality.ToString() + ")";
            }
            else
            {
                otherQualityToolStripMenuItem.Visible = false;
            }
        }

        private void highQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flash.Quality2 = "High";
        }

        private void mediumQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flash.Quality2 = "Medium";
        }

        private void lowQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flash.Quality2 = "Low";
        }

        private void unloadSWFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnloadSWF();
        }

        private void aboutNGPlayerNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string localFlashVersion = null;
            if (flash is EmmasAxShockwaveFlash)
            {
                localFlashVersion = (flash as EmmasAxShockwaveFlash).GetLocalFlashVersion();
            }
            PlayerAboutBox pab = new PlayerAboutBox(flash.FlashVersion(), loadedFilename, cachedMeta, localFlashVersion);
            pab.ShowDialog();
        }

        private void loadNewgroundsFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNGFlashBox load = new LoadNGFlashBox();
            load.ShowDialog();
            int enteredID = load.GetEnteredPortalID();
            if (enteredID != 0)
            {
                LoadNGFlash(enteredID, load.GetEnteredPortalAuthentication());
            }
        }

        private void viewOnNewgroundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("https://www.newgrounds.com/portal/view/{0}", cachedMeta.id));
        }

        private void loadSWFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
                LoadGenericSWF(openFileDialog1.FileName);
        }

        private void nGPlayerNETSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
    }
}
