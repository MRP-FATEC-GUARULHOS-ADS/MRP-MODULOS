using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP_Fatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly DataSet data = new DataSet();

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            if(txt_senha.Text != "" && txt_usuario.Text != "")
            {
                btn_entrar.Enabled = true;
            }
            else
            {
                btn_entrar.Enabled = false;
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_senha.Text != "" && txt_usuario.Text != "")
            {
                btn_entrar.Enabled = true;
            }
            else
            {
                btn_entrar.Enabled = false;
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Database conection = new Database();
            OleDbConnection con = conection.Conectar();

            try
            {
                con.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tb_usuarios", con);
                adapter.Fill(data);
            }
            catch(OleDbException oledbex)
            {
                MessageBox.Show("Erro de acesso ao banco de dados " + oledbex.Message, "Erro");
            }
            finally
            {
                //fecha a conexao
                con.Close();
            }

            DataTable dt = data.Tables[0];
            string usuario = txt_usuario.Text, senha = txt_senha.Text;
            foreach(DataRow dr in dt.Rows)
            {
                var usuario_bd = dr["Login_user"].ToString();
                var senha_bd = dr["Senha_user"].ToString();
                var modulo = dr["modulo_user"].ToString();

                if(usuario == usuario_bd && senha == senha_bd && modulo == "Geral")
                {
                    Painel pnl = new Painel();
                    
                    pnl.ShowDialog();
                    this.Visible = false;
                    this.Close();

                    return;
                }
            }
            MessageBox.Show("Incorreto", "Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btn_entrar_Click(sender, e);
            }
        }
    }
}
