namespace Ciclofaixas
{
    partial class CadastrarAtracoesFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAtracoesFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbHoraAbertura = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbHoraFechamento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtbNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnMuseu = new System.Windows.Forms.RadioButton();
            this.rbtnRestaurante = new System.Windows.Forms.RadioButton();
            this.rbtnParque = new System.Windows.Forms.RadioButton();
            this.lblPrecoEntradaParque = new System.Windows.Forms.Label();
            this.txtbPrecoEntradaParque = new System.Windows.Forms.MaskedTextBox();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblTiporestaurante = new System.Windows.Forms.Label();
            this.txtbTipoRestaurante = new System.Windows.Forms.TextBox();
            this.lblPrecoEntradaMuseu = new System.Windows.Forms.Label();
            this.lblTipoMuseu = new System.Windows.Forms.Label();
            this.txtbPrecoEntradaMuseu = new System.Windows.Forms.MaskedTextBox();
            this.lblRSMuseu = new System.Windows.Forms.Label();
            this.txtbTipoMuseu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarCiclofaixa = new System.Windows.Forms.Button();
            this.btnAtualizarListaCiclofaixas = new System.Windows.Forms.Button();
            this.cmbNomeCiclofaixas = new System.Windows.Forms.ComboBox();
            this.dtgCiclofaixas = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblAtracoes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiclofaixas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(11, 65);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(223, 20);
            this.txtbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora de Abertura:";
            // 
            // txtbHoraAbertura
            // 
            this.txtbHoraAbertura.Location = new System.Drawing.Point(12, 128);
            this.txtbHoraAbertura.Mask = "00:00";
            this.txtbHoraAbertura.Name = "txtbHoraAbertura";
            this.txtbHoraAbertura.Size = new System.Drawing.Size(34, 20);
            this.txtbHoraAbertura.TabIndex = 3;
            this.txtbHoraAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora de Fechamento:";
            // 
            // txtbHoraFechamento
            // 
            this.txtbHoraFechamento.Location = new System.Drawing.Point(11, 191);
            this.txtbHoraFechamento.Mask = "00:00";
            this.txtbHoraFechamento.Name = "txtbHoraFechamento";
            this.txtbHoraFechamento.Size = new System.Drawing.Size(35, 20);
            this.txtbHoraFechamento.TabIndex = 5;
            this.txtbHoraFechamento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // txtbTelefone
            // 
            this.txtbTelefone.Location = new System.Drawing.Point(11, 255);
            this.txtbTelefone.Mask = "(00)00000-0000";
            this.txtbTelefone.Name = "txtbTelefone";
            this.txtbTelefone.Size = new System.Drawing.Size(81, 20);
            this.txtbTelefone.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbCEP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbBairro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtbNumero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbRua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(283, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço:";
            // 
            // txtbCEP
            // 
            this.txtbCEP.Location = new System.Drawing.Point(303, 89);
            this.txtbCEP.Mask = "00000-000";
            this.txtbCEP.Name = "txtbCEP";
            this.txtbCEP.Size = new System.Drawing.Size(61, 20);
            this.txtbCEP.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "CEP:";
            // 
            // txtbBairro
            // 
            this.txtbBairro.Location = new System.Drawing.Point(10, 89);
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(265, 20);
            this.txtbBairro.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bairro:";
            // 
            // TxtbNumero
            // 
            this.TxtbNumero.Location = new System.Drawing.Point(303, 32);
            this.TxtbNumero.Name = "TxtbNumero";
            this.TxtbNumero.Size = new System.Drawing.Size(99, 20);
            this.TxtbNumero.TabIndex = 3;
            this.TxtbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbNumero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número";
            // 
            // txtbRua
            // 
            this.txtbRua.Location = new System.Drawing.Point(10, 33);
            this.txtbRua.Name = "txtbRua";
            this.txtbRua.Size = new System.Drawing.Size(265, 20);
            this.txtbRua.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMuseu);
            this.groupBox2.Controls.Add(this.rbtnRestaurante);
            this.groupBox2.Controls.Add(this.rbtnParque);
            this.groupBox2.Location = new System.Drawing.Point(11, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 43);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo:";
            // 
            // rbtnMuseu
            // 
            this.rbtnMuseu.AutoSize = true;
            this.rbtnMuseu.Location = new System.Drawing.Point(160, 19);
            this.rbtnMuseu.Name = "rbtnMuseu";
            this.rbtnMuseu.Size = new System.Drawing.Size(57, 17);
            this.rbtnMuseu.TabIndex = 2;
            this.rbtnMuseu.TabStop = true;
            this.rbtnMuseu.Text = "Museu";
            this.rbtnMuseu.UseVisualStyleBackColor = true;
            this.rbtnMuseu.CheckedChanged += new System.EventHandler(this.rbtnMuseu_CheckedChanged);
            // 
            // rbtnRestaurante
            // 
            this.rbtnRestaurante.AutoSize = true;
            this.rbtnRestaurante.Location = new System.Drawing.Point(71, 19);
            this.rbtnRestaurante.Name = "rbtnRestaurante";
            this.rbtnRestaurante.Size = new System.Drawing.Size(83, 17);
            this.rbtnRestaurante.TabIndex = 1;
            this.rbtnRestaurante.TabStop = true;
            this.rbtnRestaurante.Text = "Restaurante";
            this.rbtnRestaurante.UseVisualStyleBackColor = true;
            this.rbtnRestaurante.CheckedChanged += new System.EventHandler(this.rbtnRestaurante_CheckedChanged);
            // 
            // rbtnParque
            // 
            this.rbtnParque.AutoSize = true;
            this.rbtnParque.Location = new System.Drawing.Point(6, 19);
            this.rbtnParque.Name = "rbtnParque";
            this.rbtnParque.Size = new System.Drawing.Size(59, 17);
            this.rbtnParque.TabIndex = 0;
            this.rbtnParque.TabStop = true;
            this.rbtnParque.Text = "Parque";
            this.rbtnParque.UseVisualStyleBackColor = true;
            this.rbtnParque.CheckedChanged += new System.EventHandler(this.rbtnParque_CheckedChanged);
            // 
            // lblPrecoEntradaParque
            // 
            this.lblPrecoEntradaParque.AutoSize = true;
            this.lblPrecoEntradaParque.Location = new System.Drawing.Point(28, 375);
            this.lblPrecoEntradaParque.Name = "lblPrecoEntradaParque";
            this.lblPrecoEntradaParque.Size = new System.Drawing.Size(90, 13);
            this.lblPrecoEntradaParque.TabIndex = 10;
            this.lblPrecoEntradaParque.Text = "Preço de Entrada";
            // 
            // txtbPrecoEntradaParque
            // 
            this.txtbPrecoEntradaParque.Location = new System.Drawing.Point(31, 391);
            this.txtbPrecoEntradaParque.Mask = "00,00";
            this.txtbPrecoEntradaParque.Name = "txtbPrecoEntradaParque";
            this.txtbPrecoEntradaParque.Size = new System.Drawing.Size(32, 20);
            this.txtbPrecoEntradaParque.TabIndex = 11;
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(4, 394);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(21, 13);
            this.lblRS.TabIndex = 12;
            this.lblRS.Text = "R$";
            // 
            // lblTiporestaurante
            // 
            this.lblTiporestaurante.AutoSize = true;
            this.lblTiporestaurante.Location = new System.Drawing.Point(32, 375);
            this.lblTiporestaurante.Name = "lblTiporestaurante";
            this.lblTiporestaurante.Size = new System.Drawing.Size(31, 13);
            this.lblTiporestaurante.TabIndex = 13;
            this.lblTiporestaurante.Text = "Tipo:";
            // 
            // txtbTipoRestaurante
            // 
            this.txtbTipoRestaurante.Location = new System.Drawing.Point(31, 391);
            this.txtbTipoRestaurante.Name = "txtbTipoRestaurante";
            this.txtbTipoRestaurante.Size = new System.Drawing.Size(133, 20);
            this.txtbTipoRestaurante.TabIndex = 14;
            this.txtbTipoRestaurante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbTipoRestaurante_KeyPress);
            // 
            // lblPrecoEntradaMuseu
            // 
            this.lblPrecoEntradaMuseu.AutoSize = true;
            this.lblPrecoEntradaMuseu.Location = new System.Drawing.Point(31, 375);
            this.lblPrecoEntradaMuseu.Name = "lblPrecoEntradaMuseu";
            this.lblPrecoEntradaMuseu.Size = new System.Drawing.Size(90, 13);
            this.lblPrecoEntradaMuseu.TabIndex = 15;
            this.lblPrecoEntradaMuseu.Text = "Preço de Entrada";
            // 
            // lblTipoMuseu
            // 
            this.lblTipoMuseu.AutoSize = true;
            this.lblTipoMuseu.Location = new System.Drawing.Point(32, 424);
            this.lblTipoMuseu.Name = "lblTipoMuseu";
            this.lblTipoMuseu.Size = new System.Drawing.Size(31, 13);
            this.lblTipoMuseu.TabIndex = 16;
            this.lblTipoMuseu.Text = "Tipo:";
            // 
            // txtbPrecoEntradaMuseu
            // 
            this.txtbPrecoEntradaMuseu.Location = new System.Drawing.Point(31, 391);
            this.txtbPrecoEntradaMuseu.Mask = "00,00";
            this.txtbPrecoEntradaMuseu.Name = "txtbPrecoEntradaMuseu";
            this.txtbPrecoEntradaMuseu.Size = new System.Drawing.Size(32, 20);
            this.txtbPrecoEntradaMuseu.TabIndex = 17;
            // 
            // lblRSMuseu
            // 
            this.lblRSMuseu.AutoSize = true;
            this.lblRSMuseu.Location = new System.Drawing.Point(4, 394);
            this.lblRSMuseu.Name = "lblRSMuseu";
            this.lblRSMuseu.Size = new System.Drawing.Size(21, 13);
            this.lblRSMuseu.TabIndex = 18;
            this.lblRSMuseu.Text = "R$";
            // 
            // txtbTipoMuseu
            // 
            this.txtbTipoMuseu.Location = new System.Drawing.Point(31, 441);
            this.txtbTipoMuseu.Name = "txtbTipoMuseu";
            this.txtbTipoMuseu.Size = new System.Drawing.Size(133, 20);
            this.txtbTipoMuseu.TabIndex = 19;
            this.txtbTipoMuseu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbTipoMuseu_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCadastrarCiclofaixa);
            this.groupBox3.Controls.Add(this.btnAtualizarListaCiclofaixas);
            this.groupBox3.Controls.Add(this.cmbNomeCiclofaixas);
            this.groupBox3.Controls.Add(this.dtgCiclofaixas);
            this.groupBox3.Location = new System.Drawing.Point(240, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 295);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciclofaixa";
            // 
            // btnCadastrarCiclofaixa
            // 
            this.btnCadastrarCiclofaixa.Location = new System.Drawing.Point(287, 261);
            this.btnCadastrarCiclofaixa.Name = "btnCadastrarCiclofaixa";
            this.btnCadastrarCiclofaixa.Size = new System.Drawing.Size(158, 23);
            this.btnCadastrarCiclofaixa.TabIndex = 3;
            this.btnCadastrarCiclofaixa.Text = "Cadastrar Nova Ciclofaixa";
            this.btnCadastrarCiclofaixa.UseVisualStyleBackColor = true;
            this.btnCadastrarCiclofaixa.Click += new System.EventHandler(this.btnCadastrarCiclofaixa_Click);
            // 
            // btnAtualizarListaCiclofaixas
            // 
            this.btnAtualizarListaCiclofaixas.Location = new System.Drawing.Point(6, 262);
            this.btnAtualizarListaCiclofaixas.Name = "btnAtualizarListaCiclofaixas";
            this.btnAtualizarListaCiclofaixas.Size = new System.Drawing.Size(146, 23);
            this.btnAtualizarListaCiclofaixas.TabIndex = 2;
            this.btnAtualizarListaCiclofaixas.Text = "Atualizar Ciclofaixas";
            this.btnAtualizarListaCiclofaixas.UseVisualStyleBackColor = true;
            this.btnAtualizarListaCiclofaixas.Click += new System.EventHandler(this.btnAtualizarListaCiclofaixas_Click);
            // 
            // cmbNomeCiclofaixas
            // 
            this.cmbNomeCiclofaixas.FormattingEnabled = true;
            this.cmbNomeCiclofaixas.Location = new System.Drawing.Point(6, 20);
            this.cmbNomeCiclofaixas.Name = "cmbNomeCiclofaixas";
            this.cmbNomeCiclofaixas.Size = new System.Drawing.Size(439, 21);
            this.cmbNomeCiclofaixas.TabIndex = 1;
            // 
            // dtgCiclofaixas
            // 
            this.dtgCiclofaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCiclofaixas.Location = new System.Drawing.Point(6, 60);
            this.dtgCiclofaixas.Name = "dtgCiclofaixas";
            this.dtgCiclofaixas.Size = new System.Drawing.Size(439, 196);
            this.dtgCiclofaixas.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(114, 98);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 60);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblAtracoes
            // 
            this.lblAtracoes.AutoSize = true;
            this.lblAtracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtracoes.Location = new System.Drawing.Point(191, 9);
            this.lblAtracoes.Name = "lblAtracoes";
            this.lblAtracoes.Size = new System.Drawing.Size(352, 39);
            this.lblAtracoes.TabIndex = 22;
            this.lblAtracoes.Text = "Cadastro de Atrações";
            // 
            // CadastrarAtracoesFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 486);
            this.Controls.Add(this.lblAtracoes);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtbTipoMuseu);
            this.Controls.Add(this.lblRSMuseu);
            this.Controls.Add(this.txtbPrecoEntradaMuseu);
            this.Controls.Add(this.lblTipoMuseu);
            this.Controls.Add(this.lblPrecoEntradaMuseu);
            this.Controls.Add(this.txtbTipoRestaurante);
            this.Controls.Add(this.lblTiporestaurante);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.txtbPrecoEntradaParque);
            this.Controls.Add(this.lblPrecoEntradaParque);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbHoraFechamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbHoraAbertura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarAtracoesFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atrações";
            this.Load += new System.EventHandler(this.CadastrarAtracoesFORM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiclofaixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtbHoraAbertura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtbHoraFechamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtbTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtbCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtbNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnMuseu;
        private System.Windows.Forms.RadioButton rbtnRestaurante;
        private System.Windows.Forms.RadioButton rbtnParque;
        private System.Windows.Forms.Label lblPrecoEntradaParque;
        private System.Windows.Forms.MaskedTextBox txtbPrecoEntradaParque;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblTiporestaurante;
        private System.Windows.Forms.TextBox txtbTipoRestaurante;
        private System.Windows.Forms.Label lblPrecoEntradaMuseu;
        private System.Windows.Forms.Label lblTipoMuseu;
        private System.Windows.Forms.MaskedTextBox txtbPrecoEntradaMuseu;
        private System.Windows.Forms.Label lblRSMuseu;
        private System.Windows.Forms.TextBox txtbTipoMuseu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCadastrarCiclofaixa;
        private System.Windows.Forms.Button btnAtualizarListaCiclofaixas;
        private System.Windows.Forms.ComboBox cmbNomeCiclofaixas;
        private System.Windows.Forms.DataGridView dtgCiclofaixas;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblAtracoes;
    }
}