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
    public partial class FormCal : Form
    {
        Double vrednost = 0;
        string operacija = "";
        bool promenaOperacije = false;

        public FormCal()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((tbRezultat.Text == "0")||(promenaOperacije))
            {
                tbRezultat.Clear();
            }
            promenaOperacije = false;
            Button b = (Button)sender;
            tbRezultat.Text = tbRezultat.Text + b.Text;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbRezultat.Text = "0";
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacija = b.Text;
            vrednost = Double.Parse(tbRezultat.Text);
            promenaOperacije = true;

            lbRacun.Text = vrednost + " " + operacija;
        }

        private void btnJednako_Click(object sender, EventArgs e)
        {
            
            lbRacun.Text = "";
            switch(operacija)
            {
                case "+":
                    tbRezultat.Text = (vrednost + Double.Parse(tbRezultat.Text)).ToString();
                    break;
                case "-":
                    tbRezultat.Text = (vrednost - Double.Parse(tbRezultat.Text)).ToString();
                    break;
                case "*":
                    tbRezultat.Text = (vrednost * Double.Parse(tbRezultat.Text)).ToString();
                    break;
                case "/":
                    tbRezultat.Text = (vrednost / Double.Parse(tbRezultat.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbRezultat.Text = "0";
            vrednost = 0;
        }
    }
}
