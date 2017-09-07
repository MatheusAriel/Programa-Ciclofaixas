namespace Ciclofaixas
{
    partial class PrincipalFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFORM));
            this.btnCiclofaixas = new System.Windows.Forms.Button();
            this.btnEstacoes = new System.Windows.Forms.Button();
            this.btnBicicletas = new System.Windows.Forms.Button();
            this.btnLocacoes = new System.Windows.Forms.Button();
            this.btnAtracoes = new System.Windows.Forms.Button();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCiclofaixas
            // 
            this.btnCiclofaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiclofaixas.Location = new System.Drawing.Point(12, 22);
            this.btnCiclofaixas.Name = "btnCiclofaixas";
            this.btnCiclofaixas.Size = new System.Drawing.Size(192, 97);
            this.btnCiclofaixas.TabIndex = 2;
            this.btnCiclofaixas.Text = "Ciclofaixas";
            this.btnCiclofaixas.UseVisualStyleBackColor = true;
            this.btnCiclofaixas.Click += new System.EventHandler(this.btnCiclofaixas_Click);
            // 
            // btnEstacoes
            // 
            this.btnEstacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacoes.Location = new System.Drawing.Point(12, 328);
            this.btnEstacoes.Name = "btnEstacoes";
            this.btnEstacoes.Size = new System.Drawing.Size(192, 97);
            this.btnEstacoes.TabIndex = 3;
            this.btnEstacoes.Text = "Estacoes";
            this.btnEstacoes.UseVisualStyleBackColor = true;
            this.btnEstacoes.Click += new System.EventHandler(this.btnEstacoes_Click);
            // 
            // btnBicicletas
            // 
            this.btnBicicletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBicicletas.Location = new System.Drawing.Point(303, 328);
            this.btnBicicletas.Name = "btnBicicletas";
            this.btnBicicletas.Size = new System.Drawing.Size(192, 97);
            this.btnBicicletas.TabIndex = 4;
            this.btnBicicletas.Text = "Bicicletas";
            this.btnBicicletas.UseVisualStyleBackColor = true;
            this.btnBicicletas.Click += new System.EventHandler(this.btnBicicletas_Click);
            // 
            // btnLocacoes
            // 
            this.btnLocacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocacoes.Location = new System.Drawing.Point(592, 22);
            this.btnLocacoes.Name = "btnLocacoes";
            this.btnLocacoes.Size = new System.Drawing.Size(192, 97);
            this.btnLocacoes.TabIndex = 5;
            this.btnLocacoes.Text = "Locar Bicicletas";
            this.btnLocacoes.UseVisualStyleBackColor = true;
            this.btnLocacoes.Click += new System.EventHandler(this.btnLocacoes_Click);
            // 
            // btnAtracoes
            // 
            this.btnAtracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtracoes.Location = new System.Drawing.Point(303, 22);
            this.btnAtracoes.Name = "btnAtracoes";
            this.btnAtracoes.Size = new System.Drawing.Size(192, 97);
            this.btnAtracoes.TabIndex = 6;
            this.btnAtracoes.Text = "Atrações";
            this.btnAtracoes.UseVisualStyleBackColor = true;
            this.btnAtracoes.Click += new System.EventHandler(this.btnAtracoes_Click);
            // 
            // btnPessoas
            // 
            this.btnPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoas.Location = new System.Drawing.Point(592, 328);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Size = new System.Drawing.Size(192, 97);
            this.btnPessoas.TabIndex = 7;
            this.btnPessoas.Text = "Pessoas";
            this.btnPessoas.UseVisualStyleBackColor = true;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click_1);
            // 
            // PrincipalFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 437);
            this.Controls.Add(this.btnPessoas);
            this.Controls.Add(this.btnAtracoes);
            this.Controls.Add(this.btnLocacoes);
            this.Controls.Add(this.btnBicicletas);
            this.Controls.Add(this.btnEstacoes);
            this.Controls.Add(this.btnCiclofaixas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalFORM";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCiclofaixas;
        private System.Windows.Forms.Button btnEstacoes;
        private System.Windows.Forms.Button btnBicicletas;
        private System.Windows.Forms.Button btnLocacoes;
        private System.Windows.Forms.Button btnAtracoes;
        private System.Windows.Forms.Button btnPessoas;
    }
}