namespace ProjetoFinal_3J_13
{
    partial class FormY
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
            this.txt_NomeFantasia = new System.Windows.Forms.TextBox();
            this.txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.mkt_data = new System.Windows.Forms.MaskedTextBox();
            this.mkt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_informe = new System.Windows.Forms.Label();
            this.lbl_dataCriacao = new System.Windows.Forms.Label();
            this.lbl_NomeFantasia = new System.Windows.Forms.Label();
            this.lbl_RazaoSocial = new System.Windows.Forms.Label();
            this.lbl_CNPJ = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NomeFantasia
            // 
            this.txt_NomeFantasia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_NomeFantasia.Location = new System.Drawing.Point(286, 231);
            this.txt_NomeFantasia.MaxLength = 9;
            this.txt_NomeFantasia.Name = "txt_NomeFantasia";
            this.txt_NomeFantasia.Size = new System.Drawing.Size(234, 20);
            this.txt_NomeFantasia.TabIndex = 36;
            // 
            // txt_RazaoSocial
            // 
            this.txt_RazaoSocial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_RazaoSocial.Location = new System.Drawing.Point(286, 151);
            this.txt_RazaoSocial.MaxLength = 100;
            this.txt_RazaoSocial.Name = "txt_RazaoSocial";
            this.txt_RazaoSocial.Size = new System.Drawing.Size(453, 20);
            this.txt_RazaoSocial.TabIndex = 35;
            // 
            // mkt_data
            // 
            this.mkt_data.Location = new System.Drawing.Point(286, 306);
            this.mkt_data.Mask = "00/00/0000";
            this.mkt_data.Name = "mkt_data";
            this.mkt_data.Size = new System.Drawing.Size(234, 20);
            this.mkt_data.TabIndex = 34;
            this.mkt_data.ValidatingType = typeof(System.DateTime);
            // 
            // mkt_cpf
            // 
            this.mkt_cpf.Location = new System.Drawing.Point(156, 70);
            this.mkt_cpf.Mask = "00000000000000";
            this.mkt_cpf.Name = "mkt_cpf";
            this.mkt_cpf.Size = new System.Drawing.Size(234, 20);
            this.mkt_cpf.TabIndex = 33;
            this.mkt_cpf.ValidatingType = typeof(int);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_limpar.Location = new System.Drawing.Point(615, 61);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(124, 37);
            this.btn_limpar.TabIndex = 32;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(615, 277);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(124, 49);
            this.btn_sair.TabIndex = 31;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // lbl_informe
            // 
            this.lbl_informe.AutoSize = true;
            this.lbl_informe.Location = new System.Drawing.Point(415, 76);
            this.lbl_informe.Name = "lbl_informe";
            this.lbl_informe.Size = new System.Drawing.Size(132, 13);
            this.lbl_informe.TabIndex = 26;
            this.lbl_informe.Text = "Informe Somente Numeros";
            // 
            // lbl_dataCriacao
            // 
            this.lbl_dataCriacao.AutoSize = true;
            this.lbl_dataCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataCriacao.Location = new System.Drawing.Point(64, 295);
            this.lbl_dataCriacao.Name = "lbl_dataCriacao";
            this.lbl_dataCriacao.Size = new System.Drawing.Size(210, 31);
            this.lbl_dataCriacao.TabIndex = 25;
            this.lbl_dataCriacao.Text = "Data da Criação";
            // 
            // lbl_NomeFantasia
            // 
            this.lbl_NomeFantasia.AutoSize = true;
            this.lbl_NomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeFantasia.Location = new System.Drawing.Point(64, 219);
            this.lbl_NomeFantasia.Name = "lbl_NomeFantasia";
            this.lbl_NomeFantasia.Size = new System.Drawing.Size(198, 31);
            this.lbl_NomeFantasia.TabIndex = 24;
            this.lbl_NomeFantasia.Text = "Nome Fantasia";
            // 
            // lbl_RazaoSocial
            // 
            this.lbl_RazaoSocial.AutoSize = true;
            this.lbl_RazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RazaoSocial.Location = new System.Drawing.Point(64, 140);
            this.lbl_RazaoSocial.Name = "lbl_RazaoSocial";
            this.lbl_RazaoSocial.Size = new System.Drawing.Size(174, 31);
            this.lbl_RazaoSocial.TabIndex = 23;
            this.lbl_RazaoSocial.Text = "Razao Social";
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CNPJ.Location = new System.Drawing.Point(67, 61);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(86, 31);
            this.lbl_CNPJ.TabIndex = 22;
            this.lbl_CNPJ.Text = "CNPJ";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(615, 365);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(124, 47);
            this.btn_alterar.TabIndex = 40;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(438, 365);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(124, 47);
            this.btn_excluir.TabIndex = 39;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(244, 365);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(124, 47);
            this.btn_consultar.TabIndex = 38;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(61, 365);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(124, 47);
            this.btn_inserir.TabIndex = 37;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // FormY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_NomeFantasia);
            this.Controls.Add(this.txt_RazaoSocial);
            this.Controls.Add(this.mkt_data);
            this.Controls.Add(this.mkt_cpf);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_informe);
            this.Controls.Add(this.lbl_dataCriacao);
            this.Controls.Add(this.lbl_NomeFantasia);
            this.Controls.Add(this.lbl_RazaoSocial);
            this.Controls.Add(this.lbl_CNPJ);
            this.Name = "FormY";
            this.Text = "Cadastro Nacional de Pessoa Jurídica";
            this.Load += new System.EventHandler(this.FormY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeFantasia;
        private System.Windows.Forms.TextBox txt_RazaoSocial;
        private System.Windows.Forms.MaskedTextBox mkt_data;
        private System.Windows.Forms.MaskedTextBox mkt_cpf;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_informe;
        private System.Windows.Forms.Label lbl_dataCriacao;
        private System.Windows.Forms.Label lbl_NomeFantasia;
        private System.Windows.Forms.Label lbl_RazaoSocial;
        private System.Windows.Forms.Label lbl_CNPJ;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_inserir;
    }
}