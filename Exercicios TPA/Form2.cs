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
    public partial class frmex11 : Form
    {
        public frmex11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, r, i;

            num = Convert.ToDouble(txtnumero.Text);
            i = 1;

            while (i <= 10)
            {
                r = i * num;
                if(i == 1)
                {
                    lblre.Text = "A tabuada de 1 a 10 respectivamente do numero " + num + " é: " + r;
                }else if(i>1 && i < 10)
                {
                    lblre.Text += ", " + r;
                }
                else
                {
                    lblre.Text += "," + r + ".";
                }
                i++;
                lblre.Visible = true;
                
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtnumero.Focus();

            lblre.Visible = false;

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal pri = new frmprincipal();
            pri.Show();
        }
    }
}
