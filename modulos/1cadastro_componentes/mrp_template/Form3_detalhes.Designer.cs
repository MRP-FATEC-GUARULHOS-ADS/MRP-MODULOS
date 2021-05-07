

namespace cadastro_componentes
{
    partial class Form3_detalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_detalhes));
            this.validacao_pnl = new System.Windows.Forms.Panel();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.specs_pnl = new System.Windows.Forms.Panel();
            this.modelo_pnl = new System.Windows.Forms.Panel();
            this.modelo_tbc_lbl = new System.Windows.Forms.Label();
            this.modelo_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.modelo_lbl = new System.Windows.Forms.Label();
            this.modelo_btn = new System.Windows.Forms.Button();
            this.marca_pnl = new System.Windows.Forms.Panel();
            this.marca_tbc_lbl = new System.Windows.Forms.Label();
            this.marca_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.marca_lbl = new System.Windows.Forms.Label();
            this.marca_btn = new System.Windows.Forms.Button();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.h3_lbl = new System.Windows.Forms.Label();
            this.spacer_dir_pnl = new System.Windows.Forms.Panel();
            this.spacer_esq_pnl = new System.Windows.Forms.Panel();
            this.header_spl = new System.Windows.Forms.Splitter();
            this.footer_spl = new System.Windows.Forms.Splitter();
            this.validacao_pnl.SuspendLayout();
            this.main_pnl.SuspendLayout();
            this.modelo_pnl.SuspendLayout();
            this.marca_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // validacao_pnl
            // 
            this.validacao_pnl.Controls.Add(this.ok_btn);
            this.validacao_pnl.Controls.Add(this.cancel_btn);
            this.validacao_pnl.Controls.Add(this.delete_btn);
            this.validacao_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.validacao_pnl.Location = new System.Drawing.Point(16, 296);
            this.validacao_pnl.Name = "validacao_pnl";
            this.validacao_pnl.Size = new System.Drawing.Size(320, 120);
            this.validacao_pnl.TabIndex = 0;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(172, 16);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(130, 36);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(18, 16);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(130, 36);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.delete_btn.Location = new System.Drawing.Point(95, 66);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(130, 36);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Excluir Peça";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // main_pnl
            // 
            this.main_pnl.AutoSize = true;
            this.main_pnl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.main_pnl.Controls.Add(this.specs_pnl);
            this.main_pnl.Controls.Add(this.modelo_pnl);
            this.main_pnl.Controls.Add(this.marca_pnl);
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_pnl.Location = new System.Drawing.Point(16, 55);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(320, 98);
            this.main_pnl.TabIndex = 2;
            // 
            // specs_pnl
            // 
            this.specs_pnl.AutoSize = true;
            this.specs_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.specs_pnl.Location = new System.Drawing.Point(0, 98);
            this.specs_pnl.Name = "specs_pnl";
            this.specs_pnl.Size = new System.Drawing.Size(320, 0);
            this.specs_pnl.TabIndex = 3;
            // 
            // modelo_pnl
            // 
            this.modelo_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.modelo_pnl.Controls.Add(this.modelo_tbc_lbl);
            this.modelo_pnl.Controls.Add(this.modelo_tbc);
            this.modelo_pnl.Controls.Add(this.modelo_lbl);
            this.modelo_pnl.Controls.Add(this.modelo_btn);
            this.modelo_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_pnl.Location = new System.Drawing.Point(0, 49);
            this.modelo_pnl.Name = "modelo_pnl";
            this.modelo_pnl.Size = new System.Drawing.Size(320, 49);
            this.modelo_pnl.TabIndex = 1;
            // 
            // modelo_tbc_lbl
            // 
            this.modelo_tbc_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelo_tbc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_tbc_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modelo_tbc_lbl.Location = new System.Drawing.Point(0, 21);
            this.modelo_tbc_lbl.Name = "modelo_tbc_lbl";
            this.modelo_tbc_lbl.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.modelo_tbc_lbl.Size = new System.Drawing.Size(292, 28);
            this.modelo_tbc_lbl.TabIndex = 2;
            // 
            // modelo_tbc
            // 
            this.modelo_tbc.BackColor = System.Drawing.Color.Transparent;
            this.modelo_tbc.BorderColor = System.Drawing.SystemColors.Control;
            this.modelo_tbc.BorderSize = 1;
            this.modelo_tbc.Br = System.Drawing.SystemColors.Control;
            this.modelo_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelo_tbc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modelo_tbc.Location = new System.Drawing.Point(0, 21);
            this.modelo_tbc.Name = "modelo_tbc";
            this.modelo_tbc.PasswordChar = '\0';
            this.modelo_tbc.Size = new System.Drawing.Size(292, 28);
            this.modelo_tbc.TabIndex = 1;
            this.modelo_tbc.TabStop = false;
            this.modelo_tbc.TextboxRaio = 6;
            this.modelo_tbc.UseSystemPasswordChar = false;
            this.modelo_tbc.Visible = false;
            // 
            // modelo_lbl
            // 
            this.modelo_lbl.AutoSize = true;
            this.modelo_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modelo_lbl.Location = new System.Drawing.Point(0, 0);
            this.modelo_lbl.Name = "modelo_lbl";
            this.modelo_lbl.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.modelo_lbl.Size = new System.Drawing.Size(103, 21);
            this.modelo_lbl.TabIndex = 0;
            this.modelo_lbl.Text = "Modelo da Peça";
            // 
            // modelo_btn
            // 
            this.modelo_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.modelo_btn.FlatAppearance.BorderSize = 0;
            this.modelo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_btn.Image = global::cadastro_componentes.Properties.Resources.Edit_icone;
            this.modelo_btn.Location = new System.Drawing.Point(292, 0);
            this.modelo_btn.Name = "modelo_btn";
            this.modelo_btn.Size = new System.Drawing.Size(28, 49);
            this.modelo_btn.TabIndex = 3;
            this.modelo_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.modelo_btn.UseVisualStyleBackColor = true;
            this.modelo_btn.Click += new System.EventHandler(this.Modelo_btn_Click);
            // 
            // marca_pnl
            // 
            this.marca_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.marca_pnl.Controls.Add(this.marca_tbc_lbl);
            this.marca_pnl.Controls.Add(this.marca_tbc);
            this.marca_pnl.Controls.Add(this.marca_lbl);
            this.marca_pnl.Controls.Add(this.marca_btn);
            this.marca_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_pnl.Location = new System.Drawing.Point(0, 0);
            this.marca_pnl.Name = "marca_pnl";
            this.marca_pnl.Size = new System.Drawing.Size(320, 49);
            this.marca_pnl.TabIndex = 0;
            // 
            // marca_tbc_lbl
            // 
            this.marca_tbc_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marca_tbc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_tbc_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.marca_tbc_lbl.Location = new System.Drawing.Point(0, 21);
            this.marca_tbc_lbl.Name = "marca_tbc_lbl";
            this.marca_tbc_lbl.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.marca_tbc_lbl.Size = new System.Drawing.Size(292, 28);
            this.marca_tbc_lbl.TabIndex = 2;
            // 
            // marca_tbc
            // 
            this.marca_tbc.BackColor = System.Drawing.Color.Transparent;
            this.marca_tbc.BorderColor = System.Drawing.SystemColors.Control;
            this.marca_tbc.BorderSize = 1;
            this.marca_tbc.Br = System.Drawing.SystemColors.Control;
            this.marca_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marca_tbc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.marca_tbc.Location = new System.Drawing.Point(0, 21);
            this.marca_tbc.Margin = new System.Windows.Forms.Padding(0);
            this.marca_tbc.Name = "marca_tbc";
            this.marca_tbc.PasswordChar = '\0';
            this.marca_tbc.Size = new System.Drawing.Size(292, 28);
            this.marca_tbc.TabIndex = 1;
            this.marca_tbc.TabStop = false;
            this.marca_tbc.TextboxRaio = 6;
            this.marca_tbc.UseSystemPasswordChar = false;
            this.marca_tbc.Visible = false;
            // 
            // marca_lbl
            // 
            this.marca_lbl.AutoSize = true;
            this.marca_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marca_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.marca_lbl.Location = new System.Drawing.Point(0, 0);
            this.marca_lbl.Name = "marca_lbl";
            this.marca_lbl.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.marca_lbl.Size = new System.Drawing.Size(96, 21);
            this.marca_lbl.TabIndex = 0;
            this.marca_lbl.Text = "Marca da Peça";
            // 
            // marca_btn
            // 
            this.marca_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.marca_btn.FlatAppearance.BorderSize = 0;
            this.marca_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marca_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_btn.Image = global::cadastro_componentes.Properties.Resources.Edit_icone;
            this.marca_btn.Location = new System.Drawing.Point(292, 0);
            this.marca_btn.Name = "marca_btn";
            this.marca_btn.Size = new System.Drawing.Size(28, 49);
            this.marca_btn.TabIndex = 3;
            this.marca_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.marca_btn.UseVisualStyleBackColor = true;
            this.marca_btn.Click += new System.EventHandler(this.Marca_btn_Click);
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.h3_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(16, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(320, 54);
            this.header_pnl.TabIndex = 1;
            // 
            // h3_lbl
            // 
            this.h3_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.h3_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h3_lbl.Location = new System.Drawing.Point(0, 12);
            this.h3_lbl.Name = "h3_lbl";
            this.h3_lbl.Size = new System.Drawing.Size(320, 42);
            this.h3_lbl.TabIndex = 0;
            this.h3_lbl.Text = "Placa Mãe - 11";
            this.h3_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spacer_dir_pnl
            // 
            this.spacer_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_pnl.Location = new System.Drawing.Point(336, 0);
            this.spacer_dir_pnl.Name = "spacer_dir_pnl";
            this.spacer_dir_pnl.Size = new System.Drawing.Size(16, 416);
            this.spacer_dir_pnl.TabIndex = 6;
            // 
            // spacer_esq_pnl
            // 
            this.spacer_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.spacer_esq_pnl.Name = "spacer_esq_pnl";
            this.spacer_esq_pnl.Size = new System.Drawing.Size(16, 416);
            this.spacer_esq_pnl.TabIndex = 5;
            // 
            // header_spl
            // 
            this.header_spl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.header_spl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_spl.Location = new System.Drawing.Point(16, 54);
            this.header_spl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header_spl.Name = "header_spl";
            this.header_spl.Size = new System.Drawing.Size(320, 1);
            this.header_spl.TabIndex = 3;
            this.header_spl.TabStop = false;
            // 
            // footer_spl
            // 
            this.footer_spl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.footer_spl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_spl.Location = new System.Drawing.Point(16, 295);
            this.footer_spl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer_spl.Name = "footer_spl";
            this.footer_spl.Size = new System.Drawing.Size(320, 1);
            this.footer_spl.TabIndex = 4;
            this.footer_spl.TabStop = false;
            // 
            // Form3_detalhes
            // 
            this.AcceptButton = this.ok_btn;
            this.AccessibleDescription = "formulário de detalhes da peça";
            this.AccessibleName = "Raquel";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(352, 416);
            this.Controls.Add(this.footer_spl);
            this.Controls.Add(this.validacao_pnl);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.header_spl);
            this.Controls.Add(this.header_pnl);
            this.Controls.Add(this.spacer_dir_pnl);
            this.Controls.Add(this.spacer_esq_pnl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3_detalhes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes da Peça";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_detalhes_FormClosing);
            this.Load += new System.EventHandler(this.Form3_detalhes_Load);
            this.validacao_pnl.ResumeLayout(false);
            this.main_pnl.ResumeLayout(false);
            this.main_pnl.PerformLayout();
            this.modelo_pnl.ResumeLayout(false);
            this.modelo_pnl.PerformLayout();
            this.marca_pnl.ResumeLayout(false);
            this.marca_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel validacao_pnl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Panel specs_pnl;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Label h3_lbl;
        private System.Windows.Forms.Panel spacer_dir_pnl;
        private System.Windows.Forms.Panel spacer_esq_pnl;
        private System.Windows.Forms.Splitter header_spl;
        private System.Windows.Forms.Splitter footer_spl;
        private System.Windows.Forms.Panel marca_pnl;
        private Componentes.TextBoxCE marca_tbc;
        private System.Windows.Forms.Button marca_btn;
        private System.Windows.Forms.Label marca_lbl;
        private System.Windows.Forms.Panel modelo_pnl;
        private System.Windows.Forms.Label modelo_tbc_lbl;
        private Componentes.TextBoxCE modelo_tbc;
        private System.Windows.Forms.Button modelo_btn;
        private System.Windows.Forms.Label modelo_lbl;
        private System.Windows.Forms.Label marca_tbc_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}