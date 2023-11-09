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
    public partial class frmex11do : Form
    {
        public frmex11do()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, r, i;

            num = Convert.ToDouble(txtnumero.Text);
            i = 1;

            do
            {
                r = i * num;
                if (i == 1)
                {
                    lblre.Text = "A tabuada de 1 a 10 respectivamente do numero " + num + " é: " + r;
                }
                else if (i > 1 && i < 10)
                {
                    lblre.Text += ", " + r;
                }
                else
                {
                    lblre.Text += "," + r + ".";
                }
                i++;
                lblre.Visible = true;

            } while (i < 11);
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
