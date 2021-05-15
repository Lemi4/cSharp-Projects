namespace OSS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelStart = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.BtnLogoff = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVreme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmsDesktop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Kalendar = new System.Windows.Forms.MonthCalendar();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelStart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.Silver;
            this.panelStart.Controls.Add(this.button5);
            this.panelStart.Controls.Add(this.btnShutdown);
            this.panelStart.Controls.Add(this.BtnLogoff);
            this.panelStart.Controls.Add(this.button4);
            this.panelStart.Controls.Add(this.button3);
            this.panelStart.Controls.Add(this.button2);
            this.panelStart.Location = new System.Drawing.Point(0, 350);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(208, 300);
            this.panelStart.TabIndex = 1;
            this.panelStart.Visible = false;
            // 
            // button5
            // 
            this.button5.Image = global::OSS.Properties.Resources.Control;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "Control Panel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(106, 264);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(99, 29);
            this.btnShutdown.TabIndex = 7;
            this.btnShutdown.Text = "Shut Down";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // BtnLogoff
            // 
            this.BtnLogoff.Location = new System.Drawing.Point(3, 264);
            this.BtnLogoff.Name = "BtnLogoff";
            this.BtnLogoff.Size = new System.Drawing.Size(104, 29);
            this.BtnLogoff.TabIndex = 6;
            this.BtnLogoff.Text = "Log Off";
            this.BtnLogoff.UseVisualStyleBackColor = true;
            this.BtnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // button4
            // 
            this.button4.Image = global::OSS.Properties.Resources.explore;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "Internet Explore";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::OSS.Properties.Resources.notepad;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Notepad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::OSS.Properties.Resources.calculator1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calculator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbVreme);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 32);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lbVreme
            // 
            this.lbVreme.AutoSize = true;
            this.lbVreme.Location = new System.Drawing.Point(1192, 10);
            this.lbVreme.Name = "lbVreme";
            this.lbVreme.Size = new System.Drawing.Size(35, 13);
            this.lbVreme.TabIndex = 1;
            this.lbVreme.Text = "label1";
            this.lbVreme.Click += new System.EventHandler(this.lbVreme_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmsDesktop
            // 
            this.cmsDesktop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.taskbarToolStripMenuItem});
            this.cmsDesktop.Name = "cmsDesktop";
            this.cmsDesktop.Size = new System.Drawing.Size(128, 48);
            this.cmsDesktop.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDesktop_Opening);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.displayToolStripMenuItem.Text = "Properties";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // taskbarToolStripMenuItem
            // 
            this.taskbarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionToolStripMenuItem});
            this.taskbarToolStripMenuItem.Name = "taskbarToolStripMenuItem";
            this.taskbarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.taskbarToolStripMenuItem.Text = "Taskbar";
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.bottomToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click_1);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bottomToolStripMenuItem.Text = "Bottom";
            this.bottomToolStripMenuItem.Click += new System.EventHandler(this.bottomToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(493, 328);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(247, 20);
            this.tbSifra.TabIndex = 3;
            this.tbSifra.Visible = false;
            this.tbSifra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSifra_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Turquoise;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(762, 319);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(73, 29);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.BackColor = System.Drawing.Color.Transparent;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLoading.Location = new System.Drawing.Point(547, 443);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(169, 39);
            this.lbLoading.TabIndex = 6;
            this.lbLoading.Text = "Loading...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(508, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // timerStart
            // 
            this.timerStart.Interval = 15;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // Kalendar
            // 
            this.Kalendar.Location = new System.Drawing.Point(1037, 481);
            this.Kalendar.Name = "Kalendar";
            this.Kalendar.TabIndex = 8;
            this.Kalendar.Visible = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbAvatar.Image = global::OSS.Properties.Resources.user1;
            this.pbAvatar.Location = new System.Drawing.Point(554, 169);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(147, 129);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 4;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ContextMenuStrip = this.cmsDesktop;
            this.Controls.Add(this.Kalendar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panelStart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cmsDesktop;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label lbVreme;
        public System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button BtnLogoff;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.PictureBox pbAvatar;
        public System.Windows.Forms.TextBox tbSifra;
        public System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.ToolStripMenuItem taskbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MonthCalendar Kalendar;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

