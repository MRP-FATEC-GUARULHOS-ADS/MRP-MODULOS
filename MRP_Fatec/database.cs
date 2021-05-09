using System.Data.OleDb;
using System.Windows.Forms;

namespace MRP_Fatec
{
    public class Database
    {
        private static readonly Database instanciaAccess = new Database();

        private Database() { }

        public static Database GetInstancia()
        {
            return instanciaAccess;
        }

        public OleDbConnection GetConexao() {
            // usando o caminho de inicialização
            string caminho = Application.StartupPath;
            string pasta = caminho + @"\database\DBP1-MRP_final.mdb";
            string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pasta;

            return new OleDbConnection(conn);
        }
    }
}
