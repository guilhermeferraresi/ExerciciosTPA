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
    public partial class frmex13w : Form
    {
        double at;
        public frmex13w()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ac, l, c;
            string n;
            l = Convert.ToDouble(txtLargura.Text);
            c = Convert.ToDouble(txtComprimento.Text);
            n = txtNome.Text;
            ac = l * c;
            at += ac;
            lblAreaComodo.Text = "A área do(a) " + n + " é igual a: " + ac + "m².";
            lblAreaComodo.Visible = true;
            var result = MessageBox.Show("Deseja continuar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                txtComprimento.Clear();
                txtLargura.Clear();
                txtNome.Clear();
                lblAreaComodo.Visible = false;
                txtLargura.Focus();
            }
            else
            {
                lblAreaTotal.Text = "A área total é de: " + at + "m².";
                lblAreaTotal.Visible = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComprimento.Clear();
            txtLargura.Clear();
            txtNome.Clear();
            lblAreaComodo.Visible = false;
            lblAreaTotal.Visible = false;
            txtLargura.Focus();
            at = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }
    }
}
