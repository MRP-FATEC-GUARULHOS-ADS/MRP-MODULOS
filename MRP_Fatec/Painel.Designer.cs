namespace MRP_Fatec
{
    partial class Painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_estoqueFinal = new System.Windows.Forms.Button();
            this.BtnCadProdutoFinal = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.BtnControledeEstoqpProd = new System.Windows.Forms.Button();
            this.btn_cadastro_pecas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_estoqueFinal);
            this.panel1.Controls.Add(this.BtnCadProdutoFinal);
            this.panel1.Controls.Add(this.btn_compras);
            this.panel1.Controls.Add(this.BtnControledeEstoqpProd);
            this.panel1.Controls.Add(this.btn_cadastro_pecas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 77);
            this.panel1.TabIndex = 0;
            // 
            // btn_estoqueFinal
            // 
            this.btn_estoqueFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_estoqueFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estoqueFinal.Location = new System.Drawing.Point(646, 10);
            this.btn_estoqueFinal.Name = "btn_estoqueFinal";
            this.btn_estoqueFinal.Size = new System.Drawing.Size(100, 55);
            this.btn_estoqueFinal.TabIndex = 4;
            this.btn_estoqueFinal.Text = "Controle de Estoque de Produtos Finais";
            this.btn_estoqueFinal.UseVisualStyleBackColor = true;
            this.btn_estoqueFinal.Click += new System.EventHandler(this.btn_estoqueFinal_Click);
            // 
            // BtnCadProdutoFinal
            // 
            this.BtnCadProdutoFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCadProdutoFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadProdutoFinal.Location = new System.Drawing.Point(490, 11);
            this.BtnCadProdutoFinal.Name = "BtnCadProdutoFinal";
            this.BtnCadProdutoFinal.Size = new System.Drawing.Size(100, 55);
            this.BtnCadProdutoFinal.TabIndex = 3;
            this.BtnCadProdutoFinal.Text = "Cadastro de produtos";
            this.BtnCadProdutoFinal.UseVisualStyleBackColor = true;
            this.BtnCadProdutoFinal.Click += new System.EventHandler(this.BtnCadProdutoFinal_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compras.Location = new System.Drawing.Point(327, 11);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(100, 55);
            this.btn_compras.TabIndex = 2;
            this.btn_compras.Text = "Compras";
            this.btn_compras.UseVisualStyleBackColor = true;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // BtnControledeEstoqpProd
            // 
            this.BtnControledeEstoqpProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnControledeEstoqpProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnControledeEstoqpProd.Location = new System.Drawing.Point(176, 10);
            this.BtnControledeEstoqpProd.Name = "BtnControledeEstoqpProd";
            this.BtnControledeEstoqpProd.Size = new System.Drawing.Size(100, 55);
            this.BtnControledeEstoqpProd.TabIndex = 1;
            this.BtnControledeEstoqpProd.Text = "Controle de Estoque Para Produção";
            this.BtnControledeEstoqpProd.UseVisualStyleBackColor = true;
            this.BtnControledeEstoqpProd.Click += new System.EventHandler(this.BtnControledeEstoqpProd_Click);
            // 
            // btn_cadastro_pecas
            // 
            this.btn_cadastro_pecas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cadastro_pecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro_pecas.Location = new System.Drawing.Point(19, 10);
            this.btn_cadastro_pecas.Name = "btn_cadastro_pecas";
            this.btn_cadastro_pecas.Size = new System.Drawing.Size(100, 55);
            this.btn_cadastro_pecas.TabIndex = 0;
            this.btn_cadastro_pecas.Text = "Cadastro de Peças";
            this.btn_cadastro_pecas.UseVisualStyleBackColor = true;
            this.btn_cadastro_pecas.Click += new System.EventHandler(this.btn_cadastro_pecas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::MRP_Fatec.Properties.Resources.favicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(362, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MRP Saco de Carvão";
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel - MRP Saco de Carvão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_estoqueFinal;
        private System.Windows.Forms.Button BtnCadProdutoFinal;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button BtnControledeEstoqpProd;
        private System.Windows.Forms.Button btn_cadastro_pecas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}