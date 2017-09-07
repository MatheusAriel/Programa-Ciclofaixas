namespace Ciclofaixas
{
    partial class PrincipalBicicletasFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalBicicletasFORM));
            this.dtgBicicletas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarBicicletas = new System.Windows.Forms.Button();
            this.btnRemoverBicicletas = new System.Windows.Forms.Button();
            this.btnPesquisarBicicletas = new System.Windows.Forms.Button();
            this.txtbPesquisaBicicletas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBicicletas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBicicletas
            // 
            this.dtgBicicletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBicicletas.Location = new System.Drawing.Point(12, 90);
            this.dtgBicicletas.Name = "dtgBicicletas";
            this.dtgBicicletas.ReadOnly = true;
            this.dtgBicicletas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBicicletas.Size = new System.Drawing.Size(324, 176);
            this.dtgBicicletas.TabIndex = 0;
            // 
            // btnCadastrarBicicletas
            // 
            this.btnCadastrarBicicletas.Location = new System.Drawing.Point(12, 38);
            this.btnCadastrarBicicletas.Name = "btnCadastrarBicicletas";
            this.btnCadastrarBicicletas.Size = new System.Drawing.Size(104, 45);
            this.btnCadastrarBicicletas.TabIndex = 1;
            this.btnCadastrarBicicletas.Text = "Cadastro de Bicicletas";
            this.btnCadastrarBicicletas.UseVisualStyleBackColor = true;
            this.btnCadastrarBicicletas.Click += new System.EventHandler(this.btnCadastrarBicicletas_Click);
            // 
            // btnRemoverBicicletas
            // 
            this.btnRemoverBicicletas.Location = new System.Drawing.Point(122, 38);
            this.btnRemoverBicicletas.Name = "btnRemoverBicicletas";
            this.btnRemoverBicicletas.Size = new System.Drawing.Size(104, 45);
            this.btnRemoverBicicletas.TabIndex = 3;
            this.btnRemoverBicicletas.Text = "Remover";
            this.btnRemoverBicicletas.UseVisualStyleBackColor = true;
            this.btnRemoverBicicletas.Click += new System.EventHandler(this.btnRemoverBicicletas_Click);
            // 
            // btnPesquisarBicicletas
            // 
            this.btnPesquisarBicicletas.Location = new System.Drawing.Point(232, 39);
            this.btnPesquisarBicicletas.Name = "btnPesquisarBicicletas";
            this.btnPesquisarBicicletas.Size = new System.Drawing.Size(104, 45);
            this.btnPesquisarBicicletas.TabIndex = 4;
            this.btnPesquisarBicicletas.Text = "Pesquisar ";
            this.btnPesquisarBicicletas.UseVisualStyleBackColor = true;
            this.btnPesquisarBicicletas.Click += new System.EventHandler(this.btnPesquisarBicicletas_Click);
            // 
            // txtbPesquisaBicicletas
            // 
            this.txtbPesquisaBicicletas.Location = new System.Drawing.Point(232, 13);
            this.txtbPesquisaBicicletas.Name = "txtbPesquisaBicicletas";
            this.txtbPesquisaBicicletas.Size = new System.Drawing.Size(104, 20);
            this.txtbPesquisaBicicletas.TabIndex = 5;
            // 
            // PrincipalBicicletasFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 278);
            this.Controls.Add(this.txtbPesquisaBicicletas);
            this.Controls.Add(this.btnPesquisarBicicletas);
            this.Controls.Add(this.btnRemoverBicicletas);
            this.Controls.Add(this.btnCadastrarBicicletas);
            this.Controls.Add(this.dtgBicicletas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalBicicletasFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicicletas";
            this.Load += new System.EventHandler(this.PrincipalBicicletasFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBicicletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBicicletas;
        private System.Windows.Forms.Button btnCadastrarBicicletas;
        private System.Windows.Forms.Button btnRemoverBicicletas;
        private System.Windows.Forms.Button btnPesquisarBicicletas;
        private System.Windows.Forms.TextBox txtbPesquisaBicicletas;
    }
}