﻿#define isdbg //NOTE: DO NOT FORGET TO UNDEFINE (comment out) THIS ON RELEASE.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Drawing.IconLib;

//using System.Runtime.InteropServices;

namespace masamangalternatibo {

    public partial class Form1 : Form {
        public Form1() { InitializeComponent(); }

        string version = "1.0";
        bool payloadMode = true; // true = File payload // false = Shell Code payload
        string lastPayloadContainer;
        int overflowCount = 20;

        private void Form1_Load(object sender, EventArgs e) {
            lblVersion.Text = "v" + version;
            loadDrives();
            checkComponents();
            #if !(isdbg)
             using (about _form = new about()) {
                dbgmsg("Showing about form...");
                _form.ShowDialog();
            }
            #endif
            dbgmsg("mA Ready! // Hover an item for more information!");
            #if isdbg
            dbgmsg("mA is running in debugging mode!");
            #endif
        }

        private void extractIcon(bool fromButton = false, string iconfile = "") {
            //fromButton supresses error if it wasn't the users' intention to extract an icon
            if (iconfile != "") {
                dbgmsg("Extracting associated icon to bitmap...");
                MultiIcon conico = new MultiIcon();
                conico.Add("iconinstance").CreateFrom(Icon.ExtractAssociatedIcon(iconfile).ToBitmap(), IconOutputFormat.WinXP);
                conico.SelectedIndex = 0;
                conico.Save(Application.StartupPath + "\\$temp.ico", MultiIconFormat.ICO);
                imgFileIcon.ImageLocation = "$tmp.ico";
            }
            else {
                if (fromButton) {
                    MessageBox.Show("No spoof file imported", "Error");
                }
                else {
                    dbgmsg("Error from un-intended extraction suppressed!");
                }
            }
        }

        private string trimext(string flname) {
            string[] aa = flname.Split('.');
            string tmp = "";
            for (int x = 0; x <= aa.Count() - 2; x++) {
                tmp += "." + aa[x];
            }
            return tmp;
        }

        #region [Console Commands]
        private void btnConsole_Click(object sender, EventArgs e) {
            string[] con = tbConsole.Text.Split(' ');
            switch ((con[0]).ToLower()) {
                case "owo":
                    dbgmsg("OwO ~ what's this?");
                    break;

                case "setdrive":
                    drpDrives.Items.Add(con[1]);
                    drpDrives.SelectedIndex = drpDrives.Items.Count - 1;
                    dbgmsg("Override command -- Drive selection set and added -- " + con[1]);
                    break;

                case "exit":
                    Application.Exit();
                    break;

                case "setoverflowcount":
                    overflowCount = Convert.ToInt32(con[1]);
                    dbgmsg("Overflow loop count changed to " + con[1]);
                    break;

                case "setimagelocation":
                    imgFileIcon.ImageLocation = con[1];
                    dbgmsg("Image location set : " + con[1]);
                    break;

                case "cls":
                    dbgRtb.Text = "";
                    break;

                case "dbgcd":
                   
                    break;

                default:
                    dbgmsg("Bad command! Available commands:\nsetdrive [driveletter]\nsetoverflowcount [integer]\nsetimagelocation [filepath]\ncls\nexit\n");
                    break;
            }
            tbConsole.Text = "";
        }
        #endregion

        private void checkComponents() {
            #region [Component: Compiler]
            dbgmsg("Checking for compiler...");
            if (!(File.Exists("compiler.exe"))) {
                if (MessageBox.Show("An important component of mA is missing!\n\nThe AutoIt compiler (compiler.exe) was not found, you cannot use mA with out the compiler as it needs to compile scripts to standalone executables.\n\nPressing Yes will download the compiler from this link\nhttps://github.com/tragenalpha/masamangalternatibo/raw/master/Aut2Exe/compiler.exe\n\nThis will be downloaded in the background.", "Script compiler missing! // Download component \"compiler.exe\" (1.32mb)", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    dbgmsg("Downloading file...");
                    using (WebClient _wc = new WebClient()) {
                        _wc.DownloadFile("https://github.com/tragenalpha/masamangalternatibo/raw/master/Aut2Exe/compiler.exe", "compiler.exe");
                    }
                    dbgmsg("Download complete!");
                    MessageBox.Show("Download complete!", "Download component \"compiler.exe\" (1.32mb)");
                }
                else {
                    dbgmsg("Application cannot function without compiler... Exiting!");
                    using (about _form = new about()) { _form.Close(); }
                    Application.Exit();
                    return;
                }
            }
            }
            #endregion
            
        private void dbgmsg(string a) {
            lblDbg.Text = a;
            dbgRtb.Text = a + "\n" + dbgRtb.Text;
        }

        //ghetto title bar management
        private void titlebar_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Location = new Point((MousePosition.X - (titlebar.Size.Width / 2)), (MousePosition.Y - (titlebar.Size.Height / 2)));
            }
        }
        private void label4_MouseMove(object sender, MouseEventArgs e) { titlebar_MouseMove(null, e); }
        private void label1_MouseMove(object sender, MouseEventArgs e) { titlebar_MouseMove(null, e); }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void loadDrives() {
            dbgmsg("Detecting drives...");
            drpDrives.Items.Clear();
            for (int i = 65; i <= 90; i++) {
                if (Directory.Exists(((char)i).ToString() + ":\\")) {
                    drpDrives.Items.Add(((char)i).ToString() + ":\\");
                }
            }
            drpDrives.SelectedIndex = 0;
            dbgmsg("Finished!");
        }

        private void btnSwitchMode_Click(object sender, EventArgs e) {
            string tmpStore;
            if (payloadMode) {
                payloadMode = false;
                btnSwitchMode.Text = "S";
                btnBrowsePayload.Enabled = false;
                tbPayload.ReadOnly = false;
                lblPayload.Text = "Shell Code:";
                tmpStore = lastPayloadContainer;
                lastPayloadContainer = tbPayload.Text;
                tbPayload.Text = tmpStore;
                pnlFileOptGroup.Enabled = false;
            }
            else {
                payloadMode = true;
                btnSwitchMode.Text = "P";
                btnBrowsePayload.Enabled = true;
                tbPayload.ReadOnly = true;
                lblPayload.Text = "Payload File:";
                tmpStore = lastPayloadContainer;
                lastPayloadContainer = tbPayload.Text;
                tbPayload.Text = tmpStore;
                pnlFileOptGroup.Enabled = true;
            }
        }

        private void btnRefreshDrives_Click(object sender, EventArgs e) {
            loadDrives();
        }

        private void btnSelf_Click(object sender, EventArgs e) {
            Process.Start("https://tragenalpha.github.io");
        }

        private void btnGitSauce_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/tragenalpha/masamangalternatibo");
        }

        private void btnCommand_Click(object sender, EventArgs e) {
            if (btnCommand.Text == "/c") {
                btnCommand.Text = "/k";
            }
            else {
                btnCommand.Text = "/c";
            }
        }

        private void btnBrowseSpoof_Click(object sender, EventArgs e) {
            ofdSpoof.ShowDialog();
        }

        private void btnBrowsePayload_Click(object sender, EventArgs e) {
            ofdPayload.ShowDialog();
        }

        private void ofdPayload_FileOk(object sender, CancelEventArgs e) {
            tbPayload.Text = ofdPayload.SafeFileName;
        }

        private void ofdSpoof_FileOk(object sender, CancelEventArgs e) {
            tbSpoof.Text = ofdSpoof.SafeFileName;
            extractIcon(false, ofdSpoof.SafeFileName);
        }

        private void btn3rdParty_Click(object sender, EventArgs e) {
            using (about _form = new about()) {
                _form.ShowDialog();
            }
        }

        private void chkArguments_CheckedChanged(object sender, EventArgs e) {
            if (chkArguments.Checked) {
                tbArguments.Enabled = true;
            }
            else {
                tbArguments.Enabled = false;
            }
        }

        private void chkConsole_CheckedChanged(object sender, EventArgs e) {
            if (chkConsole.Checked) {
                chkStreamConsole.Enabled = true;
                btnCommand.Enabled = true;
            }
            else {
                chkStreamConsole.Enabled = false;
                btnCommand.Enabled = false;
            }
        }

        private void btnClearImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            dbgmsg("Clearing image box...");
            imgFileIcon.Image = null;
        }

        private void btnBrowseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ofdIcon.ShowDialog();
        }

        private void ofdIcon_FileOk(object sender, CancelEventArgs e) {
            dbgmsg("Copying as temporary file...");
            File.Copy(ofdIcon.FileName, "$tmp.ico");
            dbgmsg("Loading image...");
            imgFileIcon.ImageLocation = "$tmp.ico";
        }

        private void btnExtract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            extractIcon(true, ofdSpoof.FileName);
        }
    }
}
