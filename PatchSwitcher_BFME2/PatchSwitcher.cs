using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;



namespace PatchSwitcher_BFME2
{


    public partial class PatchSwitcher : Form
    {
        
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private string gamePath;
        private Finder finder;
        private int activeVersion;
        private string activeVersionText;

        public const int PATCH_100 = 100;
        public const int PATCH_106 = 106;
        public const int PATCH_108 = 108;
        public const int PATCH_109 = 109;
        public const int ff=200;
        public int ver = 0;
        public int ffflag=0;
        private bool terminated = false;
        
#if DEBUG
bool isDebugMode = true;
#else
bool isDebugMode = false;
#endif
        public PatchSwitcher(string gamePath)
        {
            if(isDebugMode) gamePath = @"D:\_DOWNLOADS\deneme";
            InitializeComponent();

            but_patch100.Cursor = Cursors.Hand;
            but_patch106.Cursor = Cursors.Hand;
            but_patch109.Cursor = Cursors.Hand;
            but_fixResolution.Cursor = Cursors.Hand;
            but_grouplink.Cursor = Cursors.Hand;

            if (gamePath == null)
            {
                MessageBox.Show("I can't find the folder which BFME 2 installed. \nThe program cannot switch your patch!"
                    , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                terminated = true;
                return;
            }

            this.gamePath = gamePath;
            this.finder = new Finder(gamePath);

            activeVersion = finder.getActiveVersion();

            pb_currentVersion.Image = finder.getActiveVersionImage(activeVersion);
            activeVersionText = finder.getActiveVersionText(activeVersion);
            
        }

        private void patchSwitchingWork(int thisPatch)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (activeVersion == thisPatch)
            {
                MessageBox.Show("Your current patch version is already " + activeVersionText + "!\nNothing's changed."
                    , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            finder.switchPatch(activeVersion, thisPatch);
            activeVersion = thisPatch;
            activeVersionText = finder.getActiveVersionText(activeVersion);
            pb_currentVersion.Image = finder.getActiveVersionImage(activeVersion);
            MessageBox.Show("Done! Your patch version is " + activeVersionText + " now!"
                , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Cursor.Current = Cursors.Default;
        }
                private void factionfloorswitchingWork(int thisPatch)
        {
            Cursor.Current = Cursors.WaitCursor;
            finder.switchPatch(activeVersion, thisPatch);
            activeVersion = thisPatch;
            Cursor.Current = Cursors.Default;
        }

        private void but_patch100_Click(object sender, EventArgs e)
        
        {

            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Please Wait! The Program is switching the patch", "Patch Switcher", MessageBoxButtons.OK);
                return;
            }
            if (terminated)
            {
                MessageBox.Show("I can't configurated the Patch Switcher, because of your game installation files."
                    + "\nIf you want to use this program, install the game correctly, or ask us to help!"
                    , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ffflag = -1;
            this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsxgrey;
            this.pb_checkbox.Enabled = false;
            ver = 1;
            backgroundWorker1.RunWorkerAsync();
        }

        private void but_patch106_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Please Wait! The Program is switching the patch", "Patch Switcher", MessageBoxButtons.OK);
                return;
            }
            if (terminated)
            {
                MessageBox.Show("I can't configurated the Patch Switcher, because of your game installation files."
                    + "\nIf you want to use this program, install the game correctly, or ask us to help!"
                    , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ffflag = -1;
            this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsxgrey;
            this.pb_checkbox.Enabled = false;
            ver = 2;
            
            backgroundWorker1.RunWorkerAsync();
        }

        private void but_patch109_Click(object sender, EventArgs e)
        {
            
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Please Wait! The Program is switching the patch", "Patch Switcher", MessageBoxButtons.OK);
                return;
            }
            if (terminated)
            {
                MessageBox.Show("I can't configurated the Patch Switcher, because of your game installation files."
                    + "\nIf you want to use this program, install the game correctly, or ask us to help!"
                    , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            this.pb_checkbox.Enabled = true;
            String curfile = gamePath + @"\__109floors.big";
            this.pb_checkbox.Enabled = true;
            if (File.Exists(curfile))
            {
                ffflag = 0;
                this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsx;

            }
            else
            {
                ffflag = 1;
                this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloors;
            }

            ver = 3;
            
            backgroundWorker1.RunWorkerAsync();
        }

        private void but_fixResolution_Click(object sender, EventArgs e)
        {
            Fixer f = new Fixer();

            DialogResult res = MessageBox.Show("This program is going to fix your BFME 2 game resolution to your desktop resolution now.\n\nDo you want to continue?"
                , "Resolution Fixer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                f.fixResolution();
            }
        }

        private void lk_group_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        private void but_grouplink_Click(object sender, EventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start("https://www.facebook.com/thebfme");
        }

       
       
        private void pan_Header_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void pan_Header_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pan_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pan_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pb_currentVersion_Click(object sender, EventArgs e)
        {

        }

      

        private void but_gamerreplay_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.gamereplays.org/battleformiddleearth2/");
        }
        
        private void PatchSwitcher_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("This Application is already running", "Patch Switcher", MessageBoxButtons.OK);
                this.Close();
            }

            finder.delete108(activeVersion);
            
            
           
            if (activeVersion != PATCH_109) 
            { 
                ffflag = -1;
                this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsxgrey; 
                this.pb_checkbox.Enabled = false;
            }
            else
            {
                String curfile = gamePath + @"\__109floors.big";
                this.pb_checkbox.Enabled = true;
                if (File.Exists(curfile))
                {
                    ffflag = 0;
                    this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsx; 
                }
                else
                {
                    ffflag = 1;
                    this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloors; 
                }


                
            }
            
            
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Please Wait! The Program is switching the patch", "Patch Switcher", MessageBoxButtons.OK);
            }
            else
            {
                this.Close();
            }
        }

        private void but_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void but_patch100_MouseDown(object sender, MouseEventArgs e)
        {
            this.but_patch100.BackgroundImage=Properties.Resources._100buttonclick;
        }

        private void but_patch100_MouseEnter(object sender, EventArgs e)
        {
            this.but_patch100.BackgroundImage = Properties.Resources._100buttonhover;
        }

        private void but_patch100_MouseLeave(object sender, EventArgs e)
        {
            this.but_patch100.BackgroundImage = Properties.Resources._100button;
        }

        private void but_patch100_MouseUp(object sender, MouseEventArgs e)
        {
            this.but_patch100.BackgroundImage = Properties.Resources._100buttonhover;
        }

        private void but_patch106_MouseDown(object sender, MouseEventArgs e)
        {
            this.but_patch106.BackgroundImage = Properties.Resources._106buttonclick;
        }

        private void but_patch106_MouseEnter(object sender, EventArgs e)
        {
            this.but_patch106.BackgroundImage = Properties.Resources._106buttonhover;
        }

        private void but_patch106_MouseLeave(object sender, EventArgs e)
        {
            this.but_patch106.BackgroundImage = Properties.Resources._106button;
        }

        private void but_patch106_MouseUp(object sender, MouseEventArgs e)
        {
            this.but_patch106.BackgroundImage = Properties.Resources._106buttonhover;
        }

        private void but_patch109_MouseDown(object sender, MouseEventArgs e)
        {
            this.but_patch109.BackgroundImage = Properties.Resources._109buttonclick;
        }

        private void but_patch109_MouseEnter(object sender, EventArgs e)
        {
            this.but_patch109.BackgroundImage = Properties.Resources._109buttonhover;
        }

        private void but_patch109_MouseLeave(object sender, EventArgs e)
        {
            this.but_patch109.BackgroundImage = Properties.Resources._109button;
        }

        private void but_patch109_MouseUp(object sender, MouseEventArgs e)
        {
            this.but_patch109.BackgroundImage = Properties.Resources._109buttonhover;
        }

        private void pb_checkbox_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Please Wait! The Program is switching the patch", "Patch Switcher", MessageBoxButtons.OK);
                return;
            }
            if (terminated)
            {
                MessageBox.Show("I can't configurated the Patch Switcher, because of your game installation files."
                    + "\nIf you want to use this program, install the game correctly, or ask us to help!"
                    , "Patch Switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (activeVersion != PATCH_109)
            {
                ffflag = -1;
                this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsxgrey;
                this.pb_checkbox.Enabled = false;
            }
            else
            {
                this.pb_checkbox.Enabled = true;
            }
            if (ffflag == 0)
            {
                File.Move(gamePath + @"\__109floors.big", gamePath + @"\__109floors.inv");
                this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloors;
                ffflag=1;
            }
            else if(ffflag == 1)
            {
                this.pb_checkbox.BackgroundImage = Properties.Resources.enablefactionfloorsx;
                File.Move(gamePath + @"\__109floors.inv", gamePath + @"\__109floors.big");
                ffflag = 0;

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ver == 1)
            {
                finder.delete108(activeVersion);
                patchSwitchingWork(100);

            }
            else if (ver==2)
            {
                finder.delete108(activeVersion);
                patchSwitchingWork(106);
            }
            else if (ver==3)
            {
                finder.delete108(activeVersion);
                patchSwitchingWork(109);
            }
           
                
               
            
        }

        private void pan_Header_Paint(object sender, PaintEventArgs e)
        {

        }




        
        
    }
}
