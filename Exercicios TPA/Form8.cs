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
    public partial class frmex12for : Form
    {
        public frmex12for()
        {
            InitializeComponent();
        }

        private void btnclacular_Click(object sender, EventArgs e)
        {
            double i, r;

            r = Convert.ToDouble(textBox1.Text);
            lblresult.Text = "Esta temperatura em F° é igual a: ";
            lblresult.Visible = true;
            for(i = (r * 1.8) + 32; i < 101; i++)
            {
                r = (i - 32) * 5 / 9;
                lblresult.Text += " " + i + "F°";
                i += 9;
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            lblresult.Visible = false;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }
    }
}
