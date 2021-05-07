namespace cadastro_componentes
{
    partial class Sec_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sec_form));
            this.corpo_pnl = new System.Windows.Forms.Panel();
            this.validacao_pnl = new System.Windows.Forms.Panel();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.specs_pnl = new System.Windows.Forms.Panel();
            this.spacer_specs_pnl = new System.Windows.Forms.Panel();
            this.modelo_pnl = new System.Windows.Forms.Panel();
            this.modelo_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.modelo_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.modelo_lbl = new System.Windows.Forms.Label();
            this.marca_pnl = new System.Windows.Forms.Panel();
            this.marca_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.marca_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.marca_lbl = new System.Windows.Forms.Label();
            this.tipo_pnl = new System.Windows.Forms.Panel();
            this.tipo_cbc = new cadastro_componentes.Componentes.ComboBoxCE();
            this.tipo_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.tipo_lbl = new System.Windows.Forms.Label();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.h2_lbl = new System.Windows.Forms.Label();
            this.spacer_dir_spl = new System.Windows.Forms.Splitter();
            this.spacer_dir_pnl = new System.Windows.Forms.Panel();
            this.spacer_esq_spl = new System.Windows.Forms.Splitter();
            this.spacer_esq_pnl = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status_spl = new System.Windows.Forms.Splitter();
            this.corpo_pnl.SuspendLayout();
            this.validacao_pnl.SuspendLayout();
            this.main_pnl.SuspendLayout();
            this.modelo_pnl.SuspendLayout();
            this.marca_pnl.SuspendLayout();
            this.tipo_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
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
            this.corpo_pnl.Size = new System.Drawing.Size(432, 578);
            this.corpo_pnl.TabIndex = 1;
            // 
            // validacao_pnl
            // 
            this.validacao_pnl.Controls.Add(this.ok_btn);
            this.validacao_pnl.Controls.Add(this.cancel_btn);
            this.validacao_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.validacao_pnl.Location = new System.Drawing.Point(35, 490);
            this.validacao_pnl.Name = "validacao_pnl";
            this.validacao_pnl.Size = new System.Drawing.Size(362, 64);
            this.validacao_pnl.TabIndex = 2;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok_btn.Enabled = false;
            this.ok_btn.Location = new System.Drawing.Point(192, 16);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(130, 36);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_btn.Location = new System.Drawing.Point(38, 16);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(130, 36);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // footer_pnl
            // 
            this.footer_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pnl.Location = new System.Drawing.Point(35, 554);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(362, 24);
            this.footer_pnl.TabIndex = 3;
            // 
            // main_pnl
            // 
            this.main_pnl.AutoSize = true;
            this.main_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.main_pnl.Controls.Add(this.specs_pnl);
            this.main_pnl.Controls.Add(this.spacer_specs_pnl);
            this.main_pnl.Controls.Add(this.modelo_pnl);
            this.main_pnl.Controls.Add(this.marca_pnl);
            this.main_pnl.Controls.Add(this.tipo_pnl);
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_pnl.Location = new System.Drawing.Point(35, 96);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(362, 246);
            this.main_pnl.TabIndex = 1;
            // 
            // specs_pnl
            // 
            this.specs_pnl.AutoSize = true;
            this.specs_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.specs_pnl.Location = new System.Drawing.Point(0, 246);
            this.specs_pnl.Name = "specs_pnl";
            this.specs_pnl.Size = new System.Drawing.Size(362, 0);
            this.specs_pnl.TabIndex = 5;
            // 
            // spacer_specs_pnl
            // 
            this.spacer_specs_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer_specs_pnl.Location = new System.Drawing.Point(0, 222);
            this.spacer_specs_pnl.Name = "spacer_specs_pnl";
            this.spacer_specs_pnl.Size = new System.Drawing.Size(362, 24);
            this.spacer_specs_pnl.TabIndex = 3;
            // 
            // modelo_pnl
            // 
            this.modelo_pnl.Controls.Add(this.modelo_tbc);
            this.modelo_pnl.Controls.Add(this.modelo_spacerbaixo_pnl);
            this.modelo_pnl.Controls.Add(this.modelo_lbl);
            this.modelo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_pnl.Location = new System.Drawing.Point(0, 148);
            this.modelo_pnl.Name = "modelo_pnl";
            this.modelo_pnl.Size = new System.Drawing.Size(362, 74);
            this.modelo_pnl.TabIndex = 2;
            this.modelo_pnl.Visible = false;
            // 
            // modelo_tbc
            // 
            this.modelo_tbc.BackColor = System.Drawing.Color.Transparent;
            this.modelo_tbc.BorderColor = System.Drawing.Color.Gray;
            this.modelo_tbc.BorderSize = 1;
            this.modelo_tbc.Br = System.Drawing.Color.White;
            this.modelo_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelo_tbc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.modelo_tbc.Location = new System.Drawing.Point(0, 27);
            this.modelo_tbc.Name = "modelo_tbc";
            this.modelo_tbc.PasswordChar = '\0';
            this.modelo_tbc.Size = new System.Drawing.Size(362, 35);
            this.modelo_tbc.TabIndex = 1;
            this.modelo_tbc.TabStop = false;
            this.modelo_tbc.Text = "Modelo da Peça";
            this.modelo_tbc.TextboxRaio = 6;
            this.modelo_tbc.UseSystemPasswordChar = false;
            this.modelo_tbc.TextChanged += new System.EventHandler(this.ModeloTextChanged);
            this.modelo_tbc.Enter += new System.EventHandler(this.ModeloEnter);
            this.modelo_tbc.Leave += new System.EventHandler(this.ModeloLeave);
            // 
            // modelo_spacerbaixo_pnl
            // 
            this.modelo_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modelo_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 62);
            this.modelo_spacerbaixo_pnl.Name = "modelo_spacerbaixo_pnl";
            this.modelo_spacerbaixo_pnl.Size = new System.Drawing.Size(362, 12);
            this.modelo_spacerbaixo_pnl.TabIndex = 2;
            // 
            // modelo_lbl
            // 
            this.modelo_lbl.AutoSize = true;
            this.modelo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modelo_lbl.Location = new System.Drawing.Point(0, 0);
            this.modelo_lbl.Name = "modelo_lbl";
            this.modelo_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.modelo_lbl.Size = new System.Drawing.Size(103, 27);
            this.modelo_lbl.TabIndex = 0;
            this.modelo_lbl.Text = "Modelo da Peça";
            // 
            // marca_pnl
            // 
            this.marca_pnl.Controls.Add(this.marca_tbc);
            this.marca_pnl.Controls.Add(this.marca_spacerbaixo_pnl);
            this.marca_pnl.Controls.Add(this.marca_lbl);
            this.marca_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_pnl.Location = new System.Drawing.Point(0, 74);
            this.marca_pnl.Name = "marca_pnl";
            this.marca_pnl.Size = new System.Drawing.Size(362, 74);
            this.marca_pnl.TabIndex = 1;
            this.marca_pnl.Visible = false;
            // 
            // marca_tbc
            // 
            this.marca_tbc.BackColor = System.Drawing.Color.Transparent;
            this.marca_tbc.BorderColor = System.Drawing.Color.Gray;
            this.marca_tbc.BorderSize = 1;
            this.marca_tbc.Br = System.Drawing.Color.White;
            this.marca_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marca_tbc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.marca_tbc.Location = new System.Drawing.Point(0, 27);
            this.marca_tbc.Name = "marca_tbc";
            this.marca_tbc.PasswordChar = '\0';
            this.marca_tbc.Size = new System.Drawing.Size(362, 35);
            this.marca_tbc.TabIndex = 1;
            this.marca_tbc.TabStop = false;
            this.marca_tbc.Text = "Marca da Peça";
            this.marca_tbc.TextboxRaio = 6;
            this.marca_tbc.UseSystemPasswordChar = false;
            this.marca_tbc.TextChanged += new System.EventHandler(this.MarcaTextChanged);
            this.marca_tbc.Enter += new System.EventHandler(this.MarcaEnter);
            this.marca_tbc.Leave += new System.EventHandler(this.MarcaLeave);
            // 
            // marca_spacerbaixo_pnl
            // 
            this.marca_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marca_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 62);
            this.marca_spacerbaixo_pnl.Name = "marca_spacerbaixo_pnl";
            this.marca_spacerbaixo_pnl.Size = new System.Drawing.Size(362, 12);
            this.marca_spacerbaixo_pnl.TabIndex = 2;
            // 
            // marca_lbl
            // 
            this.marca_lbl.AutoSize = true;
            this.marca_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.marca_lbl.Location = new System.Drawing.Point(0, 0);
            this.marca_lbl.Name = "marca_lbl";
            this.marca_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.marca_lbl.Size = new System.Drawing.Size(96, 27);
            this.marca_lbl.TabIndex = 0;
            this.marca_lbl.Text = "Marca da Peça";
            // 
            // tipo_pnl
            // 
            this.tipo_pnl.Controls.Add(this.tipo_cbc);
            this.tipo_pnl.Controls.Add(this.tipo_spacerbaixo_pnl);
            this.tipo_pnl.Controls.Add(this.tipo_lbl);
            this.tipo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipo_pnl.Location = new System.Drawing.Point(0, 0);
            this.tipo_pnl.Name = "tipo_pnl";
            this.tipo_pnl.Size = new System.Drawing.Size(362, 74);
            this.tipo_pnl.TabIndex = 0;
            // 
            // tipo_cbc
            // 
            this.tipo_cbc.BackColor = System.Drawing.Color.Transparent;
            this.tipo_cbc.BorderColor = System.Drawing.Color.Gray;
            this.tipo_cbc.BorderSize = 1;
            this.tipo_cbc.Br = System.Drawing.Color.White;
            this.tipo_cbc.ComboBoxRaio = 6;
            this.tipo_cbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipo_cbc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tipo_cbc.Location = new System.Drawing.Point(0, 27);
            this.tipo_cbc.Name = "tipo_cbc";
            this.tipo_cbc.Size = new System.Drawing.Size(362, 35);
            this.tipo_cbc.TabIndex = 1;
            this.tipo_cbc.TabStop = false;
            this.tipo_cbc.Text = "Tipo de Peça";
            this.tipo_cbc.TextChanged += new System.EventHandler(this.TipoChange);
            this.tipo_cbc.Enter += new System.EventHandler(this.TipoEnter);
            this.tipo_cbc.Leave += new System.EventHandler(this.TipoLeave);
            // 
            // tipo_spacerbaixo_pnl
            // 
            this.tipo_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tipo_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 62);
            this.tipo_spacerbaixo_pnl.Name = "tipo_spacerbaixo_pnl";
            this.tipo_spacerbaixo_pnl.Size = new System.Drawing.Size(362, 12);
            this.tipo_spacerbaixo_pnl.TabIndex = 2;
            // 
            // tipo_lbl
            // 
            this.tipo_lbl.AutoSize = true;
            this.tipo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipo_lbl.Location = new System.Drawing.Point(0, 0);
            this.tipo_lbl.Name = "tipo_lbl";
            this.tipo_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.tipo_lbl.Size = new System.Drawing.Size(85, 27);
            this.tipo_lbl.TabIndex = 0;
            this.tipo_lbl.Text = "Tipo de Peça";
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.h2_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(35, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(362, 96);
            this.header_pnl.TabIndex = 0;
            // 
            // h2_lbl
            // 
            this.h2_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.h2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2_lbl.Location = new System.Drawing.Point(0, 32);
            this.h2_lbl.Name = "h2_lbl";
            this.h2_lbl.Size = new System.Drawing.Size(362, 64);
            this.h2_lbl.TabIndex = 0;
            this.h2_lbl.Text = "Nova Peça";
            this.h2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacer_dir_spl
            // 
            this.spacer_dir_spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_spl.Enabled = false;
            this.spacer_dir_spl.Location = new System.Drawing.Point(397, 0);
            this.spacer_dir_spl.Name = "spacer_dir_spl";
            this.spacer_dir_spl.Size = new System.Drawing.Size(3, 578);
            this.spacer_dir_spl.TabIndex = 7;
            this.spacer_dir_spl.TabStop = false;
            // 
            // spacer_dir_pnl
            // 
            this.spacer_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_pnl.Location = new System.Drawing.Point(400, 0);
            this.spacer_dir_pnl.Name = "spacer_dir_pnl";
            this.spacer_dir_pnl.Size = new System.Drawing.Size(32, 578);
            this.spacer_dir_pnl.TabIndex = 5;
            // 
            // spacer_esq_spl
            // 
            this.spacer_esq_spl.Enabled = false;
            this.spacer_esq_spl.Location = new System.Drawing.Point(32, 0);
            this.spacer_esq_spl.Name = "spacer_esq_spl";
            this.spacer_esq_spl.Size = new System.Drawing.Size(3, 578);
            this.spacer_esq_spl.TabIndex = 6;
            this.spacer_esq_spl.TabStop = false;
            // 
            // spacer_esq_pnl
            // 
            this.spacer_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.spacer_esq_pnl.Name = "spacer_esq_pnl";
            this.spacer_esq_pnl.Size = new System.Drawing.Size(32, 578);
            this.spacer_esq_pnl.TabIndex = 4;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(432, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // status_spl
            // 
            this.status_spl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.status_spl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_spl.Location = new System.Drawing.Point(0, 578);
            this.status_spl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.status_spl.Name = "status_spl";
            this.status_spl.Size = new System.Drawing.Size(432, 1);
            this.status_spl.TabIndex = 0;
            this.status_spl.TabStop = false;
            // 
            // Sec_form
            // 
            this.AccessibleDescription = "formulário secundário";
            this.AccessibleName = "Altair";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(432, 601);
            this.Controls.Add(this.corpo_pnl);
            this.Controls.Add(this.status_spl);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Sec_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Nova Peça";
            this.Load += new System.EventHandler(this.Secform_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Sec_form_KeyUp);
            this.Resize += new System.EventHandler(this.Secform_Resize);
            this.corpo_pnl.ResumeLayout(false);
            this.corpo_pnl.PerformLayout();
            this.validacao_pnl.ResumeLayout(false);
            this.main_pnl.ResumeLayout(false);
            this.main_pnl.PerformLayout();
            this.modelo_pnl.ResumeLayout(false);
            this.modelo_pnl.PerformLayout();
            this.marca_pnl.ResumeLayout(false);
            this.marca_pnl.PerformLayout();
            this.tipo_pnl.ResumeLayout(false);
            this.tipo_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel corpo_pnl;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel validacao_pnl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel marca_pnl;
        private Componentes.TextBoxCE marca_tbc;
        private System.Windows.Forms.Label marca_lbl;
        private System.Windows.Forms.Panel tipo_pnl;
        private System.Windows.Forms.Label tipo_lbl;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Label h2_lbl;
        private System.Windows.Forms.Splitter spacer_dir_spl;
        private System.Windows.Forms.Panel spacer_dir_pnl;
        private System.Windows.Forms.Splitter spacer_esq_spl;
        private System.Windows.Forms.Panel spacer_esq_pnl;
        private System.Windows.Forms.Panel modelo_pnl;
        private Componentes.TextBoxCE modelo_tbc;
        private System.Windows.Forms.Label modelo_lbl;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Splitter status_spl;
        private System.Windows.Forms.Panel tipo_spacerbaixo_pnl;
        private System.Windows.Forms.Panel modelo_spacerbaixo_pnl;
        private System.Windows.Forms.Panel marca_spacerbaixo_pnl;
        private System.Windows.Forms.Panel spacer_specs_pnl;
        private System.Windows.Forms.Panel specs_pnl;
        private Componentes.ComboBoxCE tipo_cbc;
    }
}