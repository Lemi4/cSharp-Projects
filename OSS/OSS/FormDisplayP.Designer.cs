namespace OSS
{
    partial class FormDisplayP
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
            this.tabControlDP = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbPozadine = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbDP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDP = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btndpCancel = new System.Windows.Forms.Button();
            this.btndpOK = new System.Windows.Forms.Button();
            this.btndpApply = new System.Windows.Forms.Button();
            this.cbTema = new System.Windows.Forms.ListBox();
            this.tabControlDP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDP
            // 
            this.tabControlDP.Controls.Add(this.tabPage1);
            this.tabControlDP.Controls.Add(this.tabPage2);
            this.tabControlDP.Location = new System.Drawing.Point(12, 12);
            this.tabControlDP.Name = "tabControlDP";
            this.tabControlDP.SelectedIndex = 0;
            this.tabControlDP.Size = new System.Drawing.Size(471, 439);
            this.tabControlDP.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbPozadine);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.cbDP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxDP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Desktop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbPozadine
            // 
            this.pbPozadine.Location = new System.Drawing.Point(95, 34);
            this.pbPozadine.Name = "pbPozadine";
            this.pbPozadine.Size = new System.Drawing.Size(264, 136);
            this.pbPozadine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPozadine.TabIndex = 5;
            this.pbPozadine.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OSS.Properties.Resources.monitor;
            this.pictureBox2.Location = new System.Drawing.Point(80, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // cbDP
            // 
            this.cbDP.FormattingEnabled = true;
            this.cbDP.Items.AddRange(new object[] {
            "Center",
            "Strech",
            "Tile",
            "Zoom"});
            this.cbDP.Location = new System.Drawing.Point(340, 245);
            this.cbDP.Name = "cbDP";
            this.cbDP.Size = new System.Drawing.Size(103, 21);
            this.cbDP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position:";
            // 
            // listBoxDP
            // 
            this.listBoxDP.FormattingEnabled = true;
            this.listBoxDP.Items.AddRange(new object[] {
            "Windows XP",
            "Solid Black",
            "Solid Red",
            "Solid Blue",
            "Solid Purple",
            "Solid Orange"});
            this.listBoxDP.Location = new System.Drawing.Point(9, 229);
            this.listBoxDP.Name = "listBoxDP";
            this.listBoxDP.Size = new System.Drawing.Size(325, 82);
            this.listBoxDP.TabIndex = 1;
            this.listBoxDP.SelectedIndexChanged += new System.EventHandler(this.listBoxDP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTema);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Izaberite temu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(18, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezolucija";
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(161, 67);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(91, 13);
            this.lbRes.TabIndex = 3;
            this.lbRes.Text = "Choose resolution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Less";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "More";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(155, 19);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btndpCancel
            // 
            this.btndpCancel.Location = new System.Drawing.Point(327, 457);
            this.btndpCancel.Name = "btndpCancel";
            this.btndpCancel.Size = new System.Drawing.Size(75, 23);
            this.btndpCancel.TabIndex = 1;
            this.btndpCancel.Text = "Cancel";
            this.btndpCancel.UseVisualStyleBackColor = true;
            this.btndpCancel.Click += new System.EventHandler(this.btndpCancel_Click);
            // 
            // btndpOK
            // 
            this.btndpOK.Location = new System.Drawing.Point(246, 457);
            this.btndpOK.Name = "btndpOK";
            this.btndpOK.Size = new System.Drawing.Size(75, 23);
            this.btndpOK.TabIndex = 2;
            this.btndpOK.Text = "OK";
            this.btndpOK.UseVisualStyleBackColor = true;
            this.btndpOK.Click += new System.EventHandler(this.btndpOK_Click);
            // 
            // btndpApply
            // 
            this.btndpApply.Location = new System.Drawing.Point(408, 457);
            this.btndpApply.Name = "btndpApply";
            this.btndpApply.Size = new System.Drawing.Size(75, 23);
            this.btndpApply.TabIndex = 3;
            this.btndpApply.Text = "Apply";
            this.btndpApply.UseVisualStyleBackColor = true;
            this.btndpApply.Click += new System.EventHandler(this.btndpApply_Click);
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Items.AddRange(new object[] {
            "Plava",
            "Crna",
            "Bela",
            "Siva"});
            this.cbTema.Location = new System.Drawing.Point(19, 71);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(220, 82);
            this.cbTema.TabIndex = 2;
            // 
            // FormDisplayP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 491);
            this.Controls.Add(this.btndpApply);
            this.Controls.Add(this.btndpOK);
            this.Controls.Add(this.btndpCancel);
            this.Controls.Add(this.tabControlDP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDisplayP";
            this.ShowIcon = false;
            this.Text = "Display Properties";
            this.tabControlDP.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndpCancel;
        private System.Windows.Forms.Button btndpOK;
        private System.Windows.Forms.Button btndpApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.PictureBox pbPozadine;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabControl tabControlDP;
        private System.Windows.Forms.ListBox cbTema;
    }
}