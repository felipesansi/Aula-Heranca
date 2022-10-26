namespace Heranca
{
    partial class Tela_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_pf = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_nome = new System.Windows.Forms.TextBox();
            this.Tbx_ende = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mask_tel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check_pj = new System.Windows.Forms.CheckBox();
            this.Painel_pf = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Mask_data = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Painel_pj = new System.Windows.Forms.Panel();
            this.Tbx_fantasia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Mask_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.Painel_pf.SuspendLayout();
            this.Painel_pj.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_pf
            // 
            this.check_pf.AutoSize = true;
            this.check_pf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pf.Location = new System.Drawing.Point(164, 12);
            this.check_pf.Name = "check_pf";
            this.check_pf.Size = new System.Drawing.Size(68, 20);
            this.check_pf.TabIndex = 0;
            this.check_pf.Text = "Fisica";
            this.check_pf.UseVisualStyleBackColor = true;
            this.check_pf.CheckedChanged += new System.EventHandler(this.check_pf_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // Tbx_nome
            // 
            this.Tbx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_nome.Location = new System.Drawing.Point(90, 66);
            this.Tbx_nome.Name = "Tbx_nome";
            this.Tbx_nome.Size = new System.Drawing.Size(383, 22);
            this.Tbx_nome.TabIndex = 2;
            // 
            // Tbx_ende
            // 
            this.Tbx_ende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_ende.Location = new System.Drawing.Point(108, 120);
            this.Tbx_ende.Name = "Tbx_ende";
            this.Tbx_ende.Size = new System.Drawing.Size(365, 22);
            this.Tbx_ende.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço:";
            // 
            // Txb_email
            // 
            this.Txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_email.Location = new System.Drawing.Point(100, 235);
            this.Txb_email.Name = "Txb_email";
            this.Txb_email.Size = new System.Drawing.Size(373, 22);
            this.Txb_email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // Mask_tel
            // 
            this.Mask_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_tel.Location = new System.Drawing.Point(108, 177);
            this.Mask_tel.Mask = "(00) 0 0000-0000";
            this.Mask_tel.Name = "Mask_tel";
            this.Mask_tel.Size = new System.Drawing.Size(365, 22);
            this.Mask_tel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecionar:";
            // 
            // check_pj
            // 
            this.check_pj.AutoSize = true;
            this.check_pj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pj.Location = new System.Drawing.Point(262, 12);
            this.check_pj.Name = "check_pj";
            this.check_pj.Size = new System.Drawing.Size(81, 20);
            this.check_pj.TabIndex = 10;
            this.check_pj.Text = "Juridica";
            this.check_pj.UseVisualStyleBackColor = true;
            this.check_pj.CheckedChanged += new System.EventHandler(this.check_pj_CheckedChanged);
            // 
            // Painel_pf
            // 
            this.Painel_pf.Controls.Add(this.label7);
            this.Painel_pf.Controls.Add(this.Mask_data);
            this.Painel_pf.Controls.Add(this.label6);
            this.Painel_pf.Controls.Add(this.Mask_cpf);
            this.Painel_pf.Location = new System.Drawing.Point(12, 284);
            this.Painel_pf.Name = "Painel_pf";
            this.Painel_pf.Size = new System.Drawing.Size(532, 121);
            this.Painel_pf.TabIndex = 11;
            this.Painel_pf.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data de nascimento";
            // 
            // Mask_data
            // 
            this.Mask_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_data.Location = new System.Drawing.Point(157, 65);
            this.Mask_data.Mask = "00/00/0000";
            this.Mask_data.Name = "Mask_data";
            this.Mask_data.Size = new System.Drawing.Size(86, 22);
            this.Mask_data.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // Mask_cpf
            // 
            this.Mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_cpf.Location = new System.Drawing.Point(96, 20);
            this.Mask_cpf.Mask = "000.000.000-00";
            this.Mask_cpf.Name = "Mask_cpf";
            this.Mask_cpf.Size = new System.Drawing.Size(124, 22);
            this.Mask_cpf.TabIndex = 11;
            // 
            // Painel_pj
            // 
            this.Painel_pj.Controls.Add(this.Tbx_fantasia);
            this.Painel_pj.Controls.Add(this.label8);
            this.Painel_pj.Controls.Add(this.label9);
            this.Painel_pj.Controls.Add(this.Mask_cnpj);
            this.Painel_pj.Location = new System.Drawing.Point(9, 281);
            this.Painel_pj.Name = "Painel_pj";
            this.Painel_pj.Size = new System.Drawing.Size(532, 121);
            this.Painel_pj.TabIndex = 12;
            this.Painel_pj.Visible = false;
            // 
            // Tbx_fantasia
            // 
            this.Tbx_fantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_fantasia.Location = new System.Drawing.Point(123, 65);
            this.Tbx_fantasia.Name = "Tbx_fantasia";
            this.Tbx_fantasia.Size = new System.Drawing.Size(383, 22);
            this.Tbx_fantasia.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nome fantasia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "CNPJ:";
            // 
            // Mask_cnpj
            // 
            this.Mask_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_cnpj.Location = new System.Drawing.Point(96, 20);
            this.Mask_cnpj.Mask = "000.000.000-00";
            this.Mask_cnpj.Name = "Mask_cnpj";
            this.Mask_cnpj.Size = new System.Drawing.Size(124, 22);
            this.Mask_cnpj.TabIndex = 11;
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salvar.Location = new System.Drawing.Point(90, 435);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(113, 43);
            this.Btn_salvar.TabIndex = 13;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // BtnExibir
            // 
            this.BtnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExibir.Location = new System.Drawing.Point(230, 435);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(113, 43);
            this.BtnExibir.TabIndex = 14;
            this.BtnExibir.Text = "Exibir";
            this.BtnExibir.UseVisualStyleBackColor = true;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // Tela_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 490);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Painel_pj);
            this.Controls.Add(this.Painel_pf);
            this.Controls.Add(this.check_pj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mask_tel);
            this.Controls.Add(this.Txb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tbx_ende);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbx_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_pf);
            this.Name = "Tela_principal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Painel_pf.ResumeLayout(false);
            this.Painel_pf.PerformLayout();
            this.Painel_pj.ResumeLayout(false);
            this.Painel_pj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_pf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_nome;
        private System.Windows.Forms.TextBox Tbx_ende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Mask_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_pj;
        private System.Windows.Forms.Panel Painel_pf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Mask_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Mask_data;
        private System.Windows.Forms.Panel Painel_pj;
        private System.Windows.Forms.TextBox Tbx_fantasia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Mask_cnpj;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button BtnExibir;
    }
}

