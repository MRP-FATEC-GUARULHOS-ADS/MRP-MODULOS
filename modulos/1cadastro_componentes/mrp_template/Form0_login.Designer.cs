using cadastro_componentes.Componentes;

namespace cadastro_componentes
{
    partial class Form0_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0_login));
            this.validacao_pnl = new System.Windows.Forms.Panel();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.footer_pnl = new System.Windows.Forms.Panel();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.senha_pnl = new System.Windows.Forms.Panel();
            this.senha_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.senha_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.senha_lbl = new System.Windows.Forms.Label();
            this.user_pnl = new System.Windows.Forms.Panel();
            this.user_tbc = new cadastro_componentes.Componentes.TextBoxCE();
            this.user_spacerbaixo_pnl = new System.Windows.Forms.Panel();
            this.user_lbl = new System.Windows.Forms.Label();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.h2_lbl = new System.Windows.Forms.Label();
            this.spacer_dir_spl = new System.Windows.Forms.Splitter();
            this.spacer_dir_pnl = new System.Windows.Forms.Panel();
            this.spacer_esq_spl = new System.Windows.Forms.Splitter();
            this.spacer_esq_pnl = new System.Windows.Forms.Panel();
            this.validacao_pnl.SuspendLayout();
            this.main_pnl.SuspendLayout();
            this.senha_pnl.SuspendLayout();
            this.user_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // validacao_pnl
            // 
            this.validacao_pnl.Controls.Add(this.ok_btn);
            this.validacao_pnl.Controls.Add(this.cancel_btn);
            this.validacao_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.validacao_pnl.Location = new System.Drawing.Point(35, 229);
            this.validacao_pnl.Name = "validacao_pnl";
            this.validacao_pnl.Size = new System.Drawing.Size(426, 60);
            this.validacao_pnl.TabIndex = 2;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok_btn.Enabled = false;
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(233, 14);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(130, 36);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "Entrar";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(79, 14);
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
            this.footer_pnl.Location = new System.Drawing.Point(35, 289);
            this.footer_pnl.Name = "footer_pnl";
            this.footer_pnl.Size = new System.Drawing.Size(426, 24);
            this.footer_pnl.TabIndex = 3;
            // 
            // main_pnl
            // 
            this.main_pnl.AutoSize = true;
            this.main_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.main_pnl.Controls.Add(this.senha_pnl);
            this.main_pnl.Controls.Add(this.user_pnl);
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_pnl.Location = new System.Drawing.Point(35, 80);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(426, 148);
            this.main_pnl.TabIndex = 1;
            // 
            // senha_pnl
            // 
            this.senha_pnl.Controls.Add(this.senha_tbc);
            this.senha_pnl.Controls.Add(this.senha_spacerbaixo_pnl);
            this.senha_pnl.Controls.Add(this.senha_lbl);
            this.senha_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.senha_pnl.Location = new System.Drawing.Point(0, 74);
            this.senha_pnl.Name = "senha_pnl";
            this.senha_pnl.Size = new System.Drawing.Size(426, 74);
            this.senha_pnl.TabIndex = 1;
            // 
            // senha_tbc
            // 
            this.senha_tbc.BackColor = System.Drawing.Color.Transparent;
            this.senha_tbc.BorderColor = System.Drawing.Color.Gray;
            this.senha_tbc.BorderSize = 1;
            this.senha_tbc.Br = System.Drawing.Color.White;
            this.senha_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senha_tbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_tbc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.senha_tbc.Location = new System.Drawing.Point(0, 27);
            this.senha_tbc.Name = "senha_tbc";
            this.senha_tbc.PasswordChar = '\0';
            this.senha_tbc.Size = new System.Drawing.Size(426, 35);
            this.senha_tbc.TabIndex = 1;
            this.senha_tbc.TabStop = false;
            this.senha_tbc.Text = "Senha";
            this.senha_tbc.TextboxRaio = 6;
            this.senha_tbc.UseSystemPasswordChar = false;
            this.senha_tbc.TextChanged += new System.EventHandler(this.TextBoxSenhaChanged);
            this.senha_tbc.Enter += new System.EventHandler(this.TextBoxSenhaEnter);
            this.senha_tbc.Leave += new System.EventHandler(this.TextBoxSenhaLeave);
            // 
            // senha_spacerbaixo_pnl
            // 
            this.senha_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.senha_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 62);
            this.senha_spacerbaixo_pnl.Name = "senha_spacerbaixo_pnl";
            this.senha_spacerbaixo_pnl.Size = new System.Drawing.Size(426, 12);
            this.senha_spacerbaixo_pnl.TabIndex = 2;
            // 
            // senha_lbl
            // 
            this.senha_lbl.AutoSize = true;
            this.senha_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.senha_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.senha_lbl.Location = new System.Drawing.Point(0, 0);
            this.senha_lbl.Name = "senha_lbl";
            this.senha_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.senha_lbl.Size = new System.Drawing.Size(49, 27);
            this.senha_lbl.TabIndex = 0;
            this.senha_lbl.Text = "Senha";
            // 
            // user_pnl
            // 
            this.user_pnl.Controls.Add(this.user_tbc);
            this.user_pnl.Controls.Add(this.user_spacerbaixo_pnl);
            this.user_pnl.Controls.Add(this.user_lbl);
            this.user_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_pnl.Location = new System.Drawing.Point(0, 0);
            this.user_pnl.Name = "user_pnl";
            this.user_pnl.Size = new System.Drawing.Size(426, 74);
            this.user_pnl.TabIndex = 0;
            // 
            // user_tbc
            // 
            this.user_tbc.BackColor = System.Drawing.Color.Transparent;
            this.user_tbc.BorderColor = System.Drawing.Color.Gray;
            this.user_tbc.BorderSize = 1;
            this.user_tbc.Br = System.Drawing.Color.White;
            this.user_tbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_tbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tbc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.user_tbc.Location = new System.Drawing.Point(0, 27);
            this.user_tbc.Name = "user_tbc";
            this.user_tbc.PasswordChar = '\0';
            this.user_tbc.Size = new System.Drawing.Size(426, 35);
            this.user_tbc.TabIndex = 1;
            this.user_tbc.TabStop = false;
            this.user_tbc.Text = "Usuário";
            this.user_tbc.TextboxRaio = 6;
            this.user_tbc.UseSystemPasswordChar = false;
            this.user_tbc.TextChanged += new System.EventHandler(this.TextBoxUserChanged);
            this.user_tbc.Enter += new System.EventHandler(this.TextBoxUserEnter);
            this.user_tbc.Leave += new System.EventHandler(this.TextBoxUserLeave);
            // 
            // user_spacerbaixo_pnl
            // 
            this.user_spacerbaixo_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.user_spacerbaixo_pnl.Location = new System.Drawing.Point(0, 62);
            this.user_spacerbaixo_pnl.Name = "user_spacerbaixo_pnl";
            this.user_spacerbaixo_pnl.Size = new System.Drawing.Size(426, 12);
            this.user_spacerbaixo_pnl.TabIndex = 2;
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.user_lbl.Location = new System.Drawing.Point(0, 0);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.user_lbl.Size = new System.Drawing.Size(56, 27);
            this.user_lbl.TabIndex = 0;
            this.user_lbl.Text = "Usuário";
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.h2_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(35, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(426, 80);
            this.header_pnl.TabIndex = 0;
            // 
            // h2_lbl
            // 
            this.h2_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.h2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2_lbl.Location = new System.Drawing.Point(0, 32);
            this.h2_lbl.Name = "h2_lbl";
            this.h2_lbl.Size = new System.Drawing.Size(426, 48);
            this.h2_lbl.TabIndex = 0;
            this.h2_lbl.Text = "Login";
            this.h2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacer_dir_spl
            // 
            this.spacer_dir_spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_spl.Enabled = false;
            this.spacer_dir_spl.Location = new System.Drawing.Point(461, 0);
            this.spacer_dir_spl.Name = "spacer_dir_spl";
            this.spacer_dir_spl.Size = new System.Drawing.Size(3, 313);
            this.spacer_dir_spl.TabIndex = 7;
            this.spacer_dir_spl.TabStop = false;
            // 
            // spacer_dir_pnl
            // 
            this.spacer_dir_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spacer_dir_pnl.Location = new System.Drawing.Point(464, 0);
            this.spacer_dir_pnl.Name = "spacer_dir_pnl";
            this.spacer_dir_pnl.Size = new System.Drawing.Size(32, 313);
            this.spacer_dir_pnl.TabIndex = 5;
            // 
            // spacer_esq_spl
            // 
            this.spacer_esq_spl.Enabled = false;
            this.spacer_esq_spl.Location = new System.Drawing.Point(32, 0);
            this.spacer_esq_spl.Name = "spacer_esq_spl";
            this.spacer_esq_spl.Size = new System.Drawing.Size(3, 313);
            this.spacer_esq_spl.TabIndex = 6;
            this.spacer_esq_spl.TabStop = false;
            // 
            // spacer_esq_pnl
            // 
            this.spacer_esq_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacer_esq_pnl.Location = new System.Drawing.Point(0, 0);
            this.spacer_esq_pnl.Name = "spacer_esq_pnl";
            this.spacer_esq_pnl.Size = new System.Drawing.Size(32, 313);
            this.spacer_esq_pnl.TabIndex = 4;
            // 
            // Form0_login
            // 
            this.AcceptButton = this.ok_btn;
            this.AccessibleDescription = "form de login";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(496, 313);
            this.Controls.Add(this.validacao_pnl);
            this.Controls.Add(this.footer_pnl);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.header_pnl);
            this.Controls.Add(this.spacer_dir_spl);
            this.Controls.Add(this.spacer_dir_pnl);
            this.Controls.Add(this.spacer_esq_spl);
            this.Controls.Add(this.spacer_esq_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form0_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form0_login_FormClosing);
            this.Load += new System.EventHandler(this.Form0_login_Load);
            this.validacao_pnl.ResumeLayout(false);
            this.main_pnl.ResumeLayout(false);
            this.senha_pnl.ResumeLayout(false);
            this.senha_pnl.PerformLayout();
            this.user_pnl.ResumeLayout(false);
            this.user_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel validacao_pnl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel footer_pnl;
        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Panel senha_pnl;
        private cadastro_componentes.Componentes.TextBoxCE senha_tbc;
        private System.Windows.Forms.Panel senha_spacerbaixo_pnl;
        private System.Windows.Forms.Label senha_lbl;
        private System.Windows.Forms.Panel user_pnl;
        private cadastro_componentes.Componentes.TextBoxCE user_tbc;
        private System.Windows.Forms.Panel user_spacerbaixo_pnl;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Label h2_lbl;
        private System.Windows.Forms.Splitter spacer_dir_spl;
        private System.Windows.Forms.Panel spacer_dir_pnl;
        private System.Windows.Forms.Splitter spacer_esq_spl;
        private System.Windows.Forms.Panel spacer_esq_pnl;
    }
}