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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void exercício11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex11 ex11 = new frmex11();
            ex11.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void whileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex13w ex13w = new frmex13w();
            ex13w.Show();
        }

        private void doToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmex11do ex11do = new frmex11do();
            ex11do.Show();
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex11for ex11for = new frmex11for();
            ex11for.Show();
        }

        private void whileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex12while ex12w = new frmex12while();
            ex12w.Show();
        }

        private void doToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex12do ex12do = new frmex12do();
            ex12do.Show();
        }

        private void forToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex12for ex12for = new frmex12for();
            ex12for.Show();
        }

        private void exercício13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex13w ex13w = new frmex13w();
            ex13w.Show();
        }
    }
}
