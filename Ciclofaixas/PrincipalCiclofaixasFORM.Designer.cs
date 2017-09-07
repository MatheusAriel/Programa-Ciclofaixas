namespace Ciclofaixas
{
    partial class PrincipalCiclofaixasFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalCiclofaixasFORM));
            this.dtgCiclofaixas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarCiclofaixas = new System.Windows.Forms.Button();
            this.btnEditarCiclofaixas = new System.Windows.Forms.Button();
            this.btnRemoverCiclofaixas = new System.Windows.Forms.Button();
            this.btnPesquisaCiclofaixas = new System.Windows.Forms.Button();
            this.txtbPesquisaCiclofaixas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiclofaixas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCiclofaixas
            // 
            this.dtgCiclofaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCiclofaixas.Location = new System.Drawing.Point(12, 79);
            this.dtgCiclofaixas.Name = "dtgCiclofaixas";
            this.dtgCiclofaixas.ReadOnly = true;
            this.dtgCiclofaixas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCiclofaixas.Size = new System.Drawing.Size(409, 150);
            this.dtgCiclofaixas.TabIndex = 0;
            // 
            // btnCadastrarCiclofaixas
            // 
            this.btnCadastrarCiclofaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCiclofaixas.Location = new System.Drawing.Point(12, 235);
            this.btnCadastrarCiclofaixas.Name = "btnCadastrarCiclofaixas";
            this.btnCadastrarCiclofaixas.Size = new System.Drawing.Size(409, 45);
            this.btnCadastrarCiclofaixas.TabIndex = 1;
            this.btnCadastrarCiclofaixas.Text = "Cadastro de Ciclofaixas";
            this.btnCadastrarCiclofaixas.UseVisualStyleBackColor = true;
            this.btnCadastrarCiclofaixas.Click += new System.EventHandler(this.btnCadastrarCiclofaixas_Click);
            // 
            // btnEditarCiclofaixas
            // 
            this.btnEditarCiclofaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCiclofaixas.Location = new System.Drawing.Point(12, 30);
            this.btnEditarCiclofaixas.Name = "btnEditarCiclofaixas";
            this.btnEditarCiclofaixas.Size = new System.Drawing.Size(88, 43);
            this.btnEditarCiclofaixas.TabIndex = 2;
            this.btnEditarCiclofaixas.Text = "Editar";
            this.btnEditarCiclofaixas.UseVisualStyleBackColor = true;
            this.btnEditarCiclofaixas.Click += new System.EventHandler(this.btnEditarCiclofaixas_Click);
            // 
            // btnRemoverCiclofaixas
            // 
            this.btnRemoverCiclofaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverCiclofaixas.Location = new System.Drawing.Point(120, 30);
            this.btnRemoverCiclofaixas.Name = "btnRemoverCiclofaixas";
            this.btnRemoverCiclofaixas.Size = new System.Drawing.Size(88, 43);
            this.btnRemoverCiclofaixas.TabIndex = 3;
            this.btnRemoverCiclofaixas.Text = "Remover";
            this.btnRemoverCiclofaixas.UseVisualStyleBackColor = true;
            this.btnRemoverCiclofaixas.Click += new System.EventHandler(this.btnRemoverCiclofaixas_Click);
            // 
            // btnPesquisaCiclofaixas
            // 
            this.btnPesquisaCiclofaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaCiclofaixas.Location = new System.Drawing.Point(225, 41);
            this.btnPesquisaCiclofaixas.Name = "btnPesquisaCiclofaixas";
            this.btnPesquisaCiclofaixas.Size = new System.Drawing.Size(196, 32);
            this.btnPesquisaCiclofaixas.TabIndex = 4;
            this.btnPesquisaCiclofaixas.Text = "Pesquisar";
            this.btnPesquisaCiclofaixas.UseVisualStyleBackColor = true;
            this.btnPesquisaCiclofaixas.Click += new System.EventHandler(this.btnPesquisaCiclofaixas_Click);
            // 
            // txtbPesquisaCiclofaixas
            // 
            this.txtbPesquisaCiclofaixas.Location = new System.Drawing.Point(225, 15);
            this.txtbPesquisaCiclofaixas.Name = "txtbPesquisaCiclofaixas";
            this.txtbPesquisaCiclofaixas.Size = new System.Drawing.Size(196, 20);
            this.txtbPesquisaCiclofaixas.TabIndex = 5;
            // 
            // PrincipalCiclofaixasFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 288);
            this.Controls.Add(this.txtbPesquisaCiclofaixas);
            this.Controls.Add(this.btnPesquisaCiclofaixas);
            this.Controls.Add(this.btnRemoverCiclofaixas);
            this.Controls.Add(this.btnEditarCiclofaixas);
            this.Controls.Add(this.btnCadastrarCiclofaixas);
            this.Controls.Add(this.dtgCiclofaixas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalCiclofaixasFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciclofaixas";
            this.Load += new System.EventHandler(this.PrincipalCiclofaixasFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCiclofaixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCiclofaixas;
        private System.Windows.Forms.Button btnCadastrarCiclofaixas;
        private System.Windows.Forms.Button btnEditarCiclofaixas;
        private System.Windows.Forms.Button btnRemoverCiclofaixas;
        private System.Windows.Forms.Button btnPesquisaCiclofaixas;
        private System.Windows.Forms.TextBox txtbPesquisaCiclofaixas;
    }
}