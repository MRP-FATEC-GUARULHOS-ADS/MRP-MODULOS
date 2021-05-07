using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_Fatec
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void btn_cadastro_pecas_Click(object sender, EventArgs e)
        {
            cadastro_componentes.Main_form cadastro_form = new cadastro_componentes.Main_form();
            cadastro_form.ShowDialog();
        }

        private void BtnControledeEstoqpProd_Click(object sender, EventArgs e)
        {
            Controle_de_estoque_prod.Estoque_prod frm = new Controle_de_estoque_prod.Estoque_prod();
            frm.ShowDialog();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            ModuloCompras.Form1 frm = new ModuloCompras.Form1();
            frm.ShowDialog();
        }

        private void BtnCadProdutoFinal_Click(object sender, EventArgs e)
        {
            MRPPROJETO.FormCadProdFinal frm = new MRPPROJETO.FormCadProdFinal();
            frm.ShowDialog();
        }

        private void btn_estoqueFinal_Click(object sender, EventArgs e)
        {
            // gambiarra pra substituir o modulo fantasma
            string caminho = Application.StartupPath;
            string exe = caminho + @"\..\..\..\modulos\5estoque_produtos\mrp_template.exe";
            Process.Start(exe);
            //EstoqueFinal.main_form frm = new EstoqueFinal.main_form();
            //frm.ShowDialog();
        }
    }
}
