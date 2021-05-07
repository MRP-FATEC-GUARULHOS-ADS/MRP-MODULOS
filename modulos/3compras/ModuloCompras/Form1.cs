using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ModuloCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] cnpjs;

        public OleDbConnection Conectar()
        {
            string caminho = Application.StartupPath + @"\database\DBP1-MRP_final.mdb";
            string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + caminho;
            OleDbConnection aConnection = new OleDbConnection(conn);
            return aConnection;
        }

        private void AjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda janela_ajuda = new Ajuda();
            janela_ajuda.ShowDialog();
        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadastro_forn = new CadastrarFornecedor();
            cadastro_forn.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lst_fornecedores.Items.Clear();

            OleDbConnection con = Conectar();
            OleDbCommand aCommand = new OleDbCommand("SELECT count(*) FROM tb_fornecedores where status_fornecedor = 1", con);
            OleDbCommand aCommand2 = new OleDbCommand("SELECT * FROM tb_fornecedores where status_fornecedor = 1", con);

            try
            {
                con.Open();

                OleDbDataReader aReader = aCommand.ExecuteReader();

                aReader.Read();
                int qtd_reg = aReader.GetInt32(0);

                cnpjs = new string[qtd_reg];

                aReader.Close();

                ///////////////////////////////////////////////////////////////

                int cont = 0;

                OleDbDataReader aReader2 = aCommand2.ExecuteReader();

                while (aReader2.Read())
                {
                    lst_fornecedores.Items.Add(aReader2.GetString(1));
                    cnpjs[cont] = aReader2.GetString(2);
                    cont++;
                }

                aReader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void Lst_fornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnpj_fornecedor.Text = cnpjs[lst_fornecedores.SelectedIndex];
        }
    }
}
