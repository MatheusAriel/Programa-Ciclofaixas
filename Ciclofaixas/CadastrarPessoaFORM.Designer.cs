namespace Ciclofaixas
{
    partial class CadastrarPessoaFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPessoaFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbRua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnJuridica = new System.Windows.Forms.RadioButton();
            this.rbtnFisica = new System.Windows.Forms.RadioButton();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(12, 81);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(157, 20);
            this.txtbNome.TabIndex = 1;
            this.txtbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbCEP);
            this.groupBox1.Controls.Add(this.txtbBairro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtbEstado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbCidade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbNumero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbRua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // txtbCEP
            // 
            this.txtbCEP.Location = new System.Drawing.Point(304, 37);
            this.txtbCEP.Mask = "00000-000";
            this.txtbCEP.Name = "txtbCEP";
            this.txtbCEP.Size = new System.Drawing.Size(58, 20);
            this.txtbCEP.TabIndex = 12;
            // 
            // txtbBairro
            // 
            this.txtbBairro.Location = new System.Drawing.Point(262, 88);
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(100, 20);
            this.txtbBairro.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bairro:";
            // 
            // txtbEstado
            // 
            this.txtbEstado.Location = new System.Drawing.Point(201, 89);
            this.txtbEstado.MaxLength = 2;
            this.txtbEstado.Name = "txtbEstado";
            this.txtbEstado.Size = new System.Drawing.Size(42, 20);
            this.txtbEstado.TabIndex = 9;
            this.txtbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbEstado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CEP:";
            // 
            // txtbCidade
            // 
            this.txtbCidade.Location = new System.Drawing.Point(9, 89);
            this.txtbCidade.Name = "txtbCidade";
            this.txtbCidade.Size = new System.Drawing.Size(168, 20);
            this.txtbCidade.TabIndex = 5;
            this.txtbCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCidade_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cidade:";
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(232, 36);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(54, 20);
            this.txtbNumero.TabIndex = 3;
            this.txtbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumero_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Número:";
            // 
            // txtbRua
            // 
            this.txtbRua.Location = new System.Drawing.Point(7, 37);
            this.txtbRua.Name = "txtbRua";
            this.txtbRua.Size = new System.Drawing.Size(209, 20);
            this.txtbRua.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rua:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnJuridica);
            this.groupBox2.Controls.Add(this.rbtnFisica);
            this.groupBox2.Location = new System.Drawing.Point(201, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 44);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo:";
            // 
            // rbtnJuridica
            // 
            this.rbtnJuridica.AutoSize = true;
            this.rbtnJuridica.Location = new System.Drawing.Point(89, 19);
            this.rbtnJuridica.Name = "rbtnJuridica";
            this.rbtnJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbtnJuridica.TabIndex = 1;
            this.rbtnJuridica.TabStop = true;
            this.rbtnJuridica.Text = "Jurídica";
            this.rbtnJuridica.UseVisualStyleBackColor = true;
            this.rbtnJuridica.CheckedChanged += new System.EventHandler(this.rbtnJuridica_CheckedChanged);
            // 
            // rbtnFisica
            // 
            this.rbtnFisica.AutoSize = true;
            this.rbtnFisica.Location = new System.Drawing.Point(20, 19);
            this.rbtnFisica.Name = "rbtnFisica";
            this.rbtnFisica.Size = new System.Drawing.Size(54, 17);
            this.rbtnFisica.TabIndex = 0;
            this.rbtnFisica.TabStop = true;
            this.rbtnFisica.Text = "Física";
            this.rbtnFisica.UseVisualStyleBackColor = true;
            this.rbtnFisica.CheckedChanged += new System.EventHandler(this.rbtnFisica_CheckedChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(219, 117);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(219, 172);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(219, 225);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 12;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(219, 117);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 14;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 225);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(157, 36);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtbCPF
            // 
            this.txtbCPF.Location = new System.Drawing.Point(218, 133);
            this.txtbCPF.Mask = "000.000.000-00";
            this.txtbCPF.Name = "txtbCPF";
            this.txtbCPF.Size = new System.Drawing.Size(84, 20);
            this.txtbCPF.TabIndex = 17;
            // 
            // txtbCNPJ
            // 
            this.txtbCNPJ.Location = new System.Drawing.Point(218, 133);
            this.txtbCNPJ.Mask = "00.000.000/0000-00";
            this.txtbCNPJ.Name = "txtbCNPJ";
            this.txtbCNPJ.Size = new System.Drawing.Size(108, 20);
            this.txtbCNPJ.TabIndex = 18;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(13, 134);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(156, 20);
            this.txtbEmail.TabIndex = 3;
            // 
            // txtbTelefone
            // 
            this.txtbTelefone.Location = new System.Drawing.Point(13, 189);
            this.txtbTelefone.Mask = "(00)00000-0000 ";
            this.txtbTelefone.Name = "txtbTelefone";
            this.txtbTelefone.Size = new System.Drawing.Size(82, 20);
            this.txtbTelefone.TabIndex = 19;
            // 
            // txtbRG
            // 
            this.txtbRG.Location = new System.Drawing.Point(218, 188);
            this.txtbRG.Mask = "00.000.000-00";
            this.txtbRG.Name = "txtbRG";
            this.txtbRG.Size = new System.Drawing.Size(74, 20);
            this.txtbRG.TabIndex = 20;
            // 
            // txtbDataNasc
            // 
            this.txtbDataNasc.Location = new System.Drawing.Point(218, 241);
            this.txtbDataNasc.Mask = "aa/aa/aaaa";
            this.txtbDataNasc.Name = "txtbDataNasc";
            this.txtbDataNasc.Size = new System.Drawing.Size(74, 20);
            this.txtbDataNasc.TabIndex = 21;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.Location = new System.Drawing.Point(64, 9);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(274, 31);
            this.lblPessoa.TabIndex = 22;
            this.lblPessoa.Text = "Cadastro de Pessoas";
            // 
            // CadastrarPessoaFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 419);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.txtbDataNasc);
            this.Controls.Add(this.txtbRG);
            this.Controls.Add(this.txtbTelefone);
            this.Controls.Add(this.txtbCNPJ);
            this.Controls.Add(this.txtbCPF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarPessoaFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.Load += new System.EventHandler(this.CadastrarPessoaFORM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbRua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnJuridica;
        private System.Windows.Forms.RadioButton rbtnFisica;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtbCPF;
        private System.Windows.Forms.MaskedTextBox txtbCNPJ;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.MaskedTextBox txtbTelefone;
        private System.Windows.Forms.MaskedTextBox txtbCEP;
        private System.Windows.Forms.MaskedTextBox txtbRG;
        private System.Windows.Forms.MaskedTextBox txtbDataNasc;
        private System.Windows.Forms.Label lblPessoa;
    }
}