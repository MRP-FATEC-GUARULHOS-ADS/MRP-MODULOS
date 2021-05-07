namespace ModuloCompras
{
    partial class CadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.h2_lbl = new System.Windows.Forms.Label();
            this.nm_fornecedor = new System.Windows.Forms.TextBox();
            this.cnpj_fornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.validacao_pnl = new System.Windows.Forms.Panel();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.cnpj_pnl = new System.Windows.Forms.Panel();
            this.nome_pnl = new System.Windows.Forms.Panel();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.spacer_dir_spl = new System.Windows.Forms.Splitter();
            this.spacer_dir_pnl = new System.Windows.Forms.Panel();
            this.spacer_esq_spl = new System.Windows.Forms.Splitter();
            this.spacer_esq_pnl = new System.Windows.Forms.Panel();
            this.corpo_pnl.SuspendLayout();
            this.validacao_pnl.SuspendLayout();
            this.main_pnl.SuspendLayout();
            this.cnpj_pnl.SuspendLayout();
            this.nome_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(101, 6);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(192, 52);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "&Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // h2_lbl
            // 
            this.h2_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.h2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2_lbl.Location = new System.Drawing.Point(0, 32);
            this.h2_lbl.Name = "h2_lbl";
            this.h2_lbl.Size = new System.Drawing.Size(394, 64);
            this.h2_lbl.TabIndex = 1;
            this.h2_lbl.Text = "Cadastro de Fornecedor";
            this.h2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nm_fornecedor
            // 
            this.nm_fornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.nm_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nm_fornecedor.Location = new System.Drawing.Point(0, 25);
            this.nm_fornecedor.Name = "nm_fornecedor";
            this.nm_fornecedor.Size = new System.Drawing.Size(394, 32);
            this.nm_fornecedor.TabIndex = 2;
            // 
            // cnpj_fornecedor
            // 
            this.cnpj_fornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cnpj_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cnpj_fornecedor.Location = new System.Drawing.Point(0, 25);
            this.cnpj_fornecedor.Name = "cnpj_fornecedor";
            this.cnpj_fornecedor.Size = new System.Drawing.Size(394, 32);
            this.cnpj_fornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ";
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.Controls.Add(this.validacao_pnl);
            this.corpo_pnl.Controls.Add(this.footer_pnl);
            this.corpo_pnl.Controls.Add(this.main_pnl);
            this.corpo_pnl.Controls.Add(this.header_pnl);
            this.corpo_pnl.Controls.Add(this.spacer_dir_spl);
            this.corpo_pnl.Controls.Add(this.spacer_dir_pnl);
            this.corpo_pnl.Controls.Add(this.spacer_esq_spl);
            this.corpo_pnl.Controls.Add(this.spacer_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 0);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(464, 345);
            this.corpo_pnl.TabIndex = 6;
            // 
            // validacao_pnl
            // 
            this.validacao_pnl.Controls.Add(this.btn_cadastrar);
            this.validacao_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.validacao_pnl.Location = new System.Drawing.Point(35, 257);
            this.validacao_pnl.Name = "validacao_pnl";
            this.validacao_pnl.Size = new System.Drawing.Size(394, 64);
            this.validacao_pnl.TabIndex = 2;
            // 
            // footer_pnl
            // 
            this.footer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pnl.Location = new System.Drawing.Point(35, 321);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(394, 24);
            this.footer_pnl.TabIndex = 3;
            // 
            // main_pnl
            // 
            this.main_pnl.AutoSize = true;
            this.main_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.main_pnl.Controls.Add(this.cnpj_pnl);
            this.main_pnl.Controls.Add(this.nome_pnl);
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_pnl.Location = new System.Drawing.Point(35, 96);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(394, 140);
            this.main_pnl.TabIndex = 1;
            // 
            // cnpj_pnl
            // 
            this.cnpj_pnl.Controls.Add(this.cnpj_fornecedor);
            this.cnpj_pnl.Controls.Add(this.label3);
            this.cnpj_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cnpj_pnl.Location = new System.Drawing.Point(0, 70);
            this.cnpj_pnl.Name = "cnpj_pnl";
            this.cnpj_pnl.Size = new System.Drawing.Size(394, 70);
            this.cnpj_pnl.TabIndex = 1;
            // 
            // nome_pnl
            // 
            this.nome_pnl.Controls.Add(this.nm_fornecedor);
            this.nome_pnl.Controls.Add(this.label2);
            this.nome_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nome_pnl.Location = new System.Drawing.Point(0, 0);
            this.nome_pnl.Name = "nome_pnl";
            this.nome_pnl.Size = new System.Drawing.Size(394, 70);
            this.nome_pnl.TabIndex = 0;
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.h2_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(35, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(394, 96);
            this.header_pnl.TabIndex = 0;
            // 
            // spacer_dir_spl
            // 
            this.spacer_dir_spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_spl.Enabled = false;
            this.spacer_dir_spl.Location = new System.Drawing.Point(429, 0);
            this.spacer_dir_spl.Name = "spacer_dir_spl";
            this.spacer_dir_spl.Size = new System.Drawing.Size(3, 345);
            this.spacer_dir_spl.TabIndex = 7;
            this.spacer_dir_spl.TabStop = false;
            // 
            // spacer_dir_pnl
            // 
            this.spacer_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_pnl.Location = new System.Drawing.Point(432, 0);
            this.spacer_dir_pnl.Name = "spacer_dir_pnl";
            this.spacer_dir_pnl.Size = new System.Drawing.Size(32, 345);
            this.spacer_dir_pnl.TabIndex = 5;
            // 
            // spacer_esq_spl
            // 
            this.spacer_esq_spl.Enabled = false;
            this.spacer_esq_spl.Location = new System.Drawing.Point(32, 0);
            this.spacer_esq_spl.Name = "spacer_esq_spl";
            this.spacer_esq_spl.Size = new System.Drawing.Size(3, 345);
            this.spacer_esq_spl.TabIndex = 6;
            this.spacer_esq_spl.TabStop = false;
            // 
            // spacer_esq_pnl
            // 
            this.spacer_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.spacer_esq_pnl.Name = "spacer_esq_pnl";
            this.spacer_esq_pnl.Size = new System.Drawing.Size(32, 345);
            this.spacer_esq_pnl.TabIndex = 4;
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 345);
            this.Controls.Add(this.corpo_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.corpo_pnl.ResumeLayout(false);
            this.corpo_pnl.PerformLayout();
            this.validacao_pnl.ResumeLayout(false);
            this.main_pnl.ResumeLayout(false);
            this.cnpj_pnl.ResumeLayout(false);
            this.cnpj_pnl.PerformLayout();
            this.nome_pnl.ResumeLayout(false);
            this.nome_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label h2_lbl;
        private System.Windows.Forms.TextBox nm_fornecedor;
        private System.Windows.Forms.TextBox cnpj_fornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel validacao_pnl;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Panel cnpj_pnl;
        private System.Windows.Forms.Panel nome_pnl;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Splitter spacer_dir_spl;
        private System.Windows.Forms.Panel spacer_dir_pnl;
        private System.Windows.Forms.Splitter spacer_esq_spl;
        private System.Windows.Forms.Panel spacer_esq_pnl;
    }
}