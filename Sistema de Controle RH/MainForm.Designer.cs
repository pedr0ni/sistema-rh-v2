namespace Sistema_de_Controle_RH
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lb_funcionarios = new System.Windows.Forms.ListBox();
            this.txt_funcionario = new System.Windows.Forms.TextBox();
            this.txt_sb = new System.Windows.Forms.TextBox();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.txt_mesestrab = new System.Windows.Forms.TextBox();
            this.txt_diasferias = new System.Windows.Forms.TextBox();
            this.cmb_setor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_txt = new System.Windows.Forms.Panel();
            this.panel_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar.Location = new System.Drawing.Point(23, 417);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(127, 58);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_limpar.Location = new System.Drawing.Point(171, 417);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(127, 58);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sair.Location = new System.Drawing.Point(329, 417);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(127, 58);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lb_funcionarios
            // 
            this.lb_funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_funcionarios.FormattingEnabled = true;
            this.lb_funcionarios.ItemHeight = 16;
            this.lb_funcionarios.Location = new System.Drawing.Point(490, 52);
            this.lb_funcionarios.Name = "lb_funcionarios";
            this.lb_funcionarios.Size = new System.Drawing.Size(553, 420);
            this.lb_funcionarios.TabIndex = 3;
            // 
            // txt_funcionario
            // 
            this.txt_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcionario.Location = new System.Drawing.Point(31, 15);
            this.txt_funcionario.Name = "txt_funcionario";
            this.txt_funcionario.Size = new System.Drawing.Size(222, 22);
            this.txt_funcionario.TabIndex = 4;
            // 
            // txt_sb
            // 
            this.txt_sb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sb.Location = new System.Drawing.Point(31, 115);
            this.txt_sb.Name = "txt_sb";
            this.txt_sb.Size = new System.Drawing.Size(222, 22);
            this.txt_sb.TabIndex = 5;
            // 
            // txt_bonus
            // 
            this.txt_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bonus.Location = new System.Drawing.Point(31, 167);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(222, 22);
            this.txt_bonus.TabIndex = 6;
            // 
            // txt_mesestrab
            // 
            this.txt_mesestrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mesestrab.Location = new System.Drawing.Point(31, 214);
            this.txt_mesestrab.Name = "txt_mesestrab";
            this.txt_mesestrab.Size = new System.Drawing.Size(222, 22);
            this.txt_mesestrab.TabIndex = 7;
            // 
            // txt_diasferias
            // 
            this.txt_diasferias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diasferias.Location = new System.Drawing.Point(31, 269);
            this.txt_diasferias.Name = "txt_diasferias";
            this.txt_diasferias.Size = new System.Drawing.Size(222, 22);
            this.txt_diasferias.TabIndex = 8;
            // 
            // cmb_setor
            // 
            this.cmb_setor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_setor.FormattingEnabled = true;
            this.cmb_setor.Items.AddRange(new object[] {
            "Escolha um Setor",
            "Administração",
            "Compras",
            "Contabilidade",
            "Produção",
            "Vendas"});
            this.cmb_setor.Location = new System.Drawing.Point(31, 62);
            this.cmb_setor.Name = "cmb_setor";
            this.cmb_setor.Size = new System.Drawing.Size(222, 24);
            this.cmb_setor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salário Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bônus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nº de meses trabalhados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dias de férias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Funcionários cadastrados";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 85);
            this.label11.TabIndex = 27;
            this.label11.Text = "SistemaRH";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_txt
            // 
            this.panel_txt.Controls.Add(this.txt_funcionario);
            this.panel_txt.Controls.Add(this.cmb_setor);
            this.panel_txt.Controls.Add(this.txt_sb);
            this.panel_txt.Controls.Add(this.txt_bonus);
            this.panel_txt.Controls.Add(this.txt_mesestrab);
            this.panel_txt.Controls.Add(this.txt_diasferias);
            this.panel_txt.Location = new System.Drawing.Point(199, 88);
            this.panel_txt.Name = "panel_txt";
            this.panel_txt.Size = new System.Drawing.Size(269, 300);
            this.panel_txt.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 487);
            this.Controls.Add(this.panel_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_funcionarios);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaRH 2.0";
            this.panel_txt.ResumeLayout(false);
            this.panel_txt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListBox lb_funcionarios;
        private System.Windows.Forms.TextBox txt_funcionario;
        private System.Windows.Forms.TextBox txt_sb;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.TextBox txt_mesestrab;
        private System.Windows.Forms.TextBox txt_diasferias;
        private System.Windows.Forms.ComboBox cmb_setor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_txt;
    }
}

