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
namespace Kviz
{
    public partial class FormKviz : Form
    {
        public FormKviz()
        {
            InitializeComponent();
        }

        //promenljive:
        int kpkbrojac = 0;
        int poeni = 0;
        int kpktimer = 100;



        //menja scene(panele)
        private void button1_Click(object sender, EventArgs e)
        { 
                panelmain.Visible = false;
                panelkpk.Visible = true;
        }
        //zatvara formu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // pokrece igru/ukljucuje kontrole i pokrece timer
        private void btnkpkstart_Click(object sender, EventArgs e)
        {
            
            lbkpkjedan.Visible = true;
            btnsledecikorak.Enabled = true;
            btnkpkprovera.Enabled = true;
            btnkpkstart.Visible = false;


            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);

       
            
        }
        // sledeci korak:
        private void btnsledecikorak_Click(object sender, EventArgs e)
        {
            kpkbrojac++;

            if (kpkbrojac == 1)
            {
                lbkpkdva.Visible = true;
            }
            if (kpkbrojac == 2)
            {
                lbkpktri.Visible = true;
            }
            if (kpkbrojac == 3)
            {
                lbkpkcetiri.Visible = true;
            }
            if (kpkbrojac == 4)
            {
                lbkpkpet.Visible = true;
                btnsledecikorak.Visible = false;
            }
            

        }
        //proverava da li je tacno resenje i po tome dodaje poene:
        private void btnkpkprovera_Click(object sender, EventArgs e)
        {

            switch(kpkbrojac)
            {
                case 0:
                    if (lbkpkjedan.Visible == true)
                    {
                        if (tbkpk.Text.Contains("datum"))
                        {
                            poeni = +25;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                   
                      else if (tbkpk.Text.Contains("Datum"))
                        {
                            poeni = +25;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                        else
                        { 
                             MessageBox.Show("Odgovor nije tacan");
                        }
                    }
                    break;
                case 1:
                    if (lbkpkdva.Visible == true)
                    {
                        if (tbkpk.Text.Contains("datum"))
                        {
                            poeni = +20;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                       else if (tbkpk.Text.Contains("Datum"))
                        {
                            poeni = +20;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Odgovor nije tacan");
                        }


                    }
                    break;
                case 2:
                    if (lbkpkdva.Visible == true)
                    {
                        if (tbkpk.Text.Contains("datum"))
                        {
                            poeni = +15;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                       else if (tbkpk.Text.Contains("Datum"))
                        {
                            poeni = +15;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Odgovor nije tacan");
                        }


                    }
                    break;
                case 3:
                    if (lbkpkdva.Visible == true)
                    {
                        if (tbkpk.Text.Contains("datum"))
                        {
                            poeni = +10;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                       else if (tbkpk.Text.Contains("Datum"))
                        {
                            poeni = +10;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Odgovor nije tacan");
                        }


                    }
                    break;
                case 4:
                    if (lbkpkdva.Visible == true)
                    {
                        if (tbkpk.Text.Contains("datum"))
                        {
                            poeni = +5;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }

                       else if (tbkpk.Text.Contains("Datum"))
                        {
                            poeni = +5;
                            lbpoeni.Text = poeni.ToString();
                            if (timer1.Enabled)
                            {
                                timer1.Stop();
                            }
                            MessageBox.Show("Odgovor je tacan,osvojeni broj poena:   " + poeni.ToString());
                            btnsled1.Visible = true;
                            btnkpkprovera.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Odgovor nije tacan");
                        }


                    }
                
                    break;
            }


         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kpktimer--;
            lbkpkvreme.Text = kpktimer.ToString();

            if (kpktimer <= 60)
            {
                lbkpkvreme.ForeColor = System.Drawing.Color.Yellow;
            }
            if (kpktimer <= 30)
            {
                lbkpkvreme.ForeColor = System.Drawing.Color.Red;
            }
            if(kpktimer == 00)
            {
                timer1.Stop();
                MessageBox.Show("Vreme je isteklo,osvojili ste 0 poena");
                btnsled1.Visible = true;
            }
        }
    }
}
