using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSS
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelUser.Visible = true;
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1 desktop = (Form1)this.Owner;
            desktop.pbAvatar.Image = OSS.Properties.Resources.windowsXP;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 desktop = (Form1)this.Owner;
            
            if(tbStara.Text == desktop.sifra)
            {
                desktop.sifra = tbNova.Text;
                MessageBox.Show("Uspesno ste promenili lozinku");
            }
            else
            {
                MessageBox.Show("Stara lozinka nije tacna");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelUser.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelUser.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelUser.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._1;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb2.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._2;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb3.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._3;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb4.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._4;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb5.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._5;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb6.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._6;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb7.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._7;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb8.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._8;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb9.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._9;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb10.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._10;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb11.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources._11;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb12.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources.user1;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }

            if (rb13.Checked == true)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.pbAvatar.Image = Properties.Resources.guest;
                MessageBox.Show("Uspesno ste promenili profilnu sliku");
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 desktop = (Form1)this.Owner;
            FormDisplayP f2 = new FormDisplayP();
            f2.Show(desktop);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 desktop = (Form1)this.Owner;
            FormDisplayP f2 = new FormDisplayP();
            f2.Show(desktop);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 desktop = (Form1)this.Owner;
            FormDisplayP f2 = new FormDisplayP();
            f2.Show(desktop);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string bit;

            if(Environment.Is64BitOperatingSystem == true)
            {
                bit = "Da";
            }
            else
            {
                bit = "Ne";
            }
            MessageBox.Show("Verzija OS-a: " + Environment.OSVersion.ToString() + "\n" +
                "Service pack: " + Environment.OSVersion.ServicePack.ToString() + "\n" +
                "Ime racunara " + Environment.MachineName.ToString() + "\n" +
                "64bit OS: " + bit);
           
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string bit;

            if (Environment.Is64BitOperatingSystem == true)
            {
                bit = "Da";
            }
            else
            {
                bit = "Ne";
            }
            MessageBox.Show("Verzija OS-a: " + Environment.OSVersion.ToString() + "\n" +
                "Service pack: " + Environment.OSVersion.ServicePack.ToString() + "\n" +
                "Ime racunara " + Environment.MachineName.ToString() + "\n" +
                "64bit OS: " + bit);
        }
    }
}
