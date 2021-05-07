using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using cadastro_componentes.Componentes;

namespace cadastro_componentes
{
    public partial class Main_form : Form
    {
        // MessageBox.Show("teste"); debug

        // funcoes personalizadas
        /// dimensiona os elementos do layout em relacao ah statusbar
        public static void RedimensionaLaterais(StatusStrip statusStrip, Panel spacer_esq_pnl, Panel spacer_dir_pnl)
        {
            // a "responsividade" que tem pra hoje
            // tamanho dos espaços laterais do formulário
            if (statusStrip.Width >= 1680)
            {
                spacer_esq_pnl.Width = 128;
                spacer_dir_pnl.Width = 128;
            }
            else if (statusStrip.Width >= 1280)
            {
                spacer_esq_pnl.Width = 96;
                spacer_dir_pnl.Width = 96;
            }
            else if (statusStrip.Width >= 800)
            {
                spacer_esq_pnl.Width = 64;
                spacer_dir_pnl.Width = 64;
            }
            else
            {
                spacer_esq_pnl.Width = 32;
                spacer_dir_pnl.Width = 32;
            }
        }
        private void Responsividade()
        {
            RedimensionaLaterais(statusStrip, spacer_esq_pnl, spacer_dir_pnl);
            // tamanhos dos elementos do layout
            // int espacadores_largura = 24; // espaçadores sempre tem 24 de largura, se quiser mudar, mude no design e nessa variavel
            int corpo_largura = (int)(statusStrip.Width - (spacer_esq_pnl.Width + spacer_dir_pnl.Width) - 6); // 6 é o tamanho dos spinners que separam os elementos
            int lstvw_largura = (int)(corpo_largura - 16); // 16 é o tamanho da barra de rolagem da lista

            // tamanho das colunas da ListView
            // tente fazer a largura das coluna somar 1
            // codigo
            listapecas_lstvw.Columns[0].Width = (int)(lstvw_largura * .10);
            // tipo
            listapecas_lstvw.Columns[1].Width = (int)(lstvw_largura * .16);
            // marca
            listapecas_lstvw.Columns[2].Width = (int)(lstvw_largura * .18);
            // modelo
            listapecas_lstvw.Columns[3].Width = (int)(lstvw_largura * .24);
            // specs
            listapecas_lstvw.Columns[4].Width = (int)(lstvw_largura * .32);
        }

        /// colore a lista de pecas
        public void ColoreLista(ListView lista, Color corUm, Color corDois)
        {
            for (int i = 0; i < lista.Items.Count; i += 1)
                lista.Items[i].BackColor = (i % 2 == 0) ? corUm : corDois;
        }

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

        /// carrega o banco de dados em um dataset
        public void InitMsAccessSingleton()
        {
            // limpa o dataset do bancodedados
            data.Clear();

            using (OleDbConnection conexaoAccess = MRP_DB.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoAccess.Open();
                    // cria o adapter e preenche o dataset
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * from tb_cadpecas", conexaoAccess);
                    adapter.Fill(data);
                }
                catch (OleDbException oledbex)
                {
                    // ou não
                    MessageBox.Show("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    // fecha a conexao
                    conexaoAccess.Close();
                }
            }
        }

        /// carrega os dados na lista de peças
        public void ListaDados()
        {
            // limpa a lista
            listapecas_lstvw.Items.Clear();

            DataTable dt = data.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                string codigo = dr["tbCP_Codigo"].ToString();
                string tipo = dr["tbCP_Tipo"].ToString();
                string marca = dr["tbCP_Marca"].ToString();
                string modelo = dr["tbCP_Modelo"].ToString();
                string specs = dr["tbCP_Especificacoes"].ToString();

                // adiciona os 0 na frente do codigo
                string codLead = codigo.ToString().PadLeft(8, '0');

                ListViewItem listitem = new ListViewItem(codLead);
                listitem.SubItems.Add(tipo);
                listitem.SubItems.Add(marca);
                listitem.SubItems.Add(modelo);
                listitem.SubItems.Add(specs);
                listapecas_lstvw.Items.Add(listitem);
            }

            // sorta as peças por tipo
            lvwColumnSorter.SortColumn = 1;
            lvwColumnSorter.Order = SortOrder.Ascending;
            this.listapecas_lstvw.Sort();

            // colore a lista de peças
            ColoreLista(listapecas_lstvw, SystemColors.Control, SystemColors.ControlLight);
        }
        /// carrega os dados nas sugestoes da pesquisa
        public void SugereDados()
        {
            DataTable dt = data.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                string codigo = dr["tbCP_Codigo"].ToString();
                string tipo = dr["tbCP_Tipo"].ToString();
                string marca = dr["tbCP_Marca"].ToString();
                string modelo = dr["tbCP_Modelo"].ToString();

                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(codigo);
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(tipo);
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(marca);
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(modelo);
            }
        }

        /// chama o Form de login
        private void ChamaLogin()
        {
            Form0_login login = new Form0_login();
            login.ShowDialog();
        }
        /// chama o Form de cadastro
        private void ChamaCadastro()
        {
            Sec_form cadastro = new Sec_form();
            cadastro.ShowDialog();

            // se algum produto foi cadastrado
            if (Sec_form.isCadastrado)
            {
                // recarrega o banco de dados no dataset
                InitMsAccessSingleton();

                DataRow dr = data.Tables[0].Rows[data.Tables[0].Rows.Count - 1];

                // adiciona o novo item na lista
                ListViewItem listitem = new ListViewItem(
                    dr["tbCP_Codigo"].ToString().PadLeft(8, '0')
                );
                listitem.SubItems.Add(
                    dr["tbCP_Tipo"].ToString()
                );
                listitem.SubItems.Add(
                    dr["tbCP_Marca"].ToString()
                );
                listitem.SubItems.Add(
                    dr["tbCP_Modelo"].ToString()
                );
                listitem.SubItems.Add(
                    dr["tbCP_Especificacoes"].ToString()
                );
                listapecas_lstvw.Items.Add(listitem);

                // sorta as peças por tipo
                lvwColumnSorter.SortColumn = 1;
                lvwColumnSorter.Order = SortOrder.Ascending;
                this.listapecas_lstvw.Sort();
                // colore a lista de peças
                ColoreLista(listapecas_lstvw, SystemColors.Control, SystemColors.ControlLight);

                // adiciona o novo item nas sugestoes de pesquisa
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(
                    dr["tbCP_Codigo"].ToString()
                );
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(
                    dr["tbCP_Tipo"].ToString()
                );
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(
                    dr["tbCP_Marca"].ToString()
                );
                pesquisa_tbc.textbox.AutoCompleteCustomSource.Add(
                    dr["tbCP_Modelo"].ToString()
                );
            }
        }
        /// chama o Form de detalhe da peça
        private void ChamaDetalhe(string codigo, string tipo, string marca, string modelo, string specs)
        {
            Form3_detalhes detalhe = new Form3_detalhes(codigo, tipo, marca, modelo, specs);
            detalhe.ShowDialog();

            if (Form3_detalhes.isEditado)
            {
                // carrega dados
                InitMsAccessSingleton();
                ListaDados();

                // sugestoes de pesquisa
                SugereDados();
            }
        }

        /// avalia o tipo da peça e retorna as especificações
        public static List<string> GetSpecNomes(string tipo)
        {
            List<string> specs = new List<string>();
            switch (tipo)
            {
                case "hd":
                    specs.Add("Formato");
                    specs.Add("Capacidade");
                    specs.Add("RPM");
                    break;
                case "ssd":
                    specs.Add("Capacidade");
                    specs.Add("Interface");
                    break;
                case "memória ram":
                    specs.Add("Medidas (mm x mm x mm)");
                    specs.Add("Capacidade");
                    specs.Add("DDR");
                    specs.Add("Frequência");
                    break;
                case "placa mãe":
                    specs.Add("Formato");
                    specs.Add("Socket");
                    specs.Add("Quantidade de slots de memória RAM");
                    specs.Add("Slots de Expansão");
                    break;
                case "processador":
                    specs.Add("Núcleos");
                    specs.Add("Threads");
                    specs.Add("Memória Cache");
                    specs.Add("Socket");
                    specs.Add("Frequência Base");
                    specs.Add("Turbo");
                    break;
                case "placa de vídeo":
                    specs.Add("Medidas (mm x mm x mm)");
                    specs.Add("Memória");
                    specs.Add("GDDR");
                    specs.Add("Barramento");
                    break;
                default:
                    specs.Clear();
                    break;
            }
            return specs;
        }

        //// abrir arquivo externamente
        private void AbreArquivo(string caminho)
        {
            string caminhoInicial = Application.StartupPath;
            string caminhoArquivo = caminhoInicial.Substring(0, caminhoInicial.Length - 9) + caminho;
            System.Diagnostics.Process.Start(caminhoArquivo);
        }

        // variáveis
        /// variavel a ser preenchida com o banco de dados
        readonly public static DataSet data = new DataSet();

        /// variavel pra ordenar a lista de pecas pelos headers das colunas
        readonly private ListViewColumnSorter lvwColumnSorter;

        // funcao principal
        public Main_form()
        {
            // executa os comandos do arquivo Form1.Designer.cs
            InitializeComponent();

            // auto-complete da caixa de pesquisa
            pesquisa_tbc.textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            pesquisa_tbc.textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // ordenar a lista de pecas pelos headers das colunas
            lvwColumnSorter = new ListViewColumnSorter();
            this.listapecas_lstvw.ListViewItemSorter = lvwColumnSorter;
        }

        // eventos dos objetos
        /// eventos das textboxes
        //// executa quando a textbox entra em foco
        private void TextBoxCE6Enter(object sender, EventArgs e)
        {
            // apaga o texto dummy, usa dois elementos, um é o nome do elemento que vai ser mudado, o outro é o texto que vai ser escrito
            // esse texto DEVE ser igual ao da função de Leave e a propriedade Text da aba de design
            ApagaDummy(pesquisa_tbc, "Pesquisar Peças");
        }
        //// executa quando a textbox sai de foco
        private void TextBoxCE6Leave(object sender, EventArgs e)
        {
            EscreveDummy(pesquisa_tbc, "Pesquisar Peças");
        }
        //// executa quando o texto da textbox eh alterado
        private void Pesquisa_tbc_TextChanged(object sender, EventArgs e)
        {
            // Se o nao for dummy text
            if (pesquisa_tbc.Text != "Pesquisar Peças")
            {
                // Se o banco contiver o objeto da pesquisa, mostra na listview
                listapecas_lstvw.Items.Clear();

                // procura a string do campo de pesquisa no dataset
                DataTable dt = data.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    string codigo = dr["tbCP_Codigo"].ToString();
                    string tipo = dr["tbCP_Tipo"].ToString();
                    string marca = dr["tbCP_Marca"].ToString();
                    string modelo = dr["tbCP_Modelo"].ToString();
                    string specs = dr["tbCP_Especificacoes"].ToString();

                    string codLead = codigo.ToString().PadLeft(8, '0');

                    // se encontrar
                    if (codigo.Contains(pesquisa_tbc.Text.ToLower())
                        || tipo.ToLower().Contains(pesquisa_tbc.Text.ToLower())
                        || marca.ToLower().Contains(pesquisa_tbc.Text.ToLower())
                        || modelo.ToLower().Contains(pesquisa_tbc.Text.ToLower())
                        || specs.ToLower().Contains(pesquisa_tbc.Text.ToLower()))
                    {
                        // adiciona o item na lista
                        ListViewItem listitem = new ListViewItem(codLead);
                        listitem.SubItems.Add(tipo);
                        listitem.SubItems.Add(marca);
                        listitem.SubItems.Add(modelo);
                        listitem.SubItems.Add(specs);
                        listapecas_lstvw.Items.Add(listitem);
                    }
                }

                // Colorindo a lista
                ColoreLista(listapecas_lstvw, SystemColors.Control, SystemColors.ControlLight);

            }
        }

        /// eventos dos botoes
        //// executa quando o botao eh clicado
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            // abre o formulário secundário
            ChamaCadastro();
        }

        /// eventos das listViews
        //// executa quando clica nos headers das colunas
        private void LstviewPecas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Se a coluna clicada ja eh a q sorta
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverte a direcao do sort da coluna
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // Senão
            else
            {
                // Sorta a tabela pela coluna clicada
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Aplica tudo
            this.listapecas_lstvw.Sort();

            // Recolore a lista
            ColoreLista(listapecas_lstvw, SystemColors.Control, SystemColors.ControlLight);
        }
        //// executa quando um item eh clicado uma vez
        private void Listapecas_lstvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editar_tsmsi.Enabled = true;
        }
        //// executa quando um item eh clicado duas vezes
        private void Listapecas_lstvw_ItemActivate(object sender, EventArgs e)
        {
            // pega o nome do item selecionado
            if (listapecas_lstvw.SelectedItems.Count > 0)
            {
                ListViewItem item = listapecas_lstvw.SelectedItems[0];
                string codigo = item.Text;
                string tipo = item.SubItems[1].Text;
                string marca = item.SubItems[2].Text;
                string modelo = item.SubItems[3].Text;
                string specs = item.SubItems[4].Text;
                ChamaDetalhe(codigo, tipo, marca, modelo, specs);
            }
        }

        /// eventos do menu
        //// cadastrar nova peça
        private void Cadastrar_tsmsi_Click(object sender, EventArgs e)
        {
            // abre o formulário secundário
            ChamaCadastro();
        }
        //// editar peça
        private void Editar_tsmsi_Click(object sender, EventArgs e)
        {
            // pega o nome do item selecionado
            if (listapecas_lstvw.SelectedItems.Count > 0)
            {
                ListViewItem item = listapecas_lstvw.SelectedItems[0];
                string codigo = item.Text;
                string tipo = item.SubItems[1].Text;
                string marca = item.SubItems[2].Text;
                string modelo = item.SubItems[3].Text;
                string specs = item.SubItems[4].Text;
                ChamaDetalhe(codigo, tipo, marca, modelo, specs);
            }
        }
        //// ajuda
        private void Ajuda_tsmsi_Click(object sender, EventArgs e)
        {
            AbreArquivo(@"assets\1cadastro_componentes\ajuda.html");
        }
        //// sobre
        private void Equipe_tsmsi_Click(object sender, EventArgs e)
        {
            AbreArquivo(@"assets\1cadastro_componentes\sobre.html");
        }

        /// eventos do formulario
        //// executa quando o form inicia
        private void Main_form_Load(object sender, EventArgs e)
        {
            // carrega form de login
            //ChamaLogin(); // desativar pra facilitar os testes

            // carrega dados
            InitMsAccessSingleton();
            ListaDados();

            // função de responsividade
            Responsividade();

            // sugestoes de pesquisa
            SugereDados();
        }
        //// executa quando o form eh redimensionado
        private void Main_form_Resize(object sender, EventArgs e)
        {
            // função de responsividade
            Responsividade();
        }
    }
}
