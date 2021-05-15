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
    public partial class FormDisplayP : Form
    {
        bool rezFix = false;

        public FormDisplayP()
        {
            InitializeComponent();
        }

        //APPLY dugme koje vrsi izmene iz forme Display properties:

        private void btndpApply_Click(object sender, EventArgs e)
        {
            if (listBoxDP.SelectedIndex > -1) //Ako je selektovana neka stavka iz listboxa...
            {
                
                if (listBoxDP.SelectedItem.ToString() == "Windows XP") //Ako je izabrana stavka windows xp
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImage = Properties.Resources.windowsXP;  //Promeni sliku na formi 1
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else //Ako nije selektovana ni jedna stavka iz lista boxa,ne radi nista
            {
                
            }

            if (listBoxDP.SelectedIndex > -1)
            {
                if (listBoxDP.SelectedItem.ToString() == "Solid Black")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImage = Properties.Resources.black;
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {

            }

            if (listBoxDP.SelectedIndex > -1)
            {
                if (listBoxDP.SelectedItem.ToString() == "Solid Orange")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImage = Properties.Resources.orange;
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {

            }

            if (listBoxDP.SelectedIndex > -1)
            {
                if (listBoxDP.SelectedItem.ToString() == "Solid Purple")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImage = Properties.Resources.purple;
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {

            }

            if (listBoxDP.SelectedIndex > -1)
            {
                if (listBoxDP.SelectedItem.ToString() == "Solid Red")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImage = Properties.Resources.red;
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {

            }

            if (listBoxDP.SelectedIndex > -1)
            {
                if (listBoxDP.SelectedItem.ToString() == "Solid Blue")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImage = Properties.Resources.blue;
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {

            }

            



            //Podesavanja za prikazivanje slike
            if (cbDP.SelectedIndex > -1)
            {
                if (cbDP.SelectedItem.ToString() == "Center")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {

            }

            if (cbDP.SelectedIndex > -1)
            {
                if (cbDP.SelectedItem.ToString() == "Stretch")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else
            {

            }

            if (cbDP.SelectedIndex > -1)
            {
                if (cbDP.SelectedItem.ToString() == "Tile")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImageLayout = ImageLayout.Tile;
                }
            }
            else
            {

            }

            if (cbDP.SelectedIndex > -1)
            {
                if (cbDP.SelectedItem.ToString() == "Zoom")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            else
            {

            }








            if (cbTema.SelectedIndex > -1)
            {
                if (cbTema.SelectedItem.ToString() == "Plava")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.panel1.BackColor = Color.Blue;
                    desktop.panelStart.BackColor = Color.Blue;
                    desktop.lbVreme.ForeColor = Color.Black;
                }
            }
            else
            {

            }
            if (cbTema.SelectedIndex > -1)
            {
                if (cbTema.SelectedItem.ToString() == "Crna")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.panel1.BackColor = Color.Black;
                    desktop.panelStart.BackColor = Color.Black;
                    desktop.lbVreme.ForeColor = Color.White;
                }
            }
            else
            {

            }
            if (cbTema.SelectedIndex > -1)
            {
                if (cbTema.SelectedItem.ToString() == "Bela")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.lbVreme.BackColor = Color.Black;
                    desktop.panel1.BackColor = Color.White;
                    desktop.panelStart.BackColor = Color.White;
                    desktop.lbVreme.ForeColor = Color.White;
                }
            }
            else
            {

            }
            if (cbTema.SelectedIndex > -1)
            {
                if (cbTema.SelectedItem.ToString() == "Siva")
                {
                    Form1 desktop = (Form1)this.Owner;
                    desktop.panel1.BackColor = Color.Gray;
                    desktop.panelStart.BackColor = Color.Gray;
                    desktop.lbVreme.ForeColor = Color.Black;
                }
            }
            else
            {

            }

            //Rezolucija/velicina forme
            if (trackBar1.Value == 1)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.Size = new Size(800, 600);
                desktop.lbVreme.Location = new Point(708, 10);
                desktop.panelStart.Location = new Point(0, 230);
                desktop.pbAvatar.Location = new Point(333, 158);
                desktop.tbSifra.Location = new Point(281, 306);
                desktop.btnGo.Location = new Point(547, 298);
                desktop.lbLoading.Location = new Point(310, 410);
                desktop.panel1.Dock = DockStyle.Bottom;
                desktop.Kalendar.Location = new Point(558, 370);


            }

            if (trackBar1.Value == 2)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.Size = new Size(1024, 768);
                desktop.lbVreme.Location = new Point(938, 10);
                desktop.panelStart.Location = new Point(0, 400);
                desktop.panel1.Dock = DockStyle.Bottom;
                desktop.Kalendar.Location = new Point(782, 530);
            }

            if (trackBar1.Value == 3)
            {
                Form1 desktop = (Form1)this.Owner;
                desktop.Size = new Size(1280, 720);
                desktop.lbVreme.Location = new Point(1192, 10);
                desktop.panelStart.Location = new Point(0, 350);
                desktop.panel1.Dock = DockStyle.Bottom;
                desktop.Kalendar.Location = new Point(1037, 481);
            }

        }

        //OK dugme koje primeni izmene i zatvori formu
        private void btndpOK_Click(object sender, EventArgs e)
        {
            btndpApply.PerformClick();

            
            this.Close();
        }

        //Rezolucija forme,promena labele
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (trackBar1.Value == 0)
            {
                lbRes.Text = "Choose resolution";
            }
            if (trackBar1.Value == 1)
            {
                lbRes.Text = "800 by 600 pixels";
            }
            if (trackBar1.Value == 2)
            {
                lbRes.Text = "1024 by 768 pixels";
            }
            if (trackBar1.Value == 3)
            {
                lbRes.Text = "1280 by 720 pixels";
                
            }
        }

        private void listBoxDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDP.SelectedItem.ToString() == "Windows XP")
            {
                pbPozadine.Image = OSS.Properties.Resources.windowsXP;
                pbPozadine.Refresh();
            }
            if (listBoxDP.SelectedItem.ToString() == "Solid Black")
            {
                pbPozadine.Image = OSS.Properties.Resources.black;
                pbPozadine.Refresh();
            }
            if (listBoxDP.SelectedItem.ToString() == "Solid Red")
            {
                pbPozadine.Image = OSS.Properties.Resources.red;
                pbPozadine.Refresh();
            }
            if (listBoxDP.SelectedItem.ToString() == "Solid Blue")
            {
                pbPozadine.Image = OSS.Properties.Resources.blue;
                pbPozadine.Refresh();
            }
            if (listBoxDP.SelectedItem.ToString() == "Solid Orange")
            {
                pbPozadine.Image = OSS.Properties.Resources.orange;
                pbPozadine.Refresh();
            }
            if (listBoxDP.SelectedItem.ToString() == "Solid Purple")
            {
                pbPozadine.Image = OSS.Properties.Resources.purple;
                pbPozadine.Refresh();
            }
        }

        private void btndpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
