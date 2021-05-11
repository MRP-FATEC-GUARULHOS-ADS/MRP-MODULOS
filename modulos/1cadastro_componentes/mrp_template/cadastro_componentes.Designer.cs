namespace cadastro_componentes
{
    partial class Main_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.status_spl = new System.Windows.Forms.Splitter();
            this.spacer_esq_pnl = new System.Windows.Forms.Panel();
            this.spacer_esq_spl = new System.Windows.Forms.Splitter();
            this.spacer_dir_pnl = new System.Windows.Forms.Panel();
            this.spacer_dir_spl = new System.Windows.Forms.Splitter();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.listapecas_pnl = new System.Windows.Forms.Panel();
            this.listapecas_lstvw = new System.Windows.Forms.ListView();
            this.codigo_clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo_clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marca_clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelo_clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spec_clm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listapecas_spacer_pnl = new System.Windows.Forms.Panel();
            this.listapecas_lbl = new System.Windows.Forms.Label();
            this.cadastro_pesquisa_pnl = new System.Windows.Forms.Panel();
            this.textbox_pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.pesquisa_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_lbl = new System.Windows.Forms.Label();
            this.spacer_pesquisa_spl = new System.Windows.Forms.Splitter();
            this.btn_pesquisa_pnl = new System.Windows.Forms.Panel();
            this.pesquisa_btn = new System.Windows.Forms.Button();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.h1_lbl = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Funcoes_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Cadastrar_tsmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.Editar_tsmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ajuda_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ajuda_tsmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.Equipe_tsmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_spl = new System.Windows.Forms.Splitter();
            this.main_pnl.SuspendLayout();
            this.listapecas_pnl.SuspendLayout();
            this.cadastro_pesquisa_pnl.SuspendLayout();
            this.textbox_pesquisa_pnl.SuspendLayout();
            this.btn_pesquisa_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.corpo_pnl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_spl
            // 
            this.status_spl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_spl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_spl.Enabled = false;
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
            this.spacer_esq_pnl.Size = new System.Drawing.Size(96, 553);
            this.spacer_esq_pnl.TabIndex = 4;
            // 
            // spacer_esq_spl
            // 
            this.spacer_esq_spl.Enabled = false;
            this.spacer_esq_spl.Location = new System.Drawing.Point(96, 0);
            this.spacer_esq_spl.Name = "spacer_esq_spl";
            this.spacer_esq_spl.Size = new System.Drawing.Size(3, 553);
            this.spacer_esq_spl.TabIndex = 6;
            this.spacer_esq_spl.TabStop = false;
            // 
            // spacer_dir_pnl
            // 
            this.spacer_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_pnl.Location = new System.Drawing.Point(912, 0);
            this.spacer_dir_pnl.Name = "spacer_dir_pnl";
            this.spacer_dir_pnl.Size = new System.Drawing.Size(96, 553);
            this.spacer_dir_pnl.TabIndex = 5;
            // 
            // spacer_dir_spl
            // 
            this.spacer_dir_spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_spl.Enabled = false;
            this.spacer_dir_spl.Location = new System.Drawing.Point(909, 0);
            this.spacer_dir_spl.Name = "spacer_dir_spl";
            this.spacer_dir_spl.Size = new System.Drawing.Size(3, 553);
            this.spacer_dir_spl.TabIndex = 7;
            this.spacer_dir_spl.TabStop = false;
            // 
            // main_pnl
            // 
            this.main_pnl.AutoSize = true;
            this.main_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.main_pnl.Controls.Add(this.listapecas_pnl);
            this.main_pnl.Controls.Add(this.cadastro_pesquisa_pnl);
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_pnl.Location = new System.Drawing.Point(99, 112);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(810, 417);
            this.main_pnl.TabIndex = 1;
            // 
            // listapecas_pnl
            // 
            this.listapecas_pnl.Controls.Add(this.listapecas_lstvw);
            this.listapecas_pnl.Controls.Add(this.listapecas_spacer_pnl);
            this.listapecas_pnl.Controls.Add(this.listapecas_lbl);
            this.listapecas_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listapecas_pnl.Location = new System.Drawing.Point(0, 80);
            this.listapecas_pnl.Name = "listapecas_pnl";
            this.listapecas_pnl.Size = new System.Drawing.Size(810, 337);
            this.listapecas_pnl.TabIndex = 6;
            // 
            // listapecas_lstvw
            // 
            this.listapecas_lstvw.AccessibleDescription = "lista de peças/produtos";
            this.listapecas_lstvw.AccessibleName = "henrique";
            this.listapecas_lstvw.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listapecas_lstvw.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listapecas_lstvw.BackColor = System.Drawing.SystemColors.Control;
            this.listapecas_lstvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listapecas_lstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo_clm,
            this.tipo_clm,
            this.marca_clm,
            this.modelo_clm,
            this.spec_clm});
            this.listapecas_lstvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listapecas_lstvw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listapecas_lstvw.FullRowSelect = true;
            this.listapecas_lstvw.HideSelection = false;
            this.listapecas_lstvw.Location = new System.Drawing.Point(0, 27);
            this.listapecas_lstvw.MultiSelect = false;
            this.listapecas_lstvw.Name = "listapecas_lstvw";
            this.listapecas_lstvw.Size = new System.Drawing.Size(810, 298);
            this.listapecas_lstvw.TabIndex = 1;
            this.listapecas_lstvw.UseCompatibleStateImageBehavior = false;
            this.listapecas_lstvw.View = System.Windows.Forms.View.Details;
            this.listapecas_lstvw.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstviewPecas_ColumnClick);
            this.listapecas_lstvw.ItemActivate += new System.EventHandler(this.Listapecas_lstvw_ItemActivate);
            this.listapecas_lstvw.SelectedIndexChanged += new System.EventHandler(this.Listapecas_lstvw_SelectedIndexChanged);
            // 
            // codigo_clm
            // 
            this.codigo_clm.Text = "código";
            this.codigo_clm.Width = 89;
            // 
            // tipo_clm
            // 
            this.tipo_clm.Text = "tipo";
            this.tipo_clm.Width = 137;
            // 
            // marca_clm
            // 
            this.marca_clm.Text = "marca";
            this.marca_clm.Width = 143;
            // 
            // modelo_clm
            // 
            this.modelo_clm.Text = "modelo";
            this.modelo_clm.Width = 195;
            // 
            // spec_clm
            // 
            this.spec_clm.Text = "especificações";
            this.spec_clm.Width = 207;
            // 
            // listapecas_spacer_pnl
            // 
            this.listapecas_spacer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listapecas_spacer_pnl.Location = new System.Drawing.Point(0, 325);
            this.listapecas_spacer_pnl.Name = "listapecas_spacer_pnl";
            this.listapecas_spacer_pnl.Size = new System.Drawing.Size(810, 12);
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
            this.listapecas_lbl.Size = new System.Drawing.Size(93, 27);
            this.listapecas_lbl.TabIndex = 0;
            this.listapecas_lbl.Text = "Lista de Peças";
            // 
            // cadastro_pesquisa_pnl
            // 
            this.cadastro_pesquisa_pnl.Controls.Add(this.textbox_pesquisa_pnl);
            this.cadastro_pesquisa_pnl.Controls.Add(this.spacer_pesquisa_spl);
            this.cadastro_pesquisa_pnl.Controls.Add(this.btn_pesquisa_pnl);
            this.cadastro_pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadastro_pesquisa_pnl.Location = new System.Drawing.Point(0, 0);
            this.cadastro_pesquisa_pnl.Name = "cadastro_pesquisa_pnl";
            this.cadastro_pesquisa_pnl.Size = new System.Drawing.Size(810, 80);
            this.cadastro_pesquisa_pnl.TabIndex = 5;
            // 
            // textbox_pesquisa_pnl
            // 
            this.textbox_pesquisa_pnl.Controls.Add(this.pesquisa_tbc);
            this.textbox_pesquisa_pnl.Controls.Add(this.pesquisa_spacerbaixo_pnl);
            this.textbox_pesquisa_pnl.Controls.Add(this.pesquisa_lbl);
            this.textbox_pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_pesquisa_pnl.Location = new System.Drawing.Point(216, 0);
            this.textbox_pesquisa_pnl.Name = "textbox_pesquisa_pnl";
            this.textbox_pesquisa_pnl.Size = new System.Drawing.Size(594, 80);
            this.textbox_pesquisa_pnl.TabIndex = 0;
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
            this.pesquisa_tbc.Size = new System.Drawing.Size(594, 41);
            this.pesquisa_tbc.TabIndex = 1;
            this.pesquisa_tbc.TabStop = false;
            this.pesquisa_tbc.Text = "Pesquisar Peças";
            this.pesquisa_tbc.TextboxRaio = 6;
            this.pesquisa_tbc.UseSystemPasswordChar = false;
            this.pesquisa_tbc.TextChanged += new System.EventHandler(this.Pesquisa_tbc_TextChanged);
            this.pesquisa_tbc.Enter += new System.EventHandler(this.TextBoxCE6Enter);
            this.pesquisa_tbc.Leave += new System.EventHandler(this.TextBoxCE6Leave);
            // 
            // pesquisa_spacerbaixo_pnl
            // 
            this.pesquisa_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pesquisa_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 68);
            this.pesquisa_spacerbaixo_pnl.Name = "pesquisa_spacerbaixo_pnl";
            this.pesquisa_spacerbaixo_pnl.Size = new System.Drawing.Size(594, 12);
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
            this.pesquisa_lbl.Size = new System.Drawing.Size(68, 27);
            this.pesquisa_lbl.TabIndex = 0;
            this.pesquisa_lbl.Text = "Pesquisar";
            // 
            // spacer_pesquisa_spl
            // 
            this.spacer_pesquisa_spl.Enabled = false;
            this.spacer_pesquisa_spl.Location = new System.Drawing.Point(192, 0);
            this.spacer_pesquisa_spl.Name = "spacer_pesquisa_spl";
            this.spacer_pesquisa_spl.Size = new System.Drawing.Size(24, 80);
            this.spacer_pesquisa_spl.TabIndex = 2;
            this.spacer_pesquisa_spl.TabStop = false;
            // 
            // btn_pesquisa_pnl
            // 
            this.btn_pesquisa_pnl.Controls.Add(this.pesquisa_btn);
            this.btn_pesquisa_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_pesquisa_pnl.Location = new System.Drawing.Point(0, 0);
            this.btn_pesquisa_pnl.Name = "btn_pesquisa_pnl";
            this.btn_pesquisa_pnl.Size = new System.Drawing.Size(192, 80);
            this.btn_pesquisa_pnl.TabIndex = 1;
            // 
            // pesquisa_btn
            // 
            this.pesquisa_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pesquisa_btn.Location = new System.Drawing.Point(0, 26);
            this.pesquisa_btn.Name = "pesquisa_btn";
            this.pesquisa_btn.Size = new System.Drawing.Size(192, 42);
            this.pesquisa_btn.TabIndex = 0;
            this.pesquisa_btn.Text = "Cadastrar nova Peça";
            this.pesquisa_btn.UseVisualStyleBackColor = true;
            this.pesquisa_btn.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // footer_pnl
            // 
            this.footer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pnl.Location = new System.Drawing.Point(99, 529);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(810, 24);
            this.footer_pnl.TabIndex = 3;
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.h1_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(99, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(810, 112);
            this.header_pnl.TabIndex = 0;
            // 
            // h1_lbl
            // 
            this.h1_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.h1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1_lbl.Location = new System.Drawing.Point(0, 32);
            this.h1_lbl.Name = "h1_lbl";
            this.h1_lbl.Size = new System.Drawing.Size(810, 80);
            this.h1_lbl.TabIndex = 0;
            this.h1_lbl.Text = "Cadastro de peças";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // corpo_pnl
            // 
            this.corpo_pnl.AutoScroll = true;
            this.corpo_pnl.Controls.Add(this.main_pnl);
            this.corpo_pnl.Controls.Add(this.footer_pnl);
            this.corpo_pnl.Controls.Add(this.header_pnl);
            this.corpo_pnl.Controls.Add(this.spacer_dir_spl);
            this.corpo_pnl.Controls.Add(this.spacer_dir_pnl);
            this.corpo_pnl.Controls.Add(this.spacer_esq_spl);
            this.corpo_pnl.Controls.Add(this.spacer_esq_pnl);
            this.corpo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corpo_pnl.Location = new System.Drawing.Point(0, 25);
            this.corpo_pnl.Name = "corpo_pnl";
            this.corpo_pnl.Size = new System.Drawing.Size(1008, 553);
            this.corpo_pnl.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Funcoes_tsmi,
            this.Ajuda_tsmi});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Funcoes_tsmi
            // 
            this.Funcoes_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastrar_tsmsi,
            this.Editar_tsmsi});
            this.Funcoes_tsmi.Name = "Funcoes_tsmi";
            this.Funcoes_tsmi.Size = new System.Drawing.Size(66, 20);
            this.Funcoes_tsmi.Text = "Funções";
            // 
            // Cadastrar_tsmsi
            // 
            this.Cadastrar_tsmsi.Name = "Cadastrar_tsmsi";
            this.Cadastrar_tsmsi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Cadastrar_tsmsi.Size = new System.Drawing.Size(227, 22);
            this.Cadastrar_tsmsi.Text = "Cadastrar nova peça";
            this.Cadastrar_tsmsi.ToolTipText = "Abre o formulário de cadastro de novas peças";
            this.Cadastrar_tsmsi.Click += new System.EventHandler(this.Cadastrar_tsmsi_Click);
            // 
            // Editar_tsmsi
            // 
            this.Editar_tsmsi.Enabled = false;
            this.Editar_tsmsi.Name = "Editar_tsmsi";
            this.Editar_tsmsi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Editar_tsmsi.Size = new System.Drawing.Size(227, 22);
            this.Editar_tsmsi.Text = "Editar peça";
            this.Editar_tsmsi.ToolTipText = "Abre o formulário de informações da peça selecionada";
            this.Editar_tsmsi.Click += new System.EventHandler(this.Editar_tsmsi_Click);
            // 
            // Ajuda_tsmi
            // 
            this.Ajuda_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ajuda_tsmsi,
            this.Equipe_tsmsi});
            this.Ajuda_tsmi.Name = "Ajuda_tsmi";
            this.Ajuda_tsmi.Size = new System.Drawing.Size(50, 20);
            this.Ajuda_tsmi.Text = "Ajuda";
            // 
            // Ajuda_tsmsi
            // 
            this.Ajuda_tsmsi.Name = "Ajuda_tsmsi";
            this.Ajuda_tsmsi.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.Ajuda_tsmsi.Size = new System.Drawing.Size(160, 22);
            this.Ajuda_tsmsi.Text = "Exibir ajuda";
            this.Ajuda_tsmsi.ToolTipText = "Abre a página de ajuda do programa";
            this.Ajuda_tsmsi.Click += new System.EventHandler(this.Ajuda_tsmsi_Click);
            // 
            // Equipe_tsmsi
            // 
            this.Equipe_tsmsi.Name = "Equipe_tsmsi";
            this.Equipe_tsmsi.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.Equipe_tsmsi.Size = new System.Drawing.Size(160, 22);
            this.Equipe_tsmsi.Text = "Sobre";
            this.Equipe_tsmsi.ToolTipText = "Abre a página de informações dos desenvolvedores do programa";
            this.Equipe_tsmsi.Click += new System.EventHandler(this.Equipe_tsmsi_Click);
            // 
            // menu_spl
            // 
            this.menu_spl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu_spl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_spl.Enabled = false;
            this.menu_spl.Location = new System.Drawing.Point(0, 24);
            this.menu_spl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu_spl.Name = "menu_spl";
            this.menu_spl.Size = new System.Drawing.Size(1008, 1);
            this.menu_spl.TabIndex = 3;
            this.menu_spl.TabStop = false;
            // 
            // Main_form
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
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(16, 50);
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peças";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.Resize += new System.EventHandler(this.Main_form_Resize);
            this.main_pnl.ResumeLayout(false);
            this.listapecas_pnl.ResumeLayout(false);
            this.listapecas_pnl.PerformLayout();
            this.cadastro_pesquisa_pnl.ResumeLayout(false);
            this.textbox_pesquisa_pnl.ResumeLayout(false);
            this.textbox_pesquisa_pnl.PerformLayout();
            this.btn_pesquisa_pnl.ResumeLayout(false);
            this.header_pnl.ResumeLayout(false);
            this.corpo_pnl.ResumeLayout(false);
            this.corpo_pnl.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel listapecas_pnl;
        private System.Windows.Forms.ListView listapecas_lstvw;
        private System.Windows.Forms.ColumnHeader codigo_clm;
        private System.Windows.Forms.ColumnHeader tipo_clm;
        private System.Windows.Forms.ColumnHeader marca_clm;
        private System.Windows.Forms.ColumnHeader modelo_clm;
        private System.Windows.Forms.ColumnHeader spec_clm;
        private System.Windows.Forms.Label listapecas_lbl;
        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel listapecas_spacer_pnl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Funcoes_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Cadastrar_tsmsi;
        private System.Windows.Forms.ToolStripMenuItem Editar_tsmsi;
        private System.Windows.Forms.ToolStripMenuItem Ajuda_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Equipe_tsmsi;
        private System.Windows.Forms.ToolStripMenuItem Ajuda_tsmsi;
        private System.Windows.Forms.Splitter menu_spl;
        private System.Windows.Forms.Panel cadastro_pesquisa_pnl;
        private System.Windows.Forms.Panel textbox_pesquisa_pnl;
        private Componentes.TextBoxCE pesquisa_tbc;
        private System.Windows.Forms.Label pesquisa_lbl;
        private System.Windows.Forms.Splitter spacer_pesquisa_spl;
        private System.Windows.Forms.Panel btn_pesquisa_pnl;
        private System.Windows.Forms.Button pesquisa_btn;
        private System.Windows.Forms.Panel pesquisa_spacerbaixo_pnl;
    }
}

