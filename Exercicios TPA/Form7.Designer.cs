﻿
namespace Exercicios_TPA
{
    partial class frmex12do
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.lbldigite = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnclacular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(85, 130);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 11;
            this.lblresult.Text = "label2";
            this.lblresult.Visible = false;
            // 
            // lbldigite
            // 
            this.lbldigite.AutoSize = true;
            this.lbldigite.Location = new System.Drawing.Point(94, 43);
            this.lbldigite.Name = "lbldigite";
            this.lbldigite.Size = new System.Drawing.Size(150, 13);
            this.lbldigite.TabIndex = 10;
            this.lbldigite.Text = "Digite uma temperatura em C°:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(198, 344);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(320, 344);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnclacular
            // 
            this.btnclacular.Location = new System.Drawing.Point(82, 344);
            this.btnclacular.Name = "btnclacular";
            this.btnclacular.Size = new System.Drawing.Size(75, 23);
            this.btnclacular.TabIndex = 7;
            this.btnclacular.Text = "Calcular";
            this.btnclacular.UseVisualStyleBackColor = true;
            this.btnclacular.Click += new System.EventHandler(this.btnclacular_Click);
            // 
            // frmex12do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbldigite);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnclacular);
            this.Name = "frmex12do";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 12 Do";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lbldigite;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnclacular;
    }
}