namespace mrp_template
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.status_spl = new System.Windows.Forms.Splitter();
            this.spacer_esq_pnl = new System.Windows.Forms.Panel();
            this.spacer_esq_spl = new System.Windows.Forms.Splitter();
            this.spacer_dir_pnl = new System.Windows.Forms.Panel();
            this.spacer_dir_spl = new System.Windows.Forms.Splitter();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.listviewdiv_pnl = new System.Windows.Forms.Panel();
            this.listapecas_lstvw = new System.Windows.Forms.ListView();
            this.listapecas_spacer_pnl = new System.Windows.Forms.Panel();
            this.listapecas_lbl = new System.Windows.Forms.Label();
            this.textobotaodiv_pnl = new System.Windows.Forms.Panel();
            this.textbox_pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_lbl = new System.Windows.Forms.Label();
            this.spacer_pesquisa_spl = new System.Windows.Forms.Splitter();
            this.btn_pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_btn = new System.Windows.Forms.Button();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.validacao_pnl = new System.Windows.Forms.Panel();
            this.rem_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.h1_lbl = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.menu_spl = new System.Windows.Forms.Splitter();
            this.limpar_btn = new System.Windows.Forms.Button();
            this.pesquisa_tbc = new mrp_template.Componentes.TextBoxCE();
            this.main_pnl.SuspendLayout();
            this.listviewdiv_pnl.SuspendLayout();
            this.textobotaodiv_pnl.SuspendLayout();
            this.textbox_pesquisa_pnl.SuspendLayout();
            this.btn_pesquisa_pnl.SuspendLayout();
            this.validacao_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.corpo_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_spl
            // 
            this.status_spl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_spl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_spl.Location = new System.Drawing.Point(0, 578);
            this.status_spl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.status_spl.Name = "status_spl";
            this.status_spl.Size = new System.Drawing.Size(1008, 1);
            this.status_spl.TabIndex = 4;
            this.status_spl.TabStop = false;
            // 
            // spacer_esq_pnl
            // 
            this.spacer_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.spacer_esq_pnl.Name = "spacer_esq_pnl";
            this.spacer_esq_pnl.Size = new System.Drawing.Size(96, 702);
            this.spacer_esq_pnl.TabIndex = 4;
            // 
            // spacer_esq_spl
            // 
            this.spacer_esq_spl.Enabled = false;
            this.spacer_esq_spl.Location = new System.Drawing.Point(96, 0);
            this.spacer_esq_spl.Name = "spacer_esq_spl";
            this.spacer_esq_spl.Size = new System.Drawing.Size(3, 702);
            this.spacer_esq_spl.TabIndex = 6;
            this.spacer_esq_spl.TabStop = false;
            // 
            // spacer_dir_pnl
            // 
            this.spacer_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_pnl.Location = new System.Drawing.Point(895, 0);
            this.spacer_dir_pnl.Name = "spacer_dir_pnl";
            this.spacer_dir_pnl.Size = new System.Drawing.Size(96, 702);
            this.spacer_dir_pnl.TabIndex = 5;
            // 
            // spacer_dir_spl
            // 
            this.spacer_dir_spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_spl.Enabled = false;
            this.spacer_dir_spl.Location = new System.Drawing.Point(892, 0);
            this.spacer_dir_spl.Name = "spacer_dir_spl";
            this.spacer_dir_spl.Size = new System.Drawing.Size(3, 702);
            this.spacer_dir_spl.TabIndex = 7;
            this.spacer_dir_spl.TabStop = false;
            // 
            // main_pnl
            // 
            this.main_pnl.AutoSize = true;
            this.main_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.main_pnl.Controls.Add(this.listviewdiv_pnl);
            this.main_pnl.Controls.Add(this.textobotaodiv_pnl);
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_pnl.Location = new System.Drawing.Point(99, 120);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(793, 494);
            this.main_pnl.TabIndex = 1;
            // 
            // listviewdiv_pnl
            // 
            this.listviewdiv_pnl.Controls.Add(this.listapecas_lstvw);
            this.listviewdiv_pnl.Controls.Add(this.listapecas_spacer_pnl);
            this.listviewdiv_pnl.Controls.Add(this.listapecas_lbl);
            this.listviewdiv_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.listviewdiv_pnl.Location = new System.Drawing.Point(0, 74);
            this.listviewdiv_pnl.Name = "listviewdiv_pnl";
            this.listviewdiv_pnl.Size = new System.Drawing.Size(793, 420);
            this.listviewdiv_pnl.TabIndex = 6;
            // 
            // listapecas_lstvw
            // 
            this.listapecas_lstvw.AccessibleDescription = "lista de peças/produtos";
            this.listapecas_lstvw.AccessibleName = "";
            this.listapecas_lstvw.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listapecas_lstvw.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listapecas_lstvw.BackColor = System.Drawing.SystemColors.Control;
            this.listapecas_lstvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listapecas_lstvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listapecas_lstvw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listapecas_lstvw.FullRowSelect = true;
            this.listapecas_lstvw.HideSelection = false;
            this.listapecas_lstvw.Location = new System.Drawing.Point(0, 27);
            this.listapecas_lstvw.Name = "listapecas_lstvw";
            this.listapecas_lstvw.Size = new System.Drawing.Size(793, 381);
            this.listapecas_lstvw.TabIndex = 1;
            this.listapecas_lstvw.UseCompatibleStateImageBehavior = false;
            this.listapecas_lstvw.View = System.Windows.Forms.View.Details;
            this.listapecas_lstvw.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstviewPecas_ColumnClick);
            // 
            // listapecas_spacer_pnl
            // 
            this.listapecas_spacer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listapecas_spacer_pnl.Location = new System.Drawing.Point(0, 408);
            this.listapecas_spacer_pnl.Name = "listapecas_spacer_pnl";
            this.listapecas_spacer_pnl.Size = new System.Drawing.Size(793, 12);
            this.listapecas_spacer_pnl.TabIndex = 2;
            // 
            // listapecas_lbl
            // 
            this.listapecas_lbl.AutoSize = true;
            this.listapecas_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.listapecas_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listapecas_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listapecas_lbl.Location = new System.Drawing.Point(0, 0);
            this.listapecas_lbl.Name = "listapecas_lbl";
            this.listapecas_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.listapecas_lbl.Size = new System.Drawing.Size(144, 27);
            this.listapecas_lbl.TabIndex = 0;
            this.listapecas_lbl.Text = "Lista de Produtos Finais";
            // 
            // textobotaodiv_pnl
            // 
            this.textobotaodiv_pnl.Controls.Add(this.textbox_pesquisa_pnl);
            this.textobotaodiv_pnl.Controls.Add(this.spacer_pesquisa_spl);
            this.textobotaodiv_pnl.Controls.Add(this.btn_pesquisa_pnl);
            this.textobotaodiv_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.textobotaodiv_pnl.Location = new System.Drawing.Point(0, 0);
            this.textobotaodiv_pnl.Name = "textobotaodiv_pnl";
            this.textobotaodiv_pnl.Size = new System.Drawing.Size(793, 74);
            this.textobotaodiv_pnl.TabIndex = 5;
            // 
            // textbox_pesquisa_pnl
            // 
            this.textbox_pesquisa_pnl.Controls.Add(this.pesquisa_tbc);
            this.textbox_pesquisa_pnl.Controls.Add(this.pesquisa_spacerbaixo_pnl);
            this.textbox_pesquisa_pnl.Controls.Add(this.pesquisa_lbl);
            this.textbox_pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_pesquisa_pnl.Location = new System.Drawing.Point(0, 0);
            this.textbox_pesquisa_pnl.Name = "textbox_pesquisa_pnl";
            this.textbox_pesquisa_pnl.Size = new System.Drawing.Size(493, 74);
            this.textbox_pesquisa_pnl.TabIndex = 0;
            // 
            // pesquisa_spacerbaixo_pnl
            // 
            this.pesquisa_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pesquisa_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 62);
            this.pesquisa_spacerbaixo_pnl.Name = "pesquisa_spacerbaixo_pnl";
            this.pesquisa_spacerbaixo_pnl.Size = new System.Drawing.Size(493, 12);
            this.pesquisa_spacerbaixo_pnl.TabIndex = 2;
            // 
            // pesquisa_lbl
            // 
            this.pesquisa_lbl.AutoSize = true;
            this.pesquisa_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisa_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisa_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pesquisa_lbl.Location = new System.Drawing.Point(0, 0);
            this.pesquisa_lbl.Name = "pesquisa_lbl";
            this.pesquisa_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.pesquisa_lbl.Size = new System.Drawing.Size(88, 27);
            this.pesquisa_lbl.TabIndex = 0;
            this.pesquisa_lbl.Text = "ID do Produto";
            // 
            // spacer_pesquisa_spl
            // 
            this.spacer_pesquisa_spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_pesquisa_spl.Enabled = false;
            this.spacer_pesquisa_spl.Location = new System.Drawing.Point(493, 0);
            this.spacer_pesquisa_spl.Name = "spacer_pesquisa_spl";
            this.spacer_pesquisa_spl.Size = new System.Drawing.Size(24, 74);
            this.spacer_pesquisa_spl.TabIndex = 2;
            this.spacer_pesquisa_spl.TabStop = false;
            // 
            // btn_pesquisa_pnl
            // 
            this.btn_pesquisa_pnl.Controls.Add(this.limpar_btn);
            this.btn_pesquisa_pnl.Controls.Add(this.pesquisa_btn);
            this.btn_pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_pesquisa_pnl.Location = new System.Drawing.Point(517, 0);
            this.btn_pesquisa_pnl.Name = "btn_pesquisa_pnl";
            this.btn_pesquisa_pnl.Size = new System.Drawing.Size(276, 74);
            this.btn_pesquisa_pnl.TabIndex = 1;
            // 
            // pesquisa_btn
            // 
            this.pesquisa_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pesquisa_btn.Location = new System.Drawing.Point(6, 26);
            this.pesquisa_btn.Name = "pesquisa_btn";
            this.pesquisa_btn.Size = new System.Drawing.Size(130, 36);
            this.pesquisa_btn.TabIndex = 0;
            this.pesquisa_btn.Text = "Pesquisar";
            this.pesquisa_btn.UseVisualStyleBackColor = true;
            // 
            // footer_pnl
            // 
            this.footer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pnl.Location = new System.Drawing.Point(99, 678);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(793, 24);
            this.footer_pnl.TabIndex = 3;
            // 
            // validacao_pnl
            // 
            this.validacao_pnl.Controls.Add(this.rem_btn);
            this.validacao_pnl.Controls.Add(this.add_btn);
            this.validacao_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.validacao_pnl.Location = new System.Drawing.Point(99, 614);
            this.validacao_pnl.Name = "validacao_pnl";
            this.validacao_pnl.Size = new System.Drawing.Size(793, 64);
            this.validacao_pnl.TabIndex = 2;
            // 
            // rem_btn
            // 
            this.rem_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rem_btn.Location = new System.Drawing.Point(408, 16);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(130, 36);
            this.rem_btn.TabIndex = 1;
            this.rem_btn.Text = "Remover";
            this.rem_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.Location = new System.Drawing.Point(254, 16);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(130, 36);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Adicionar";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.h1_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(99, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(793, 120);
            this.header_pnl.TabIndex = 0;
            // 
            // h1_lbl
            // 
            this.h1_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.h1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1_lbl.Location = new System.Drawing.Point(0, 30);
            this.h1_lbl.Name = "h1_lbl";
            this.h1_lbl.Size = new System.Drawing.Size(793, 90);
            this.h1_lbl.TabIndex = 0;
            this.h1_lbl.Text = "Controle de Estoque de Produto Final";
            this.h1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
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
            this.corpo_pnl.Location = new System.Drawing.Point(0, 1);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(1008, 577);
            this.corpo_pnl.TabIndex = 0;
            // 
            // menu_spl
            // 
            this.menu_spl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu_spl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spl.Location = new System.Drawing.Point(0, 0);
            this.menu_spl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu_spl.Name = "menu_spl";
            this.menu_spl.Size = new System.Drawing.Size(1008, 1);
            this.menu_spl.TabIndex = 3;
            this.menu_spl.TabStop = false;
            // 
            // limpar_btn
            // 
            this.limpar_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.limpar_btn.Location = new System.Drawing.Point(146, 26);
            this.limpar_btn.Name = "limpar_btn";
            this.limpar_btn.Size = new System.Drawing.Size(130, 36);
            this.limpar_btn.TabIndex = 1;
            this.limpar_btn.Text = "Limpar";
            this.limpar_btn.UseVisualStyleBackColor = true;
            // 
            // pesquisa_tbc
            // 
            this.pesquisa_tbc.BackColor = System.Drawing.Color.Transparent;
            this.pesquisa_tbc.BorderColor = System.Drawing.Color.Gray;
            this.pesquisa_tbc.BorderSize = 1;
            this.pesquisa_tbc.Br = System.Drawing.Color.White;
            this.pesquisa_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesquisa_tbc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pesquisa_tbc.Location = new System.Drawing.Point(0, 27);
            this.pesquisa_tbc.Name = "pesquisa_tbc";
            this.pesquisa_tbc.PasswordChar = '\0';
            this.pesquisa_tbc.Size = new System.Drawing.Size(493, 35);
            this.pesquisa_tbc.TabIndex = 1;
            this.pesquisa_tbc.TabStop = false;
            this.pesquisa_tbc.Text = "Campo de Texto";
            this.pesquisa_tbc.TextboxRaio = 6;
            this.pesquisa_tbc.UseSystemPasswordChar = false;
            this.pesquisa_tbc.Enter += new System.EventHandler(this.TextBoxCE6Enter);
            this.pesquisa_tbc.Leave += new System.EventHandler(this.TextBoxCE6Leave);
            // 
            // main_form
            // 
            this.AccessibleDescription = "formulário principal";
            this.AccessibleName = "Gleiciane";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.corpo_pnl);
            this.Controls.Add(this.status_spl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu_spl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.Text = "Controle de Estoque de Produto Final";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.Resize += new System.EventHandler(this.Main_form_Resize);
            this.main_pnl.ResumeLayout(false);
            this.listviewdiv_pnl.ResumeLayout(false);
            this.listviewdiv_pnl.PerformLayout();
            this.textobotaodiv_pnl.ResumeLayout(false);
            this.textbox_pesquisa_pnl.ResumeLayout(false);
            this.textbox_pesquisa_pnl.PerformLayout();
            this.btn_pesquisa_pnl.ResumeLayout(false);
            this.validacao_pnl.ResumeLayout(false);
            this.header_pnl.ResumeLayout(false);
            this.corpo_pnl.ResumeLayout(false);
            this.corpo_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter status_spl;
        private System.Windows.Forms.Panel spacer_esq_pnl;
        private System.Windows.Forms.Splitter spacer_esq_spl;
        private System.Windows.Forms.Panel spacer_dir_pnl;
        private System.Windows.Forms.Splitter spacer_dir_spl;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label h1_lbl;
        private System.Windows.Forms.Panel listviewdiv_pnl;
        private System.Windows.Forms.ListView listapecas_lstvw;
        private System.Windows.Forms.Panel validacao_pnl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Label listapecas_lbl;
        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel listapecas_spacer_pnl;
        private System.Windows.Forms.Splitter menu_spl;
        private System.Windows.Forms.Panel textobotaodiv_pnl;
        private System.Windows.Forms.Panel textbox_pesquisa_pnl;
        private Componentes.TextBoxCE pesquisa_tbc;
        private System.Windows.Forms.Label pesquisa_lbl;
        private System.Windows.Forms.Splitter spacer_pesquisa_spl;
        private System.Windows.Forms.Panel btn_pesquisa_pnl;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel pesquisa_spacerbaixo_pnl;
        private System.Windows.Forms.Button limpar_btn;
    }
}

