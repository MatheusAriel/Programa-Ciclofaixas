namespace Ciclofaixas
{
    partial class PrincipalPessoasFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalPessoasFORM));
            this.dtgFisica = new System.Windows.Forms.DataGridView();
            this.btncadastrarPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoasFisica = new System.Windows.Forms.Button();
            this.btnRemoverPessoaFisica = new System.Windows.Forms.Button();
            this.btnPesquisarPessoaFisica = new System.Windows.Forms.Button();
            this.txtbPesquisaPessoaFisica = new System.Windows.Forms.TextBox();
            this.dtgJuridica = new System.Windows.Forms.DataGridView();
            this.btnEditarPessoJuridica = new System.Windows.Forms.Button();
            this.btnRemoverPessoaJuridica = new System.Windows.Forms.Button();
            this.txtbPesquisaPessoaJuridica = new System.Windows.Forms.TextBox();
            this.btnPesquisarPessoaJuridica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJuridica)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFisica
            // 
            this.dtgFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFisica.Location = new System.Drawing.Point(12, 40);
            this.dtgFisica.Name = "dtgFisica";
            this.dtgFisica.ReadOnly = true;
            this.dtgFisica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFisica.Size = new System.Drawing.Size(393, 150);
            this.dtgFisica.TabIndex = 0;
            // 
            // btncadastrarPessoa
            // 
            this.btncadastrarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarPessoa.Location = new System.Drawing.Point(12, 417);
            this.btncadastrarPessoa.Name = "btncadastrarPessoa";
            this.btncadastrarPessoa.Size = new System.Drawing.Size(501, 45);
            this.btncadastrarPessoa.TabIndex = 1;
            this.btncadastrarPessoa.Text = "Cadasto de Pessoa";
            this.btncadastrarPessoa.UseVisualStyleBackColor = true;
            this.btncadastrarPessoa.Click += new System.EventHandler(this.btncadastrarPessoa_Click);
            // 
            // btnEditarPessoasFisica
            // 
            this.btnEditarPessoasFisica.Location = new System.Drawing.Point(413, 40);
            this.btnEditarPessoasFisica.Name = "btnEditarPessoasFisica";
            this.btnEditarPessoasFisica.Size = new System.Drawing.Size(99, 36);
            this.btnEditarPessoasFisica.TabIndex = 2;
            this.btnEditarPessoasFisica.Text = "Editar";
            this.btnEditarPessoasFisica.UseVisualStyleBackColor = true;
            this.btnEditarPessoasFisica.Click += new System.EventHandler(this.btnEditarPessoasFisica_Click);
            // 
            // btnRemoverPessoaFisica
            // 
            this.btnRemoverPessoaFisica.Location = new System.Drawing.Point(414, 82);
            this.btnRemoverPessoaFisica.Name = "btnRemoverPessoaFisica";
            this.btnRemoverPessoaFisica.Size = new System.Drawing.Size(99, 36);
            this.btnRemoverPessoaFisica.TabIndex = 3;
            this.btnRemoverPessoaFisica.Text = "Remover";
            this.btnRemoverPessoaFisica.UseVisualStyleBackColor = true;
            this.btnRemoverPessoaFisica.Click += new System.EventHandler(this.btnRemoverPessoaFisica_Click);
            // 
            // btnPesquisarPessoaFisica
            // 
            this.btnPesquisarPessoaFisica.Location = new System.Drawing.Point(411, 167);
            this.btnPesquisarPessoaFisica.Name = "btnPesquisarPessoaFisica";
            this.btnPesquisarPessoaFisica.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPessoaFisica.TabIndex = 4;
            this.btnPesquisarPessoaFisica.Text = "Pesquisar";
            this.btnPesquisarPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPesquisarPessoaFisica.Click += new System.EventHandler(this.btnPesquisarPessoaFisica_Click);
            // 
            // txtbPesquisaPessoaFisica
            // 
            this.txtbPesquisaPessoaFisica.Location = new System.Drawing.Point(411, 141);
            this.txtbPesquisaPessoaFisica.Name = "txtbPesquisaPessoaFisica";
            this.txtbPesquisaPessoaFisica.Size = new System.Drawing.Size(102, 20);
            this.txtbPesquisaPessoaFisica.TabIndex = 5;
            // 
            // dtgJuridica
            // 
            this.dtgJuridica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgJuridica.Location = new System.Drawing.Point(12, 242);
            this.dtgJuridica.Name = "dtgJuridica";
            this.dtgJuridica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgJuridica.Size = new System.Drawing.Size(393, 150);
            this.dtgJuridica.TabIndex = 6;
            // 
            // btnEditarPessoJuridica
            // 
            this.btnEditarPessoJuridica.Location = new System.Drawing.Point(413, 242);
            this.btnEditarPessoJuridica.Name = "btnEditarPessoJuridica";
            this.btnEditarPessoJuridica.Size = new System.Drawing.Size(97, 36);
            this.btnEditarPessoJuridica.TabIndex = 7;
            this.btnEditarPessoJuridica.Text = "Editar";
            this.btnEditarPessoJuridica.UseVisualStyleBackColor = true;
            this.btnEditarPessoJuridica.Click += new System.EventHandler(this.btnEditarPessoJuridica_Click);
            // 
            // btnRemoverPessoaJuridica
            // 
            this.btnRemoverPessoaJuridica.Location = new System.Drawing.Point(414, 284);
            this.btnRemoverPessoaJuridica.Name = "btnRemoverPessoaJuridica";
            this.btnRemoverPessoaJuridica.Size = new System.Drawing.Size(96, 36);
            this.btnRemoverPessoaJuridica.TabIndex = 8;
            this.btnRemoverPessoaJuridica.Text = "Remover";
            this.btnRemoverPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnRemoverPessoaJuridica.Click += new System.EventHandler(this.btnRemoverPessoaJuridica_Click);
            // 
            // txtbPesquisaPessoaJuridica
            // 
            this.txtbPesquisaPessoaJuridica.Location = new System.Drawing.Point(411, 344);
            this.txtbPesquisaPessoaJuridica.Name = "txtbPesquisaPessoaJuridica";
            this.txtbPesquisaPessoaJuridica.Size = new System.Drawing.Size(102, 20);
            this.txtbPesquisaPessoaJuridica.TabIndex = 9;
            // 
            // btnPesquisarPessoaJuridica
            // 
            this.btnPesquisarPessoaJuridica.Location = new System.Drawing.Point(411, 370);
            this.btnPesquisarPessoaJuridica.Name = "btnPesquisarPessoaJuridica";
            this.btnPesquisarPessoaJuridica.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPessoaJuridica.TabIndex = 10;
            this.btnPesquisarPessoaJuridica.Text = "Pesquisar";
            this.btnPesquisarPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPesquisarPessoaJuridica.Click += new System.EventHandler(this.btnPesquisarPessoaJuridica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pessoa Física";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pessoa Jurídica";
            // 
            // PrincipalPessoasFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarPessoaJuridica);
            this.Controls.Add(this.txtbPesquisaPessoaJuridica);
            this.Controls.Add(this.btnRemoverPessoaJuridica);
            this.Controls.Add(this.btnEditarPessoJuridica);
            this.Controls.Add(this.dtgJuridica);
            this.Controls.Add(this.txtbPesquisaPessoaFisica);
            this.Controls.Add(this.btnPesquisarPessoaFisica);
            this.Controls.Add(this.btnRemoverPessoaFisica);
            this.Controls.Add(this.btnEditarPessoasFisica);
            this.Controls.Add(this.btncadastrarPessoa);
            this.Controls.Add(this.dtgFisica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalPessoasFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.PrincipalPessoasFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJuridica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFisica;
        private System.Windows.Forms.Button btncadastrarPessoa;
        private System.Windows.Forms.Button btnEditarPessoasFisica;
        private System.Windows.Forms.Button btnRemoverPessoaFisica;
        private System.Windows.Forms.Button btnPesquisarPessoaFisica;
        private System.Windows.Forms.TextBox txtbPesquisaPessoaFisica;
        private System.Windows.Forms.DataGridView dtgJuridica;
        private System.Windows.Forms.Button btnEditarPessoJuridica;
        private System.Windows.Forms.Button btnRemoverPessoaJuridica;
        private System.Windows.Forms.TextBox txtbPesquisaPessoaJuridica;
        private System.Windows.Forms.Button btnPesquisarPessoaJuridica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}