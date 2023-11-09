﻿using System;
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
    public partial class frmex12while : Form
    {
        public frmex12while()
        {
            InitializeComponent();
        }

        private void btnclacular_Click(object sender, EventArgs e)
        {
            double i, r;

            r = Convert.ToDouble(textBox2.Text);
            i = (r * 1.8) + 32;
            lblresult.Text = "Esta temperatura em F° é igual a: " ;
            lblresult.Visible = true;
            while (i <= 100)
            {
                r = (i - 32) * 5 / 9;
                lblresult.Text += " " + i + "F°";
                i += 10;
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Focus();
            lblresult.Visible = false;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double i, r;

            r = Convert.ToDouble(textBox2.Text);
            i = (r * 1.8) + 32;
            lblresult.Text = "Esta temperatura em F° é igual a: ";
            lblresult.Visible = true;
            while (i <= 100) 
            {
                r = (i - 32) * 5 / 9;
                lblresult.Text += " " + i + "F°";
                i += 10;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Focus();
            lblresult.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }
    }
}
