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
    public partial class frmex11for : Form
    {
        public frmex11for()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, r, i;

            num = Convert.ToDouble(txtnumero.Text);
            i = 1;

            for(i=1; i<11; i++)
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
