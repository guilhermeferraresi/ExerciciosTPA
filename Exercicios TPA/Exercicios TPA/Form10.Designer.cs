
namespace Exercicios_TPA
{
    partial class frmex13w
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.lblAreaTotal = new System.Windows.Forms.Label();
            this.lblAreaComodo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(624, 387);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 32);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(216, 387);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 32);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(60, 387);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 32);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(256, 174);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 18;
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(308, 135);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(100, 20);
            this.txtComprimento.TabIndex = 17;
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(265, 94);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(100, 20);
            this.txtLargura.TabIndex = 16;
            // 
            // lblAreaTotal
            // 
            this.lblAreaTotal.AutoSize = true;
            this.lblAreaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTotal.Location = new System.Drawing.Point(56, 278);
            this.lblAreaTotal.Name = "lblAreaTotal";
            this.lblAreaTotal.Size = new System.Drawing.Size(51, 20);
            this.lblAreaTotal.TabIndex = 15;
            this.lblAreaTotal.Text = "label5";
            this.lblAreaTotal.Visible = false;
            // 
            // lblAreaComodo
            // 
            this.lblAreaComodo.AutoSize = true;
            this.lblAreaComodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaComodo.Location = new System.Drawing.Point(56, 237);
            this.lblAreaComodo.Name = "lblAreaComodo";
            this.lblAreaComodo.Size = new System.Drawing.Size(51, 20);
            this.lblAreaComodo.TabIndex = 14;
            this.lblAreaComodo.Text = "label4";
            this.lblAreaComodo.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(56, 174);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(194, 20);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Digite o nome do cômodo:";
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprimento.Location = new System.Drawing.Point(56, 135);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(246, 20);
            this.lblComprimento.TabIndex = 12;
            this.lblComprimento.Text = "Digite o comprimento do cômodo:";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargura.Location = new System.Drawing.Point(56, 94);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(203, 20);
            this.lblLargura.TabIndex = 11;
            this.lblLargura.Text = "Digite a largura do cômodo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(276, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 24);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Calculador de area";
            // 
            // frmex13w
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.lblAreaTotal);
            this.Controls.Add(this.lblAreaComodo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblComprimento);
            this.Controls.Add(this.lblLargura);
            this.Name = "frmex13w";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercico 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label lblAreaTotal;
        private System.Windows.Forms.Label lblAreaComodo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblTitulo;
    }
}