namespace Ciclofaixas
{
    partial class CadastrarCiclista_LocacaoFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCiclista_LocacaoFORM));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbHoraLocacao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbDataLocacao = new System.Windows.Forms.MaskedTextBox();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBicicleta = new System.Windows.Forms.ComboBox();
            this.btnLocao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora Locação:";
            // 
            // txtbHoraLocacao
            // 
            this.txtbHoraLocacao.Location = new System.Drawing.Point(110, 191);
            this.txtbHoraLocacao.Mask = "00:00";
            this.txtbHoraLocacao.Name = "txtbHoraLocacao";
            this.txtbHoraLocacao.Size = new System.Drawing.Size(32, 20);
            this.txtbHoraLocacao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Locação:";
            // 
            // txtbDataLocacao
            // 
            this.txtbDataLocacao.Location = new System.Drawing.Point(19, 191);
            this.txtbDataLocacao.Mask = "00/00/0000";
            this.txtbDataLocacao.Name = "txtbDataLocacao";
            this.txtbDataLocacao.Size = new System.Drawing.Size(66, 20);
            this.txtbDataLocacao.TabIndex = 3;
            this.txtbDataLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Location = new System.Drawing.Point(19, 67);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(269, 21);
            this.cmbPessoa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pessoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bicicleta:";
            // 
            // cmbBicicleta
            // 
            this.cmbBicicleta.FormattingEnabled = true;
            this.cmbBicicleta.Location = new System.Drawing.Point(19, 133);
            this.cmbBicicleta.Name = "cmbBicicleta";
            this.cmbBicicleta.Size = new System.Drawing.Size(269, 21);
            this.cmbBicicleta.TabIndex = 7;
            // 
            // btnLocao
            // 
            this.btnLocao.Location = new System.Drawing.Point(191, 163);
            this.btnLocao.Name = "btnLocao";
            this.btnLocao.Size = new System.Drawing.Size(97, 48);
            this.btnLocao.TabIndex = 8;
            this.btnLocao.Text = "Locação";
            this.btnLocao.UseVisualStyleBackColor = true;
            this.btnLocao.Click += new System.EventHandler(this.btnLocao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Locação ";
            // 
            // CadastrarCiclista_LocacaoFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 227);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLocao);
            this.Controls.Add(this.cmbBicicleta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPessoa);
            this.Controls.Add(this.txtbDataLocacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbHoraLocacao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarCiclista_LocacaoFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação de Bicicletas";
            this.Load += new System.EventHandler(this.CadastrarCiclista_LocacaoFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtbHoraLocacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtbDataLocacao;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBicicleta;
        private System.Windows.Forms.Button btnLocao;
        private System.Windows.Forms.Label label5;
    }
}