using System;
using System.Drawing;
using System.Windows.Forms;

using MRP_Fatec.Elementos;

namespace MRP_Fatec
{
    public partial class Painel : Form
    {
        // contrutor
        public Painel()
        {
            InitializeComponent();
        }

        // funções
        /// remove o dummy text se o usuario foca na caixa de texto
        public static void ApagaDummy(TextBoxCE caixaTexto, string dummy)
        {
            if (caixaTexto.Text == dummy)
            {
                caixaTexto.Text = "";
                caixaTexto.ForeColor = SystemColors.ControlText;
            }
            caixaTexto.BorderColor = SystemColors.Highlight;
        }
        /// reescreve o dummy text se a caixa saiu de foco sem o usuario digitar nada
        public static void EscreveDummy(TextBoxCE caixaTexto, string dummy)
        {
            if (caixaTexto.Text == "")
            {
                caixaTexto.Text = dummy;
                caixaTexto.ForeColor = SystemColors.GrayText;
            }
            caixaTexto.BorderColor = Color.Gray;
        }

        /// chama o Form de login
        private void ChamaLogin()
        {
            Form0_login login = new Form0_login();
            login.ShowDialog();
        }

        /// funções dos botões
        private void CadComp_BtnClick(object sender, EventArgs e)
        {
            cadastro_componentes.Main_form cadastro_form = new cadastro_componentes.Main_form();
            cadastro_form.ShowDialog();
        }

        private void EstComp_BtnClick(object sender, EventArgs e)
        {
            Controle_de_estoque_prod.Estoque_prod frm = new Controle_de_estoque_prod.Estoque_prod();
            frm.ShowDialog();
        }

        private void Compras_BtnClick(object sender, EventArgs e)
        {
            ModuloCompras.Form1 frm = new ModuloCompras.Form1();
            frm.ShowDialog();
        }

        private void CadProd_BtnClick(object sender, EventArgs e)
        {
            MRPPROJETO.FormCadProdFinal frm = new MRPPROJETO.FormCadProdFinal();
            frm.ShowDialog();
        }

        private void EstProd_BtnClick(object sender, EventArgs e)
        {
            // gambiarra pra substituir o modulo fantasma
            ///string caminho = Application.StartupPath;
            ///string exe = caminho + @"\..\..\..\modulos\5estoque_produtos\mrp_template.exe";
            ///Process.Start(exe);
            mrp_template.main_form frm = new mrp_template.main_form();
            frm.ShowDialog();
        }

        /// funções do menu
        private void CadComp_MenuClick(object sender, EventArgs e)
        {
            cadastro_componentes.Main_form cadastro_form = new cadastro_componentes.Main_form();
            cadastro_form.ShowDialog();
        }
        private void EstComp_MenuClick(object sender, EventArgs e)
        {
            Controle_de_estoque_prod.Estoque_prod frm = new Controle_de_estoque_prod.Estoque_prod();
            frm.ShowDialog();
        }
        private void Compras_MenuClick(object sender, EventArgs e)
        {
            ModuloCompras.Form1 frm = new ModuloCompras.Form1();
            frm.ShowDialog();
        }
        private void CadProd_MenuClick(object sender, EventArgs e)
        {
            MRPPROJETO.FormCadProdFinal frm = new MRPPROJETO.FormCadProdFinal();
            frm.ShowDialog();
        }
        private void EstProd_MenuClick(object sender, EventArgs e)
        {
            mrp_template.main_form frm = new mrp_template.main_form();
            frm.ShowDialog();
        }

        /// funções do formulário
        private void Main_form_Load(object sender, EventArgs e)
        {
            // carrega form de login
            ChamaLogin(); // desativar pra facilitar os testes
        }

    }
}
