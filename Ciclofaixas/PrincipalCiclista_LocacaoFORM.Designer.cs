namespace Ciclofaixas
{
    partial class PrincipalCiclista_LocacaoFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalCiclista_LocacaoFORM));
            this.dtgLocacoes = new System.Windows.Forms.DataGridView();
            this.btnPesquisarPessoa = new System.Windows.Forms.Button();
            this.txtbPesquisaPessoa = new System.Windows.Forms.TextBox();
            this.btnRealizaLocacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLocacoes
            // 
            this.dtgLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLocacoes.Location = new System.Drawing.Point(12, 90);
            this.dtgLocacoes.Name = "dtgLocacoes";
            this.dtgLocacoes.Size = new System.Drawing.Size(396, 211);
            this.dtgLocacoes.TabIndex = 0;
            // 
            // btnPesquisarPessoa
            // 
            this.btnPesquisarPessoa.Location = new System.Drawing.Point(168, 61);
            this.btnPesquisarPessoa.Name = "btnPesquisarPessoa";
            this.btnPesquisarPessoa.Size = new System.Drawing.Size(240, 23);
            this.btnPesquisarPessoa.TabIndex = 1;
            this.btnPesquisarPessoa.Text = "Pesquisa";
            this.btnPesquisarPessoa.UseVisualStyleBackColor = true;
            this.btnPesquisarPessoa.Click += new System.EventHandler(this.btnPesquisarPessoa_Click);
            // 
            // txtbPesquisaPessoa
            // 
            this.txtbPesquisaPessoa.Location = new System.Drawing.Point(168, 40);
            this.txtbPesquisaPessoa.Name = "txtbPesquisaPessoa";
            this.txtbPesquisaPessoa.Size = new System.Drawing.Size(240, 20);
            this.txtbPesquisaPessoa.TabIndex = 2;
            // 
            // btnRealizaLocacao
            // 
            this.btnRealizaLocacao.Location = new System.Drawing.Point(12, 40);
            this.btnRealizaLocacao.Name = "btnRealizaLocacao";
            this.btnRealizaLocacao.Size = new System.Drawing.Size(114, 44);
            this.btnRealizaLocacao.TabIndex = 3;
            this.btnRealizaLocacao.Text = "Locar Bicicleta";
            this.btnRealizaLocacao.UseVisualStyleBackColor = true;
            this.btnRealizaLocacao.Click += new System.EventHandler(this.btnRealizaLocacao_Click);
            // 
            // PrincipalCiclista_LocacaoFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 308);
            this.Controls.Add(this.btnRealizaLocacao);
            this.Controls.Add(this.txtbPesquisaPessoa);
            this.Controls.Add(this.btnPesquisarPessoa);
            this.Controls.Add(this.dtgLocacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalCiclista_LocacaoFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação Bicicletas";
            this.Load += new System.EventHandler(this.PrincipalCiclista_LocacaoFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLocacoes;
        private System.Windows.Forms.Button btnPesquisarPessoa;
        private System.Windows.Forms.TextBox txtbPesquisaPessoa;
        private System.Windows.Forms.Button btnRealizaLocacao;
    }
}