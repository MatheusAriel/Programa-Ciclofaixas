namespace Ciclofaixas
{
    partial class CadastrarBicicletasFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarBicicletasFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbModelo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastraEstacoes = new System.Windows.Forms.Button();
            this.btnAtualizaEstacoes = new System.Windows.Forms.Button();
            this.dtgEstacoes = new System.Windows.Forms.DataGridView();
            this.cmbSelecionaEstacao = new System.Windows.Forms.ComboBox();
            this.btnCadastrarBicicletas = new System.Windows.Forms.Button();
            this.lblBicicletas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cor:";
            // 
            // txtbCor
            // 
            this.txtbCor.Location = new System.Drawing.Point(12, 92);
            this.txtbCor.Name = "txtbCor";
            this.txtbCor.Size = new System.Drawing.Size(100, 20);
            this.txtbCor.TabIndex = 1;
            this.txtbCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // txtbModelo
            // 
            this.txtbModelo.Location = new System.Drawing.Point(230, 92);
            this.txtbModelo.Name = "txtbModelo";
            this.txtbModelo.Size = new System.Drawing.Size(81, 20);
            this.txtbModelo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastraEstacoes);
            this.groupBox1.Controls.Add(this.btnAtualizaEstacoes);
            this.groupBox1.Controls.Add(this.dtgEstacoes);
            this.groupBox1.Controls.Add(this.cmbSelecionaEstacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estação";
            // 
            // btnCadastraEstacoes
            // 
            this.btnCadastraEstacoes.Location = new System.Drawing.Point(161, 252);
            this.btnCadastraEstacoes.Name = "btnCadastraEstacoes";
            this.btnCadastraEstacoes.Size = new System.Drawing.Size(129, 47);
            this.btnCadastraEstacoes.TabIndex = 3;
            this.btnCadastraEstacoes.Text = "Cadastra Nova Estação";
            this.btnCadastraEstacoes.UseVisualStyleBackColor = true;
            this.btnCadastraEstacoes.Click += new System.EventHandler(this.btnCadastraEstacoes_Click);
            // 
            // btnAtualizaEstacoes
            // 
            this.btnAtualizaEstacoes.Location = new System.Drawing.Point(7, 252);
            this.btnAtualizaEstacoes.Name = "btnAtualizaEstacoes";
            this.btnAtualizaEstacoes.Size = new System.Drawing.Size(129, 47);
            this.btnAtualizaEstacoes.TabIndex = 2;
            this.btnAtualizaEstacoes.Text = "Atualiza Estações";
            this.btnAtualizaEstacoes.UseVisualStyleBackColor = true;
            this.btnAtualizaEstacoes.Click += new System.EventHandler(this.btnAtualizaEstacoes_Click);
            // 
            // dtgEstacoes
            // 
            this.dtgEstacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstacoes.Location = new System.Drawing.Point(7, 81);
            this.dtgEstacoes.Name = "dtgEstacoes";
            this.dtgEstacoes.ReadOnly = true;
            this.dtgEstacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstacoes.Size = new System.Drawing.Size(283, 151);
            this.dtgEstacoes.TabIndex = 1;
            // 
            // cmbSelecionaEstacao
            // 
            this.cmbSelecionaEstacao.FormattingEnabled = true;
            this.cmbSelecionaEstacao.Location = new System.Drawing.Point(7, 23);
            this.cmbSelecionaEstacao.Name = "cmbSelecionaEstacao";
            this.cmbSelecionaEstacao.Size = new System.Drawing.Size(283, 21);
            this.cmbSelecionaEstacao.TabIndex = 0;
            // 
            // btnCadastrarBicicletas
            // 
            this.btnCadastrarBicicletas.Location = new System.Drawing.Point(118, 90);
            this.btnCadastrarBicicletas.Name = "btnCadastrarBicicletas";
            this.btnCadastrarBicicletas.Size = new System.Drawing.Size(106, 22);
            this.btnCadastrarBicicletas.TabIndex = 5;
            this.btnCadastrarBicicletas.Text = "Cadastrar";
            this.btnCadastrarBicicletas.UseVisualStyleBackColor = true;
            this.btnCadastrarBicicletas.Click += new System.EventHandler(this.btnCadastrarBicicletas_Click);
            // 
            // lblBicicletas
            // 
            this.lblBicicletas.AutoSize = true;
            this.lblBicicletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBicicletas.Location = new System.Drawing.Point(6, 9);
            this.lblBicicletas.Name = "lblBicicletas";
            this.lblBicicletas.Size = new System.Drawing.Size(306, 33);
            this.lblBicicletas.TabIndex = 6;
            this.lblBicicletas.Text = "Cadastro de Bicicletas";
            // 
            // CadastrarBicicletasFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 442);
            this.Controls.Add(this.lblBicicletas);
            this.Controls.Add(this.btnCadastrarBicicletas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbCor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarBicicletasFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicicletas";
            this.Load += new System.EventHandler(this.CadastrarBicicletasFORM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSelecionaEstacao;
        private System.Windows.Forms.DataGridView dtgEstacoes;
        private System.Windows.Forms.Button btnCadastraEstacoes;
        private System.Windows.Forms.Button btnAtualizaEstacoes;
        private System.Windows.Forms.Button btnCadastrarBicicletas;
        private System.Windows.Forms.Label lblBicicletas;
    }
}