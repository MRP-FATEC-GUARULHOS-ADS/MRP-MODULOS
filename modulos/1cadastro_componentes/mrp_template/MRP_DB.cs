using System;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;

namespace cadastro_componentes
{
    public class MRP_DB
    {
        private static readonly MRP_DB instanciaAccess = new MRP_DB();

        private MRP_DB() { }

        public static MRP_DB GetInstancia()
        {
            return instanciaAccess;
        }

        public OleDbConnection GetConexao()
        {
            // usando o caminho do arquivo
            string caminho = Application.StartupPath;
            // gambiarra pra tirar o caminho da pasta debug
            // string pasta = caminho.Substring(0, caminho.Length - 9) + "DBP1-MRP_final.mdb";
            string pasta = caminho + @"\database\DBP1-MRP_final.mdb";
            string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pasta;

            // usando o registro automatico do banco de dados
            //string conn = ConfigurationManager.ConnectionStrings["mrp_template.Properties.Settings.SacoDeCarvaoConnectionString"].ToString();
            return new OleDbConnection(conn);
        }
    }
}