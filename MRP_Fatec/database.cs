using System.Data.OleDb;
using System.Windows.Forms;

namespace MRP_Fatec
{
    class Database
    {
        public OleDbConnection Conectar()
        {
            string path = Application.StartupPath;
            OleDbConnection con;
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + @"\database\DBP1-MRP_final.mdb");
            return con;
        }
    }
}
