using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ModuloCompras
{
    public partial class CadastrarFornecedor : Form
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        public OleDbConnection Conectar()
        {
            string caminho = Application.StartupPath + @"\database\DBP1-MRP_final.mdb";
            string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + caminho;
            OleDbConnection aConnection = new OleDbConnection(conn);
            return aConnection;
        }


        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = Conectar();
            string nm_forn = nm_fornecedor.Text;
            string cnpj_forn = cnpj_fornecedor.Text;

            string comando = "INSERT INTO tb_fornecedores(nm_fornecedor,cnpj_fornecedor,status_fornecedor) VALUES ('" + nm_forn + "','" + cnpj_forn + "',1)";
            OleDbCommand aCommand = new OleDbCommand(comando, con);

            try
            {
                con.Open();
                aCommand.ExecuteNonQuery();

                MessageBox.Show("Registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nm_fornecedor.Clear();
                cnpj_fornecedor.Clear();
                nm_fornecedor.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
