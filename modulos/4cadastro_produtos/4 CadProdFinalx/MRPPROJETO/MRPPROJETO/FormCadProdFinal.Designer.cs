namespace MRPPROJETO
{
    partial class FormCadProdFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadProdFinal));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtDiscorigido = new System.Windows.Forms.TextBox();
            this.txtGabinete = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtPlacaMae = new System.Windows.Forms.TextBox();
            this.txtProcessador = new System.Windows.Forms.TextBox();
            this.txtCooler = new System.Windows.Forms.TextBox();
            this.txtPlacadeVideo = new System.Windows.Forms.TextBox();
            this.lblDiscoRigido = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPlacadeVideo = new System.Windows.Forms.Label();
            this.lblCooler = new System.Windows.Forms.Label();
            this.lblProcessador = new System.Windows.Forms.Label();
            this.lblPlacaMae = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblGabinete = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtNomedaEmpresa = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgProdutosFinais = new System.Windows.Forms.DataGridView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichasTécnicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgProdutosFinais)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(271, 105);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 14);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(385, 105);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 14);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(245, 124);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTipo.Location = new System.Drawing.Point(351, 124);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(482, 106);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 14);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Info;
            this.txtMarca.Location = new System.Drawing.Point(457, 124);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtModelo.Location = new System.Drawing.Point(563, 124);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 12;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.SystemColors.Info;
            this.txtAno.Location = new System.Drawing.Point(669, 124);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 13;
            // 
            // txtDiscorigido
            // 
            this.txtDiscorigido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDiscorigido.Location = new System.Drawing.Point(775, 124);
            this.txtDiscorigido.Name = "txtDiscorigido";
            this.txtDiscorigido.Size = new System.Drawing.Size(100, 20);
            this.txtDiscorigido.TabIndex = 14;
            // 
            // txtGabinete
            // 
            this.txtGabinete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtGabinete.Location = new System.Drawing.Point(245, 173);
            this.txtGabinete.Name = "txtGabinete";
            this.txtGabinete.Size = new System.Drawing.Size(100, 20);
            this.txtGabinete.TabIndex = 15;
            // 
            // txtRAM
            // 
            this.txtRAM.BackColor = System.Drawing.SystemColors.Info;
            this.txtRAM.Location = new System.Drawing.Point(351, 173);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(100, 20);
            this.txtRAM.TabIndex = 16;
            // 
            // txtPlacaMae
            // 
            this.txtPlacaMae.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPlacaMae.Location = new System.Drawing.Point(457, 173);
            this.txtPlacaMae.Name = "txtPlacaMae";
            this.txtPlacaMae.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaMae.TabIndex = 17;
            // 
            // txtProcessador
            // 
            this.txtProcessador.BackColor = System.Drawing.SystemColors.Info;
            this.txtProcessador.Location = new System.Drawing.Point(563, 173);
            this.txtProcessador.Name = "txtProcessador";
            this.txtProcessador.Size = new System.Drawing.Size(100, 20);
            this.txtProcessador.TabIndex = 18;
            // 
            // txtCooler
            // 
            this.txtCooler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCooler.Location = new System.Drawing.Point(669, 173);
            this.txtCooler.Name = "txtCooler";
            this.txtCooler.Size = new System.Drawing.Size(100, 20);
            this.txtCooler.TabIndex = 19;
            // 
            // txtPlacadeVideo
            // 
            this.txtPlacadeVideo.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlacadeVideo.Location = new System.Drawing.Point(775, 173);
            this.txtPlacadeVideo.Name = "txtPlacadeVideo";
            this.txtPlacadeVideo.Size = new System.Drawing.Size(100, 20);
            this.txtPlacadeVideo.TabIndex = 20;
            // 
            // lblDiscoRigido
            // 
            this.lblDiscoRigido.AutoSize = true;
            this.lblDiscoRigido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscoRigido.Location = new System.Drawing.Point(786, 106);
            this.lblDiscoRigido.Name = "lblDiscoRigido";
            this.lblDiscoRigido.Size = new System.Drawing.Size(81, 14);
            this.lblDiscoRigido.TabIndex = 21;
            this.lblDiscoRigido.Text = "Disco Rígido";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(704, 106);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(30, 14);
            this.lblAno.TabIndex = 22;
            this.lblAno.Text = "Ano";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(590, 106);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 14);
            this.lblModelo.TabIndex = 23;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPlacadeVideo
            // 
            this.lblPlacadeVideo.AutoSize = true;
            this.lblPlacadeVideo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacadeVideo.Location = new System.Drawing.Point(782, 154);
            this.lblPlacadeVideo.Name = "lblPlacadeVideo";
            this.lblPlacadeVideo.Size = new System.Drawing.Size(93, 14);
            this.lblPlacadeVideo.TabIndex = 24;
            this.lblPlacadeVideo.Text = "Placa de Vídeo";
            // 
            // lblCooler
            // 
            this.lblCooler.AutoSize = true;
            this.lblCooler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCooler.Location = new System.Drawing.Point(695, 154);
            this.lblCooler.Name = "lblCooler";
            this.lblCooler.Size = new System.Drawing.Size(45, 14);
            this.lblCooler.TabIndex = 25;
            this.lblCooler.Text = "Cooler";
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessador.Location = new System.Drawing.Point(576, 154);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(82, 14);
            this.lblProcessador.TabIndex = 26;
            this.lblProcessador.Text = "Processador";
            // 
            // lblPlacaMae
            // 
            this.lblPlacaMae.AutoSize = true;
            this.lblPlacaMae.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaMae.Location = new System.Drawing.Point(471, 154);
            this.lblPlacaMae.Name = "lblPlacaMae";
            this.lblPlacaMae.Size = new System.Drawing.Size(66, 14);
            this.lblPlacaMae.TabIndex = 27;
            this.lblPlacaMae.Text = "Placa Mãe";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.Location = new System.Drawing.Point(382, 154);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(47, 14);
            this.lblRam.TabIndex = 28;
            this.lblRam.Text = "R.A.M.";
            // 
            // lblGabinete
            // 
            this.lblGabinete.AutoSize = true;
            this.lblGabinete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGabinete.Location = new System.Drawing.Point(268, 154);
            this.lblGabinete.Name = "lblGabinete";
            this.lblGabinete.Size = new System.Drawing.Size(60, 14);
            this.lblGabinete.TabIndex = 29;
            this.lblGabinete.Text = "Gabinete";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(245, 228);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(524, 20);
            this.txtPesquisar.TabIndex = 31;
            // 
            // txtNomedaEmpresa
            // 
            this.txtNomedaEmpresa.BackColor = System.Drawing.Color.Silver;
            this.txtNomedaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomedaEmpresa.Location = new System.Drawing.Point(294, 40);
            this.txtNomedaEmpresa.Name = "txtNomedaEmpresa";
            this.txtNomedaEmpresa.Size = new System.Drawing.Size(525, 37);
            this.txtNomedaEmpresa.TabIndex = 33;
            this.txtNomedaEmpresa.Text = "SACO DE CARVÃO COMPUTADORES - SAC";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCadastrar.Location = new System.Drawing.Point(275, 410);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 34;
            this.BtnCadastrar.Text = "Cadastar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.SystemColors.Info;
            this.BtnConsultar.Location = new System.Drawing.Point(401, 410);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 35;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click_1);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAlterar.Location = new System.Drawing.Point(557, 410);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 36;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click_1);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Info;
            this.BtnExcluir.Location = new System.Drawing.Point(694, 410);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 37;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
            // 
            // DgProdutosFinais
            // 
            this.DgProdutosFinais.AllowUserToAddRows = false;
            this.DgProdutosFinais.AllowUserToDeleteRows = false;
            this.DgProdutosFinais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProdutosFinais.ContextMenuStrip = this.contextMenuStrip1;
            this.DgProdutosFinais.Location = new System.Drawing.Point(245, 254);
            this.DgProdutosFinais.Name = "DgProdutosFinais";
            this.DgProdutosFinais.ReadOnly = true;
            this.DgProdutosFinais.RowHeadersWidth = 51;
            this.DgProdutosFinais.Size = new System.Drawing.Size(524, 150);
            this.DgProdutosFinais.TabIndex = 38;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(780, 225);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 39;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichasTécnicasToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // fichasTécnicasToolStripMenuItem
            // 
            this.fichasTécnicasToolStripMenuItem.Name = "fichasTécnicasToolStripMenuItem";
            this.fichasTécnicasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fichasTécnicasToolStripMenuItem.Text = "Fichas Técnicas";
            this.fichasTécnicasToolStripMenuItem.Click += new System.EventHandler(this.fichasTécnicasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(648, 612);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(593, -172);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 42;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // FormCadProdFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::MRPPROJETO.Properties.Resources.Scc3;
            this.ClientSize = new System.Drawing.Size(1061, 552);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.DgProdutosFinais);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.txtNomedaEmpresa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblGabinete);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblPlacaMae);
            this.Controls.Add(this.lblProcessador);
            this.Controls.Add(this.lblCooler);
            this.Controls.Add(this.lblPlacadeVideo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDiscoRigido);
            this.Controls.Add(this.txtPlacadeVideo);
            this.Controls.Add(this.txtCooler);
            this.Controls.Add(this.txtProcessador);
            this.Controls.Add(this.txtPlacaMae);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtGabinete);
            this.Controls.Add(this.txtDiscorigido);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCadProdFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto Final";
            ((System.ComponentModel.ISupportInitialize)(this.DgProdutosFinais)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtDiscorigido;
        private System.Windows.Forms.TextBox txtGabinete;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtPlacaMae;
        private System.Windows.Forms.TextBox txtProcessador;
        private System.Windows.Forms.TextBox txtCooler;
        private System.Windows.Forms.TextBox txtPlacadeVideo;
        private System.Windows.Forms.Label lblDiscoRigido;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlacadeVideo;
        private System.Windows.Forms.Label lblCooler;
        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.Label lblPlacaMae;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblGabinete;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TextBox txtNomedaEmpresa;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgProdutosFinais;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichasTécnicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}

