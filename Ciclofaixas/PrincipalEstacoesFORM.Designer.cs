namespace Ciclofaixas
{
    partial class PrincipalEstacoesFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalEstacoesFORM));
            this.dtgEstacoes = new System.Windows.Forms.DataGridView();
            this.btnCadastrarEstacoes = new System.Windows.Forms.Button();
            this.btnEditarEstacao = new System.Windows.Forms.Button();
            this.btnRemoverEstacao = new System.Windows.Forms.Button();
            this.txtbPesquisaEstacao = new System.Windows.Forms.TextBox();
            this.btnPesquisaEstacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEstacoes
            // 
            this.dtgEstacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstacoes.Location = new System.Drawing.Point(12, 93);
            this.dtgEstacoes.Name = "dtgEstacoes";
            this.dtgEstacoes.ReadOnly = true;
            this.dtgEstacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstacoes.Size = new System.Drawing.Size(467, 179);
            this.dtgEstacoes.TabIndex = 0;
            // 
            // btnCadastrarEstacoes
            // 
            this.btnCadastrarEstacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstacoes.Location = new System.Drawing.Point(12, 278);
            this.btnCadastrarEstacoes.Name = "btnCadastrarEstacoes";
            this.btnCadastrarEstacoes.Size = new System.Drawing.Size(467, 48);
            this.btnCadastrarEstacoes.TabIndex = 1;
            this.btnCadastrarEstacoes.Text = "Cadastro de Estações";
            this.btnCadastrarEstacoes.UseVisualStyleBackColor = true;
            this.btnCadastrarEstacoes.Click += new System.EventHandler(this.btnCadastrarEstacoes_Click);
            // 
            // btnEditarEstacao
            // 
            this.btnEditarEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEstacao.Location = new System.Drawing.Point(12, 38);
            this.btnEditarEstacao.Name = "btnEditarEstacao";
            this.btnEditarEstacao.Size = new System.Drawing.Size(108, 49);
            this.btnEditarEstacao.TabIndex = 2;
            this.btnEditarEstacao.Text = "Editar";
            this.btnEditarEstacao.UseVisualStyleBackColor = true;
            this.btnEditarEstacao.Click += new System.EventHandler(this.btnEditarEstacao_Click);
            // 
            // btnRemoverEstacao
            // 
            this.btnRemoverEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverEstacao.Location = new System.Drawing.Point(148, 38);
            this.btnRemoverEstacao.Name = "btnRemoverEstacao";
            this.btnRemoverEstacao.Size = new System.Drawing.Size(108, 49);
            this.btnRemoverEstacao.TabIndex = 3;
            this.btnRemoverEstacao.Text = "Remover";
            this.btnRemoverEstacao.UseVisualStyleBackColor = true;
            this.btnRemoverEstacao.Click += new System.EventHandler(this.btnRemoverEstacao_Click);
            // 
            // txtbPesquisaEstacao
            // 
            this.txtbPesquisaEstacao.Location = new System.Drawing.Point(308, 38);
            this.txtbPesquisaEstacao.Name = "txtbPesquisaEstacao";
            this.txtbPesquisaEstacao.Size = new System.Drawing.Size(171, 20);
            this.txtbPesquisaEstacao.TabIndex = 4;
            // 
            // btnPesquisaEstacao
            // 
            this.btnPesquisaEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaEstacao.Location = new System.Drawing.Point(308, 64);
            this.btnPesquisaEstacao.Name = "btnPesquisaEstacao";
            this.btnPesquisaEstacao.Size = new System.Drawing.Size(171, 23);
            this.btnPesquisaEstacao.TabIndex = 5;
            this.btnPesquisaEstacao.Text = "Pesquisar";
            this.btnPesquisaEstacao.UseVisualStyleBackColor = true;
            this.btnPesquisaEstacao.Click += new System.EventHandler(this.btnPesquisaEstacao_Click);
            // 
            // PrincipalEstacoesFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 335);
            this.Controls.Add(this.btnPesquisaEstacao);
            this.Controls.Add(this.txtbPesquisaEstacao);
            this.Controls.Add(this.btnRemoverEstacao);
            this.Controls.Add(this.btnEditarEstacao);
            this.Controls.Add(this.btnCadastrarEstacoes);
            this.Controls.Add(this.dtgEstacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalEstacoesFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalEstacoesFORM";
            this.Load += new System.EventHandler(this.PrincipalEstacoesFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEstacoes;
        private System.Windows.Forms.Button btnCadastrarEstacoes;
        private System.Windows.Forms.Button btnEditarEstacao;
        private System.Windows.Forms.Button btnRemoverEstacao;
        private System.Windows.Forms.TextBox txtbPesquisaEstacao;
        private System.Windows.Forms.Button btnPesquisaEstacao;
    }
}