using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_TPA
{
    public partial class frmex13while : Form
    {
        public frmex13while()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, c, ac, at, i, cont;
            string n;
            at = 0;
            i = 1;
            l = Convert.ToDouble(txtl.Text);
            c = Convert.ToDouble(txtc.Text);
            n = txtn.Text;
            cont = Convert.ToDouble(lblcontinuar.Text);

            while (i == 1)
            {
                ac = l * c;
                at += ac;
                lblresult.Text = "A area do comodo " + n + "é igual a: " + ac + "m²";
                lblresult.Visible = true;
                txtcontinuar.Visible = true;
                lblcontinuar.Visible = true;
                if(cont == 1)
                {
                    txtc.Clear();
                    txtl.Clear();
                    txtn.Clear();
                    lblcontinuar.Clear();
                    txtl.Focus();
                    i = 1;
                }
                else
                {
                    i = 2;
                }
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
        }
    }
}
