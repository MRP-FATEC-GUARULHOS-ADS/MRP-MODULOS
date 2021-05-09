using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MRP_Fatec
{
    public partial class Form0_login : Form
    {
        // funcoes personalizadas
        /// ativa o botao OK se todos os campos estiverem preenchidos
        private void SetBotao()
        {
            ok_btn.Enabled =
                (user_tbc.Text != "" && user_tbc.Text != userDummy) &&
                (senha_tbc.Text != "" && senha_tbc.Text != senhaDummy);
        }
        /// carrega o banco de dados em um dataset
        private void InitMsAccessSingleton()
        {
            using (OleDbConnection conexaoAccess = Database.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoAccess.Open();
                    // cria o adapter e preenche o dataset
                    OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from tb_usuarios", conexaoAccess);
                    adapter.Fill(data);
                }
                catch (OleDbException oledbex)
                {
                    MessageBox.Show("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
                }
                finally
                {
                    //fecha a conexao
                    conexaoAccess.Close();
                }
            }
        }

        // variaveis do formulario
        /// tabela de usuarios da database
        private readonly DataSet data = new DataSet();

        /// nome dos campos
        private readonly string userDummy = "Login_user";
        private readonly string senhaDummy = "Senha_user";

        /// validacao
        private bool isValidado = false;

        // funcao main do form de login
        public Form0_login()
        {
            InitializeComponent();

            // customizando a caixa de texto de senha
            senha_tbc.textbox.PasswordChar = '*';
        }

        // funcoes dos objetos
        /// funcoes das textboxes
        //// executa quando a textbox entra em foco
        private void TextBoxUserEnter(object sender, EventArgs e)
        {
            user_tbc.BorderColor = SystemColors.Highlight;
            Painel.ApagaDummy(user_tbc, userDummy);
        }
        //// executa quando a textbox sai de foco
        private void TextBoxUserLeave(object sender, EventArgs e)
        {
            user_tbc.BorderColor = Color.Gray;
            Painel.EscreveDummy(user_tbc, userDummy);
        }
        //// executa quando o texto eh mudado
        private void TextBoxUserChanged(object sender, EventArgs e)
        {
            SetBotao();
        }

        private void TextBoxSenhaEnter(object sender, EventArgs e)
        {
            senha_tbc.BorderColor = SystemColors.Highlight;
            Painel.ApagaDummy(senha_tbc, senhaDummy);
        }
        private void TextBoxSenhaLeave(object sender, EventArgs e)
        {
            senha_tbc.BorderColor = Color.Gray;
            Painel.EscreveDummy(senha_tbc, senhaDummy);
        }
        private void TextBoxSenhaChanged(object sender, EventArgs e)
        {
            SetBotao();
        }

        /// funcoes dos botoes
        //// executa quando o botao eh clicado
        private void OK_Click(object sender, EventArgs e)
        {
            // verifica se o texto digitado nos campos estah no db de usuarios
            DataTable dt = data.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                var usuario = dr["Login_user"].ToString();
                var senha = dr["Senha_user"].ToString();

                if (usuario == user_tbc.Text && senha == senha_tbc.Text)
                {
                    isValidado = true;
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Login ou senha incorretos.");
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        /// funcoes do form
        //// executa quando o form carrega
        private void Form0_login_Load(object sender, EventArgs e)
        {
            InitMsAccessSingleton();
        }
        //// executa quando o form eh fechado
        private void Form0_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isValidado)
                System.Environment.Exit(1);
        }
    }
}
