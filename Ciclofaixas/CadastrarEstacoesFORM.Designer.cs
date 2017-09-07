namespace Ciclofaixas
{
    partial class CadastrarEstacoesFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEstacoesFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarEstacoes = new System.Windows.Forms.Button();
            this.lblEstacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(16, 68);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(234, 20);
            this.txtbNome.TabIndex = 1;
            this.txtbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // txtbTelefone
            // 
            this.txtbTelefone.Location = new System.Drawing.Point(16, 112);
            this.txtbTelefone.Mask = "(00)0000-0000";
            this.txtbTelefone.Name = "txtbTelefone";
            this.txtbTelefone.Size = new System.Drawing.Size(79, 20);
            this.txtbTelefone.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbCEP);
            this.groupBox1.Controls.Add(this.txtbBairro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbRua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtbCEP
            // 
            this.txtbCEP.Location = new System.Drawing.Point(7, 162);
            this.txtbCEP.Mask = "00000-000";
            this.txtbCEP.Name = "txtbCEP";
            this.txtbCEP.Size = new System.Drawing.Size(62, 20);
            this.txtbCEP.TabIndex = 10;
            // 
            // txtbBairro
            // 
            this.txtbBairro.Location = new System.Drawing.Point(6, 122);
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(231, 20);
            this.txtbBairro.TabIndex = 5;
            this.txtbBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbBairro_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bairro:";
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(6, 83);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(63, 20);
            this.txtbNumero.TabIndex = 7;
            this.txtbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero:";
            // 
            // txtbRua
            // 
            this.txtbRua.Location = new System.Drawing.Point(6, 41);
            this.txtbRua.Name = "txtbRua";
            this.txtbRua.Size = new System.Drawing.Size(231, 20);
            this.txtbRua.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rua:";
            // 
            // btnCadastrarEstacoes
            // 
            this.btnCadastrarEstacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstacoes.Location = new System.Drawing.Point(101, 95);
            this.btnCadastrarEstacoes.Name = "btnCadastrarEstacoes";
            this.btnCadastrarEstacoes.Size = new System.Drawing.Size(149, 60);
            this.btnCadastrarEstacoes.TabIndex = 5;
            this.btnCadastrarEstacoes.Text = "Cadastrar";
            this.btnCadastrarEstacoes.UseVisualStyleBackColor = true;
            this.btnCadastrarEstacoes.Click += new System.EventHandler(this.btnCadastrarEstacoes_Click);
            // 
            // lblEstacao
            // 
            this.lblEstacao.AutoSize = true;
            this.lblEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacao.Location = new System.Drawing.Point(12, 9);
            this.lblEstacao.Name = "lblEstacao";
            this.lblEstacao.Size = new System.Drawing.Size(249, 29);
            this.lblEstacao.TabIndex = 6;
            this.lblEstacao.Text = "Cadastro de Estações";
            // 
            // CadastrarEstacoesFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 360);
            this.Controls.Add(this.lblEstacao);
            this.Controls.Add(this.btnCadastrarEstacoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarEstacoesFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estações";
            this.Load += new System.EventHandler(this.CadastrarEstacoesFORM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtbTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarEstacoes;
        private System.Windows.Forms.MaskedTextBox txtbCEP;
        private System.Windows.Forms.Label lblEstacao;
    }
}