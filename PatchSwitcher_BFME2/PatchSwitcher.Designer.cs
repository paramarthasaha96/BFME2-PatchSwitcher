using System.Drawing;
namespace PatchSwitcher_BFME2
{
    partial class PatchSwitcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchSwitcher));
            this.pan_Main = new System.Windows.Forms.Panel();
            this.pb_checkbox = new System.Windows.Forms.PictureBox();
            this.but_factionfloor = new System.Windows.Forms.PictureBox();
            this.but_gamerreplay = new System.Windows.Forms.PictureBox();
            this.pan_Header = new System.Windows.Forms.Panel();
            this.but_min = new System.Windows.Forms.PictureBox();
            this.but_close = new System.Windows.Forms.PictureBox();
            this.pb_currentVersion = new System.Windows.Forms.PictureBox();
            this.but_grouplink = new System.Windows.Forms.Button();
            this.but_patch100 = new System.Windows.Forms.Button();
            this.but_fixResolution = new System.Windows.Forms.Button();
            this.but_patch106 = new System.Windows.Forms.Button();
            this.but_patch109 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pan_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_factionfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_gamerreplay)).BeginInit();
            this.pan_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.but_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_currentVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Main
            // 
            this.pan_Main.BackColor = System.Drawing.Color.Transparent;
            this.pan_Main.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.baseimage;
            this.pan_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pan_Main.Controls.Add(this.pb_checkbox);
            this.pan_Main.Controls.Add(this.but_factionfloor);
            this.pan_Main.Controls.Add(this.but_gamerreplay);
            this.pan_Main.Controls.Add(this.pan_Header);
            this.pan_Main.Controls.Add(this.pb_currentVersion);
            this.pan_Main.Controls.Add(this.but_grouplink);
            this.pan_Main.Controls.Add(this.but_patch100);
            this.pan_Main.Controls.Add(this.but_fixResolution);
            this.pan_Main.Controls.Add(this.but_patch106);
            this.pan_Main.Controls.Add(this.but_patch109);
            this.pan_Main.Location = new System.Drawing.Point(0, 0);
            this.pan_Main.Name = "pan_Main";
            this.pan_Main.Size = new System.Drawing.Size(700, 500);
            this.pan_Main.TabIndex = 0;
            // 
            // pb_checkbox
            // 
            this.pb_checkbox.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.enablefactionfloorsx;
            this.pb_checkbox.Location = new System.Drawing.Point(480, 318);
            this.pb_checkbox.Name = "pb_checkbox";
            this.pb_checkbox.Size = new System.Drawing.Size(19, 18);
            this.pb_checkbox.TabIndex = 18;
            this.pb_checkbox.TabStop = false;
            this.pb_checkbox.Click += new System.EventHandler(this.pb_checkbox_Click);
            // 
            // but_factionfloor
            // 
            this.but_factionfloor.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.enablefactionfloorsbutton;
            this.but_factionfloor.ErrorImage = null;
            this.but_factionfloor.Location = new System.Drawing.Point(471, 303);
            this.but_factionfloor.Name = "but_factionfloor";
            this.but_factionfloor.Size = new System.Drawing.Size(200, 48);
            this.but_factionfloor.TabIndex = 17;
            this.but_factionfloor.TabStop = false;
            // 
            // but_gamerreplay
            // 
            this.but_gamerreplay.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.gamereplaysbutton;
            this.but_gamerreplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_gamerreplay.Location = new System.Drawing.Point(581, 417);
            this.but_gamerreplay.Name = "but_gamerreplay";
            this.but_gamerreplay.Size = new System.Drawing.Size(61, 59);
            this.but_gamerreplay.TabIndex = 16;
            this.but_gamerreplay.TabStop = false;
            this.but_gamerreplay.Click += new System.EventHandler(this.but_gamerreplay_Click);
            // 
            // pan_Header
            // 
            this.pan_Header.BackColor = System.Drawing.Color.Transparent;
            this.pan_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pan_Header.Controls.Add(this.but_min);
            this.pan_Header.Controls.Add(this.but_close);
            this.pan_Header.ForeColor = System.Drawing.Color.Transparent;
            this.pan_Header.Location = new System.Drawing.Point(0, 0);
            this.pan_Header.Name = "pan_Header";
            this.pan_Header.Size = new System.Drawing.Size(700, 34);
            this.pan_Header.TabIndex = 14;
            this.pan_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_Header_Paint);
            this.pan_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_Header_MouseDown);
            this.pan_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_Header_MouseMove);
            this.pan_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pan_Header_MouseUp);
            // 
            // but_min
            // 
            this.but_min.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.minimize;
            this.but_min.Location = new System.Drawing.Point(644, 3);
            this.but_min.Name = "but_min";
            this.but_min.Size = new System.Drawing.Size(19, 18);
            this.but_min.TabIndex = 19;
            this.but_min.TabStop = false;
            this.but_min.Click += new System.EventHandler(this.but_min_Click);
            // 
            // but_close
            // 
            this.but_close.Image = global::PatchSwitcher_BFME2.Properties.Resources.exit;
            this.but_close.Location = new System.Drawing.Point(669, 3);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(19, 18);
            this.but_close.TabIndex = 3;
            this.but_close.TabStop = false;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // pb_currentVersion
            // 
            this.pb_currentVersion.BackColor = System.Drawing.Color.Transparent;
            this.pb_currentVersion.InitialImage = null;
            this.pb_currentVersion.Location = new System.Drawing.Point(180, 357);
            this.pb_currentVersion.Name = "pb_currentVersion";
            this.pb_currentVersion.Size = new System.Drawing.Size(344, 109);
            this.pb_currentVersion.TabIndex = 13;
            this.pb_currentVersion.TabStop = false;
            this.pb_currentVersion.Click += new System.EventHandler(this.pb_currentVersion_Click);
            // 
            // but_grouplink
            // 
            this.but_grouplink.BackColor = System.Drawing.Color.Transparent;
            this.but_grouplink.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.facebookbutton;
            this.but_grouplink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_grouplink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_grouplink.FlatAppearance.BorderSize = 0;
            this.but_grouplink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_grouplink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_grouplink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_grouplink.Location = new System.Drawing.Point(39, 429);
            this.but_grouplink.Name = "but_grouplink";
            this.but_grouplink.Size = new System.Drawing.Size(36, 36);
            this.but_grouplink.TabIndex = 12;
            this.but_grouplink.UseVisualStyleBackColor = false;
            this.but_grouplink.Click += new System.EventHandler(this.but_grouplink_Click);
            // 
            // but_patch100
            // 
            this.but_patch100.BackColor = System.Drawing.Color.Transparent;
            this.but_patch100.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources._100button;
            this.but_patch100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_patch100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_patch100.FlatAppearance.BorderSize = 0;
            this.but_patch100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_patch100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_patch100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_patch100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_patch100.ForeColor = System.Drawing.Color.White;
            this.but_patch100.Location = new System.Drawing.Point(277, 141);
            this.but_patch100.Margin = new System.Windows.Forms.Padding(6);
            this.but_patch100.Name = "but_patch100";
            this.but_patch100.Size = new System.Drawing.Size(143, 65);
            this.but_patch100.TabIndex = 0;
            this.but_patch100.UseVisualStyleBackColor = false;
            this.but_patch100.Click += new System.EventHandler(this.but_patch100_Click);
            this.but_patch100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_patch100_MouseDown);
            this.but_patch100.MouseEnter += new System.EventHandler(this.but_patch100_MouseEnter);
            this.but_patch100.MouseLeave += new System.EventHandler(this.but_patch100_MouseLeave);
            this.but_patch100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_patch100_MouseUp);
            // 
            // but_fixResolution
            // 
            this.but_fixResolution.BackColor = System.Drawing.Color.Transparent;
            this.but_fixResolution.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources.fixmyresbutton;
            this.but_fixResolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_fixResolution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_fixResolution.FlatAppearance.BorderSize = 0;
            this.but_fixResolution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_fixResolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_fixResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_fixResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_fixResolution.ForeColor = System.Drawing.Color.White;
            this.but_fixResolution.Location = new System.Drawing.Point(59, 306);
            this.but_fixResolution.Margin = new System.Windows.Forms.Padding(6);
            this.but_fixResolution.Name = "but_fixResolution";
            this.but_fixResolution.Size = new System.Drawing.Size(156, 42);
            this.but_fixResolution.TabIndex = 10;
            this.but_fixResolution.UseVisualStyleBackColor = false;
            this.but_fixResolution.Click += new System.EventHandler(this.but_fixResolution_Click);
            // 
            // but_patch106
            // 
            this.but_patch106.BackColor = System.Drawing.Color.Transparent;
            this.but_patch106.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources._106button;
            this.but_patch106.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_patch106.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_patch106.FlatAppearance.BorderSize = 0;
            this.but_patch106.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_patch106.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_patch106.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_patch106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_patch106.ForeColor = System.Drawing.Color.White;
            this.but_patch106.Location = new System.Drawing.Point(277, 218);
            this.but_patch106.Margin = new System.Windows.Forms.Padding(6);
            this.but_patch106.Name = "but_patch106";
            this.but_patch106.Size = new System.Drawing.Size(143, 65);
            this.but_patch106.TabIndex = 0;
            this.but_patch106.UseVisualStyleBackColor = false;
            this.but_patch106.Click += new System.EventHandler(this.but_patch106_Click);
            this.but_patch106.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_patch106_MouseDown);
            this.but_patch106.MouseEnter += new System.EventHandler(this.but_patch106_MouseEnter);
            this.but_patch106.MouseLeave += new System.EventHandler(this.but_patch106_MouseLeave);
            this.but_patch106.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_patch106_MouseUp);
            // 
            // but_patch109
            // 
            this.but_patch109.BackColor = System.Drawing.Color.Transparent;
            this.but_patch109.BackgroundImage = global::PatchSwitcher_BFME2.Properties.Resources._109button;
            this.but_patch109.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_patch109.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_patch109.FlatAppearance.BorderSize = 0;
            this.but_patch109.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_patch109.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_patch109.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_patch109.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_patch109.ForeColor = System.Drawing.Color.White;
            this.but_patch109.Location = new System.Drawing.Point(277, 294);
            this.but_patch109.Margin = new System.Windows.Forms.Padding(6);
            this.but_patch109.Name = "but_patch109";
            this.but_patch109.Size = new System.Drawing.Size(143, 65);
            this.but_patch109.TabIndex = 1;
            this.but_patch109.UseVisualStyleBackColor = false;
            this.but_patch109.Click += new System.EventHandler(this.but_patch109_Click);
            this.but_patch109.MouseDown += new System.Windows.Forms.MouseEventHandler(this.but_patch109_MouseDown);
            this.but_patch109.MouseEnter += new System.EventHandler(this.but_patch109_MouseEnter);
            this.but_patch109.MouseLeave += new System.EventHandler(this.but_patch109_MouseLeave);
            this.but_patch109.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_patch109_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // PatchSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pan_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PatchSwitcher";
            this.Text = "Patch Switcher for BFME 2";
            this.Load += new System.EventHandler(this.PatchSwitcher_Load);
            this.pan_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_checkbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_factionfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_gamerreplay)).EndInit();
            this.pan_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.but_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_currentVersion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_patch106;
        private System.Windows.Forms.Button but_fixResolution;
        private System.Windows.Forms.Button but_patch100;
        private System.Windows.Forms.Button but_grouplink;
        private System.Windows.Forms.Button but_patch109;
        private System.Windows.Forms.PictureBox pb_currentVersion;
        private System.Windows.Forms.Panel pan_Main;
        private System.Windows.Forms.Panel pan_Header;
        private System.Windows.Forms.PictureBox but_gamerreplay;
        private System.Windows.Forms.PictureBox pb_checkbox;
        private System.Windows.Forms.PictureBox but_factionfloor;
        private System.Windows.Forms.PictureBox but_min;
        private System.Windows.Forms.PictureBox but_close;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

