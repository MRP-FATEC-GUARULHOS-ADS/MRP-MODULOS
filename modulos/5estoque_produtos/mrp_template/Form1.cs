using mrp_template.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mrp_template
{
    public partial class main_form : Form
    {
        // MessageBox.Show("teste"); debug

        // funcoes personalizadas
        /// dimensiona os elementos do layout em relacao ah statusbar
        private void RedimensionaPainelMeio()
        {
            // a "responsividade" que tem pra hoje
            // tamanho dos espaços laterais do formulário
            if (statusStrip.Width >= 1680)
            {
                spacer_esq_pnl.Width = 128;
                spacer_dir_pnl.Width = 128;
            } else if (statusStrip.Width >= 1280)
            {
                spacer_esq_pnl.Width = 96;
                spacer_dir_pnl.Width = 96;
            } else if (statusStrip.Width >= 800)
            {
                spacer_esq_pnl.Width = 64;
                spacer_dir_pnl.Width = 64;
            } else
            {
                spacer_esq_pnl.Width = 32;
                spacer_dir_pnl.Width = 32;
            }
                                   
            }
        /// remove o dummy text se o usuario foca na caixa de texto
        void ApagaDummy(TextBoxCE caixaTexto, string dummy)
        {
            if (caixaTexto.Text == dummy)
            {
                caixaTexto.Text = "";
                caixaTexto.ForeColor = SystemColors.ControlText;
            }
        }
        /// reescreve o dummy text se a caixa saiu de foco sem o usuario digitar nada
        void EscreveDummy(TextBoxCE caixaTexto, string dummy)
        {
            if (caixaTexto.Text == "")
            {
                caixaTexto.Text = dummy;
                caixaTexto.ForeColor = SystemColors.GrayText;
            }
        }

        // funcao principal
        public main_form()
        {
            // executa os comandos do arquivo Form1.Designer.cs
            InitializeComponent();
        }

        // eventos dos objetos
        /// eventos das textboxes
        //// executa quando a textbox entra em foco
               
        private void TextBoxCE6Enter(object sender, EventArgs e)
        {
            pesquisa_tbc.BorderColor = SystemColors.Highlight;
            ApagaDummy(pesquisa_tbc, "Campo de Texto");
        }
        private void TextBoxCE6Leave(object sender, EventArgs e)
        {
            pesquisa_tbc.BorderColor = Color.Gray;
            EscreveDummy(pesquisa_tbc, "Campo de Texto");
        }

        private void LstviewPecas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }

        /// eventos do formulario
        //// executa quando o form inicia
        private void Main_form_Load(object sender, EventArgs e)
        {
            // se não tiver barra de rolagem
            RedimensionaPainelMeio();

        }
        //// executa quando o form é redimensionado
        private void Main_form_Resize(object sender, EventArgs e)
        {
            RedimensionaPainelMeio();
        }
    }
}
