using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using cadastro_componentes.Componentes;

namespace cadastro_componentes
{
    public partial class Form3_detalhes : Form
    {
        // funcoes personalizadas
        /// carrega o texto da peça nos campos do formulario
        private void SetTextos(string marca, string modelo, string specs)
        {
            h3_lbl.Text = tipVar + " - " + codVar;

            marca_tbc_lbl.Text = marca;
            marca_tbc.Text = marca;
            marca_tbc.TextChanged += new EventHandler(TBC_TextChanged);

            modelo_tbc_lbl.Text = modelo;
            modelo_tbc.Text = modelo;
            modelo_tbc.TextChanged += new EventHandler(TBC_TextChanged);

            string[] specSplit = specs.Split(';');
            List<string> descricoes = Main_form.GetSpecNomes(tipVar.ToLower());

            for (int i=0; i<specSplit.Length-1; i++)
                SpawnTextoCampo("spec_" + i, specSplit[i], descricoes[i], specs_pnl);

        }

        /// cria uma caixa de texto para cada componente
        private void SpawnTextoCampo(string nome, string texto, string descricao, Panel mae)
        {
            // cria o elemento com suas propriedades
            DetalheSpecPanel spec = new DetalheSpecPanel()
            {
                Name = nome,
                Location = new Point(0, 0),
                Size = new Size(320, 49),
                Dock = DockStyle.Top,
                BackColor = SystemColors.Control,
                // guarda o valor padrao do campo, pra validacao no cadastro
                AccessibleDescription = texto
            };
            spec.fakeText.Text = texto;
            spec.textboxCE.Text = texto;
            spec.label.Text = descricao;
            spec.botao.FlatAppearance.BorderSize = 0;

            // carrega o elemento nos controles do form
            mae.Controls.Add(spec);

            // traz o elemento pra frente na exibicao do layout
            spec.BringToFront();

            // torna o elemento visivel na execucao
            spec.Visible = true;

            // adiciona os eventos
            spec.textboxCE.TextChanged += new EventHandler(TBC_TextChanged);
            spec.botao.Click += new EventHandler(Edit_btn_Click);

            //// botao de editar das especificacoes
            void Edit_btn_Click(object sender, EventArgs e)
            {
                spec.fakeText.Visible = false;
                spec.textboxCE.Visible = true;
                spec.textboxCE.textbox.SelectAll();
                spec.textboxCE.textbox.Focus();

                spec.botao.Image = null;
                spec.botao.Enabled = false;
            }
        }

        // update de peça no banco de dados
        private void EditarPeca(string codigo, string tipo, string marca, string modelo, string especificacoes)
        {
            using (OleDbConnection conexaoAccess = MRP_DB.GetInstancia().GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "UPDATE tb_cadpecas SET tbCP_Tipo = '" + tipo +
                                                "', tbCP_Marca = '" + marca +
                                                "', tbCP_Modelo = '" + modelo +
                                                "', tbCP_Especificacoes = '" + especificacoes +
                                            "' WHERE [tbCP_Codigo] = " + codigo + ";";

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand();

                    // abre a conexao com o banco
                    conexaoAccess.Open();

                    // seta a conexao do comando
                    comando.Connection = conexaoAccess;

                    // seta o comando a ser executado
                    comando.CommandText = SQL;

                    // executa o comando
                    comando.ExecuteNonQuery();

                    // confirma que o produto foi inserido
                    MessageBox.Show("Peça alterada com sucesso.");

                    // valida o formulario
                    isEditado = true;
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
        // deleta peça do banco de dados
        private void DeletarPeca(string codigo)
        {
            using (OleDbConnection conexaoAccess = MRP_DB.GetInstancia().GetConexao())
            {
                try
                {
                    // cria a string de comando
                    string SQL = "DELETE FROM tb_cadpecas WHERE [tbCP_Codigo] = " + codigo + ";";

                    // cria o comando a ser enviado
                    OleDbCommand comando = new OleDbCommand();

                    // abre a conexao com o banco
                    conexaoAccess.Open();

                    // seta a conexao do comando
                    comando.Connection = conexaoAccess;

                    // seta o comando a ser executado
                    comando.CommandText = SQL;

                    // executa o comando
                    comando.ExecuteNonQuery();

                    // confirma que o produto foi inserido
                    MessageBox.Show("Peça removida com sucesso.");

                    // valida o formulario
                    isEditado = true;
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

        // variaveis personalizadas
        /// define se o usuario alterou alguma informacao da peça
        bool isAlterada = false, isCerta = true;
        /// validacao do formulario
        public static bool isEditado = false;
        /// codigo e tipo da peça
        readonly string codVar = "";
        readonly string tipVar = "";

        // funcao Main do Form3
        public Form3_detalhes(string codigo, string tipo, string marca, string modelo, string specs)
        {
            InitializeComponent();
            codVar = codigo;
            tipVar = tipo;
            SetTextos(marca, modelo, specs);
        }

        // funcoes dos objetos
        /// textboxes
        //// determina se o texto foi alterado
        private void TBC_TextChanged(object sender, EventArgs e)
        {
            isAlterada = true;
            ok_btn.Text = (isAlterada) ? "Aplicar" : "OK";
        }

        /// botoes
        //// botao de OK
        private void OK_btn_Click(object sender, EventArgs e)
        {
            if (isAlterada)
            {
                if (marca_tbc.Text != "" && modelo_tbc.Text != "")
                {
                    isCerta = true;
                    // confirma se o usuario quer mesmo mudar os valores
                    DialogResult confirmarEdit = MessageBox.Show("Tem certeza que deseja alterar a descrição da peça?",
                                                                "Confirmar Alteração",
                                                                MessageBoxButtons.YesNo);
                    if (confirmarEdit == DialogResult.Yes)
                    {
                        // concatenando todas as especificacoes em uma string
                        StringBuilder specs = new StringBuilder();

                        // usando insert em vez de append porque a ordem dos filhos eh reversa no layout
                        foreach (DetalheSpecPanel spec in specs_pnl.Controls)
                            if (spec.textboxCE.Text != spec.textboxCE.AccessibleDescription && spec.textboxCE.Text != "")
                                specs.Insert(0, spec.textboxCE.Text + ";");
                            else
                                specs.Insert(0, "Não especificado;"); 

                        // muda a peça no banco de dados
                        EditarPeca(
                            codVar,
                            tipVar,
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
                else
                {
                    isCerta = false;
                    MessageBox.Show("Os campos 'Marca' e 'Modelo' devem ser preenchidos.");
                }
            }
            else
            {
                isCerta = true;
                this.Close();
            }
        }
        //// botao de cancelar
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            isCerta = true;
            this.Close();
        }
        //// botao de delete
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult confirmarEdit = MessageBox.Show("Tem certeza que deseja EXCLUIR a peça?",
                                                                "Confirmar Exclusão!",
                                                                MessageBoxButtons.YesNo);
            if (confirmarEdit == DialogResult.Yes)
            {
                isCerta = true;

                // deleta a peça do banco de dados
                DeletarPeca(codVar);

                this.Close();
            }
            else
            {
                isCerta = false;
            }
        }
        //// botao de editar marca
        private void Marca_btn_Click(object sender, EventArgs e)
        {
            marca_tbc_lbl.Visible = false;
            marca_tbc.Visible = true;
            marca_tbc.textbox.SelectAll();
            marca_tbc.textbox.Focus();

            marca_btn.Image = null;
            marca_btn.Enabled = false;
        }
        //// botao de editar modelo
        private void Modelo_btn_Click(object sender, EventArgs e)
        {
            modelo_tbc_lbl.Visible = false;
            modelo_tbc.Visible = true;
            modelo_tbc.textbox.SelectAll();
            modelo_tbc.textbox.Focus();

            modelo_btn.Image = null;
            modelo_btn.Enabled = false;
        }

        /// formulario
        //// executa quando o formulario eh fechado
        private void Form3_detalhes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing && e.CloseReason != CloseReason.WindowsShutDown)
                if (isAlterada && !isCerta)
                    e.Cancel = true;
        }
        //// executa quando o formulario eh carregado
        private void Form3_detalhes_Load(object sender, EventArgs e)
        {
            isEditado = false;
        }
    }
}