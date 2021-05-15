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

namespace OSS
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        public string sifra = "windows";
        private void button1_Click(object sender, EventArgs e)
        {
            if (panelStart.Visible == false)
            {
                panelStart.Visible = true;
            }
            else if (panelStart.Visible == true)
            {
                panelStart.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            FormCal formcal = new FormCal();
            formcal.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerStart.Start();
            timer1.Start();
            lbVreme.Text = DateTime.Now.ToLongTimeString();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbVreme.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelStart.Visible == true)
            {
                panelStart.Visible = false;
            }
        }


        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayP f2 = new FormDisplayP();
            f2.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            FormInternet internet = new FormInternet();
            internet.Show();
            
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            if (progressBar1.Value == 100)
            {
                
                pbAvatar.Visible = true;
                tbSifra.Visible = true;
                btnGo.Visible = true;
                lbLoading.Visible = false;
                progressBar1.Visible = false;
                timerStart.Stop();
            }
            
        }
        private void btnGo_Click(object sender, EventArgs e)
        {

            if (tbSifra.Text == sifra)
            {
                
                panel1.Visible = true;
                pbAvatar.Visible = false;
                tbSifra.Visible = false;
                btnGo.Visible = false;
            }
            else
            {
                MessageBox.Show("Pogresna lozinka.");
            }
        }

        private void BtnLogoff_Click(object sender, EventArgs e)
        {
            pbAvatar.Visible = true;
            tbSifra.Visible = true;
            btnGo.Visible = true;
            lbLoading.Visible = false;
            progressBar1.Visible = false;
            panel1.Visible = false;
            panelStart.Visible = false;
            tbSifra.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            FormNotepad formNotepad = new FormNotepad();
            formNotepad.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            FormControl control = new FormControl();
            control.Show(this);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void cmsDesktop_Opening(object sender, CancelEventArgs e)
        {

        }

       

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Dock = DockStyle.None;
            panel1.Location = new Point(1, 1);
            panel1.Size = new Size(77, 682);
            btnStart.Location = new Point(0, 11);
            panelStart.Location = new Point(78, 1);
            lbVreme.Location = new Point(11, 658);
        }

        private void bottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.None;
            panel1.Location = new Point(0, 649);
            panel1.Size = new Size(1264, 32);
            btnStart.Location = new Point(3, 3);
            panelStart.Location = new Point(0, 350);
            lbVreme.Location = new Point(1192, 10);
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Width == 800 && this.Height == 600)
            {
                panel1.Dock = DockStyle.None;
                panel1.Location = new Point(1186, 1);
                panel1.Size = new Size(77, 682);
                btnStart.Location = new Point(0, 11);
                panelStart.Location = new Point(978, 1);
                lbVreme.Location = new Point(11, 658);
            }

            if (this.Width == 1024 && this.Height == 768)
            {
                panel1.Dock = DockStyle.None;
                panel1.Location = new Point(1186, 1);
                panel1.Size = new Size(77, 682);
                btnStart.Location = new Point(0, 11);
                panelStart.Location = new Point(978, 1);
                lbVreme.Location = new Point(11, 658);
            }

            if (this.Width == 1280 && this.Height == 720)
            {
                panel1.Dock = DockStyle.None;
                panel1.Location = new Point(1186, 1);
                panel1.Size = new Size(77, 682);
                btnStart.Location = new Point(0, 11);
                panelStart.Location = new Point(978, 1);
                lbVreme.Location = new Point(11, 658);
            }

        }

        private void topToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(this.Width == 800 && this.Height == 600)
            {
                panel1.Dock = DockStyle.None;
                panel1.Location = new Point(0, 1);
                btnStart.Location = new Point(3, 3);
                panelStart.Location = new Point(1, 33);
            }

            if (this.Width == 1024 && this.Height == 768)
            {
                panel1.Dock = DockStyle.None;
                panel1.Location = new Point(0, 1);
                panel1.Size = new Size(1264, 32);
                btnStart.Location = new Point(3, 3);
                panelStart.Location = new Point(1, 33);
                lbVreme.Location = new Point(945, 10);
            }

            if (this.Width == 1280 && this.Height == 720)
            {
                panel1.Dock = DockStyle.None;
                panel1.Location = new Point(0, 1);
                panel1.Size = new Size(1264, 32);
                btnStart.Location = new Point(3, 3);
                panelStart.Location = new Point(1, 33);
                lbVreme.Location = new Point(1192, 10);
            }
     
        }

        private void lbVreme_Click(object sender, EventArgs e)
        {
            if (Kalendar.Visible == false)
            {
                Kalendar.Visible = true;
            }
            else if (Kalendar.Visible == true)
            {
                Kalendar.Visible = false;
            }
            
        }

        private void tbSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (tbSifra.Text == sifra)
                {

                    panel1.Visible = true;
                    pbAvatar.Visible = false;
                    tbSifra.Visible = false;
                    btnGo.Visible = false;
                }
                else
                {
                    MessageBox.Show("Pogresna lozinka.");
                }
            }
        }
    }
}
