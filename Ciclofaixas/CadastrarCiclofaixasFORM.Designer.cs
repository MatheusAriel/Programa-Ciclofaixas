namespace Ciclofaixas
{
    partial class CadastrarCiclofaixasFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCiclofaixasFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNomeCiclofaixa = new System.Windows.Forms.TextBox();
            this.txtbCEPInicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCEPFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTamanho = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lclCiclofaixas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Ciclofaixa:";
            // 
            // txtbNomeCiclofaixa
            // 
            this.txtbNomeCiclofaixa.Location = new System.Drawing.Point(11, 55);
            this.txtbNomeCiclofaixa.Name = "txtbNomeCiclofaixa";
            this.txtbNomeCiclofaixa.Size = new System.Drawing.Size(259, 20);
            this.txtbNomeCiclofaixa.TabIndex = 1;
            this.txtbNomeCiclofaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNomeCiclofaixa_KeyPress);
            // 
            // txtbCEPInicial
            // 
            this.txtbCEPInicial.Location = new System.Drawing.Point(12, 101);
            this.txtbCEPInicial.Mask = "00000-000";
            this.txtbCEPInicial.Name = "txtbCEPInicial";
            this.txtbCEPInicial.Size = new System.Drawing.Size(58, 20);
            this.txtbCEPInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP Final:";
            // 
            // txtbCEPFinal
            // 
            this.txtbCEPFinal.Location = new System.Drawing.Point(11, 153);
            this.txtbCEPFinal.Mask = "00000-000";
            this.txtbCEPFinal.Name = "txtbCEPFinal";
            this.txtbCEPFinal.Size = new System.Drawing.Size(58, 20);
            this.txtbCEPFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamanho:";
            // 
            // txtbTamanho
            // 
            this.txtbTamanho.Location = new System.Drawing.Point(103, 100);
            this.txtbTamanho.Name = "txtbTamanho";
            this.txtbTamanho.Size = new System.Drawing.Size(167, 20);
            this.txtbTamanho.TabIndex = 7;
            this.txtbTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbTamanho_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(103, 137);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(167, 43);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lclCiclofaixas
            // 
            this.lclCiclofaixas.AutoSize = true;
            this.lclCiclofaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCiclofaixas.Location = new System.Drawing.Point(25, 9);
            this.lclCiclofaixas.Name = "lclCiclofaixas";
            this.lclCiclofaixas.Size = new System.Drawing.Size(240, 25);
            this.lclCiclofaixas.TabIndex = 9;
            this.lclCiclofaixas.Text = "Cadastro de Ciclofaixas";
            // 
            // CadastrarCiclofaixasFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 184);
            this.Controls.Add(this.lclCiclofaixas);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtbTamanho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbCEPFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbCEPInicial);
            this.Controls.Add(this.txtbNomeCiclofaixa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarCiclofaixasFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciclofaixas";
            this.Load += new System.EventHandler(this.CadastrarCiclofaixasFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNomeCiclofaixa;
        private System.Windows.Forms.MaskedTextBox txtbCEPInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtbCEPFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbTamanho;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lclCiclofaixas;
    }
}