using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using cadastro_componentes.Componentes;

namespace cadastro_componentes
{
    public partial class Sec_form : Form
    {
        // funcoes personalizadas
        /// cria uma caixa de texto para cada componente
        private void SpawnTextoCampo(string nome, string texto, Panel mae)
        {
            // cria o elemento com suas propriedades
            SpecPanel spec = new SpecPanel()
            {
                Name = nome,
                Location = new Point(0, 0),
                Size = new Size(345, 74),
                Dock = DockStyle.Top,
                // guarda o valor padrao do campo, pra validacao no cadastro
                AccessibleDescription = texto
            };
            spec.label.Text = texto;
            spec.textboxCE.Text = texto;

            // carrega o elemento nos controles do form
            mae.Controls.Add(spec);

            // traz o elemento pra frente na exibicao do layout
            spec.BringToFront();

            // torna o elemento visivel na execucao
            spec.Visible = true;

            // adiciona as funcoes abaixo ao elemento
            spec.textboxCE.Enter += new EventHandler(SpecPanelEnter);
            spec.textboxCE.Leave += new EventHandler(SpecPanelLeave);

            void SpecPanelEnter(object sender, EventArgs e)
            {
                Main_form.ApagaDummy(spec.textboxCE, texto);
            }
            void SpecPanelLeave(object sender, EventArgs e)
            {
                Main_form.EscreveDummy(spec.textboxCE, texto);
            }
        }
        
        /// carrega os dados nas sugestoes da pesquisa
        public void SugereDados(DataSet data)
        {
            DataTable dt = data.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                var tipo = dr["tbCP_Tipo"].ToString();
                var marca = dr["tbCP_Marca"].ToString();

                tipo_cbc.combobox.AutoCompleteCustomSource.Add(tipo);
                marca_tbc.textbox.AutoCompleteCustomSource.Add(marca);
            }
        }

        // insert de peça no banco de dados
        public void CadastrarPeca(string tipo, string marca, string modelo, string especificacoes)
        {
            using (OleDbConnection conexaoAccess = MRP_DB.GetInstancia().GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "INSERT into tb_cadpecas (tbCP_Tipo,tbCP_Marca,tbCP_Modelo,tbCP_Especificacoes) VALUES ";
                    SQL += "('" + tipo + "','" + marca + "','" + modelo + "','" + especificacoes + "');";

                    // abre a conexao com o banco de dados
                    conexaoAccess.Open();

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand(SQL, conexaoAccess);

                    // executa o comando
                    comando.ExecuteNonQuery();

                    // confirma que o produto foi inserido
                    MessageBox.Show("Peça cadastrada com sucesso.");

                    // valida o formulario
                    isCadastrado = true;
                }
                catch (OleDbException oledbex)
                {
                    MessageBox.Show("Erro de acesso ao banco de dados:\n" + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
        }

        // variaveis do formulario
        /// validacao do formulario
        public static bool isCadastrado = false;

        /// validacao dos campos
        bool isTipoCerto = false,
            isMarcaCerto = false,
            isModeloCerto = false;

        /// confere se o usuario alterou o texto de tipo, pra aumentar performance
        bool isCerta = true;

        // Main do Form2
        public Sec_form()
        {
            InitializeComponent();

            // itens da caixa de tipo
            string[] comboItems = new string[] { "HD", "SSD", "Memória RAM", "Placa Mãe", "Processador", "Placa de Vídeo" };
            tipo_cbc.combobox.Items.AddRange(comboItems);
            // auto-complete da caixa de tipo
            tipo_cbc.combobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            tipo_cbc.combobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // event handler de seleção de itens
            tipo_cbc.combobox.SelectedIndexChanged += new EventHandler(TipoSelectedIndexChanged);

            // auto-complete da caixa de marca
            marca_tbc.textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            marca_tbc.textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // eventos dos objetos
        /// eventos das textboxes
        //// executa quando a textbox entra em foco
        private void TipoEnter(object sender, EventArgs e)
        {
            if (tipo_cbc.Text == "Tipo de Peça")
            {
                tipo_cbc.Text = "";
                tipo_cbc.combobox.ForeColor = SystemColors.ControlText;
            }
            tipo_cbc.BorderColor = SystemColors.Highlight;
        }
        //// executa quando a textbox sai de foco
        private void TipoLeave(object sender, EventArgs e)
        {
            // escreve o dummy
            if (tipo_cbc.Text == "")
            {
                tipo_cbc.Text = "Tipo de Peça";
                tipo_cbc.combobox.ForeColor = SystemColors.GrayText;
            }
            tipo_cbc.BorderColor = Color.Gray;
        }
        //// executa quando o texto da textbox eh alterado
        private void TipoChange(object sender, EventArgs e)
        {
            // invalida o campo de tipo
            isTipoCerto = false;
            tipo_cbc.BorderColor = Color.Red;

            // verifica se os tres campos principais foram preenchidos corretamente
            ok_btn.Enabled = false;
        }
        //// executa quando a selecao da combobox muda
        private void TipoSelectedIndexChanged(object sender, EventArgs e)
        {
            // valida o campo de tipo
            isTipoCerto = true;

            switch (tipo_cbc.combobox.SelectedItem.ToString())
            {
                case "HD":
                case "SSD":
                case "Memória RAM":
                case "Placa Mãe":
                case "Processador":
                case "Placa de Vídeo":

                    // habilita os paineis de marca e modelo
                    modelo_pnl.Visible = true;
                    marca_pnl.Visible = true;

                    // remove as especificacoes antigas
                    specs_pnl.Controls.Clear();

                    // carrega as especificacoes de acordo com o tipo de peça
                    foreach (string spec in Main_form.GetSpecNomes(tipo_cbc.combobox.SelectedItem.ToString().ToLower()))
                        SpawnTextoCampo("spec_" + spec, spec, specs_pnl);

                    // muda a borda da caixa, preenchida certo
                    tipo_cbc.BorderColor = Color.Green;

                    break;
            }

            // verifica se os tres campos principais foram preenchidos corretamente
            ok_btn.Enabled = isTipoCerto && isMarcaCerto && isModeloCerto;
        }

        private void MarcaEnter(object sender, EventArgs e)
        {
            Main_form.ApagaDummy(marca_tbc, "Marca da Peça");
        }
        private void MarcaLeave(object sender, EventArgs e)
        {
            Main_form.EscreveDummy(marca_tbc, "Marca da Peça");
        }
        private void MarcaTextChanged(object sender, EventArgs e)
        {
            if (marca_tbc.Text != "" && marca_tbc.Text != "Marca da Peça")
                isMarcaCerto = true;
            else
                isMarcaCerto = false;

            // verifica se os tres campos principais foram preenchidos corretamente
            ok_btn.Enabled = isTipoCerto && isMarcaCerto && isModeloCerto;
        }

        private void ModeloEnter(object sender, EventArgs e)
        {
            Main_form.ApagaDummy(modelo_tbc, "Modelo da Peça");
        }
        private void ModeloLeave(object sender, EventArgs e)
        {
            Main_form.EscreveDummy(modelo_tbc, "Modelo da Peça");
        }
        private void ModeloTextChanged(object sender, EventArgs e)
        {
            if (modelo_tbc.Text != "" && modelo_tbc.Text != "Modelo da Peça")
                isModeloCerto = true;
            else
                isModeloCerto = false;

            // verifica se os tres campos principais foram preenchidos corretamente
            ok_btn.Enabled = isTipoCerto && isMarcaCerto && isModeloCerto;
        }

        /// eventos dos botoes
        //// executa quando o botao eh clicado
        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult confirmarCadastro = MessageBox.Show("Tem certeza que deseja cadastrar a peça?",
                                                                "Confirmar Inclusão",
                                                                MessageBoxButtons.YesNo);
            if (confirmarCadastro == DialogResult.Yes)
            {
                isCerta = true;
                // concatenando todas as especificacoes em uma string
                StringBuilder specs = new StringBuilder();

                // usando insert em vez de append porque a ordem dos filhos eh reversa no layout
                foreach (SpecPanel spec in specs_pnl.Controls)
                {
                    if (spec.textboxCE.Text != spec.AccessibleDescription && spec.textboxCE.Text != "")
                        specs.Insert(0, spec.textboxCE.Text + ";");
                    else
                        specs.Insert(0, "Não especificado;");
                }

                // add a peça no banco de dados
                CadastrarPeca(
                    tipo_cbc.Text,
                    marca_tbc.Text,
                    modelo_tbc.Text,
                    specs.ToString()
                );

                this.Close();
            }
            else
            {
                isCerta = false;
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// eventos do formulario
        //// executa quando o form inicia
        private void Secform_Load(object sender, EventArgs e)
        {
            // função de responsividade
            Main_form.RedimensionaLaterais(statusStrip, spacer_esq_pnl, spacer_dir_pnl);

            // preenche as sugestoes das caixas de texto de tipo e marca
            SugereDados(Main_form.data);

            isCadastrado = false;
        }
        //// executa quando o form eh fechado
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing && e.CloseReason != CloseReason.WindowsShutDown)
                if (!isCerta)
                    e.Cancel = true;
        }
        //// executa quando o formulario eh redimensionado
        private void Secform_Resize(object sender, EventArgs e)
        {
            // função de responsividade
            Main_form.RedimensionaLaterais(statusStrip, spacer_esq_pnl, spacer_dir_pnl);
        }
        //// executa quando alguma tecla eh apertada e solta
        private void Sec_form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}