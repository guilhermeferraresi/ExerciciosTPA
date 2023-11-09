
namespace Exercicios_TPA
{
    partial class frmex13while
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
            this.lbllargura = new System.Windows.Forms.Label();
            this.lblcomprimento = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtcontinuar = new System.Windows.Forms.Label();
            this.lblcontinuar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllargura
            // 
            this.lbllargura.AutoSize = true;
            this.lbllargura.Location = new System.Drawing.Point(74, 68);
            this.lbllargura.Name = "lbllargura";
            this.lbllargura.Size = new System.Drawing.Size(137, 13);
            this.lbllargura.TabIndex = 0;
            this.lbllargura.Text = "Digite a largura do cômodo:";
            // 
            // lblcomprimento
            // 
            this.lblcomprimento.AutoSize = true;
            this.lblcomprimento.Location = new System.Drawing.Point(74, 105);
            this.lblcomprimento.Name = "lblcomprimento";
            this.lblcomprimento.Size = new System.Drawing.Size(165, 13);
            this.lblcomprimento.TabIndex = 1;
            this.lblcomprimento.Text = "Digite o comprimento do comodo:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(74, 134);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(131, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Digite o nome do comodo:";
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(230, 61);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(100, 20);
            this.txtl.TabIndex = 3;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(211, 134);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 5;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(248, 98);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(77, 331);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(255, 340);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(401, 331);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(77, 261);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(75, 23);
            this.btncontinuar.TabIndex = 10;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Visible = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(194, 261);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnfinalizar.TabIndex = 11;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Visible = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(85, 184);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 12;
            this.lblresult.Text = "label1";
            this.lblresult.Visible = false;
            // 
            // txtcontinuar
            // 
            this.txtcontinuar.AutoSize = true;
            this.txtcontinuar.Location = new System.Drawing.Point(74, 231);
            this.txtcontinuar.Name = "txtcontinuar";
            this.txtcontinuar.Size = new System.Drawing.Size(203, 13);
            this.txtcontinuar.TabIndex = 13;
            this.txtcontinuar.Text = "Digite 1 para continuar ou 2 para finalizar:";
            // 
            // lblcontinuar
            // 
            this.lblcontinuar.Location = new System.Drawing.Point(303, 228);
            this.lblcontinuar.Name = "lblcontinuar";
            this.lblcontinuar.Size = new System.Drawing.Size(100, 20);
            this.lblcontinuar.TabIndex = 14;
            // 
            // frmex13while
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcontinuar);
            this.Controls.Add(this.txtcontinuar);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcomprimento);
            this.Controls.Add(this.lbllargura);
            this.Name = "frmex13while";
            this.Text = "Exercicio 13 While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllargura;
        private System.Windows.Forms.Label lblcomprimento;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label txtcontinuar;
        private System.Windows.Forms.TextBox lblcontinuar;
    }
}