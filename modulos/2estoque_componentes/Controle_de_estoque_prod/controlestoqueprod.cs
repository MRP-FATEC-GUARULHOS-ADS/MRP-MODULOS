using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Controle_de_estoque_prod
{
    public partial class Estoque_prod : Form
    {
        public Estoque_prod()
        {
            InitializeComponent();
        }

        private void bt_Ajuda_Click(object sender, EventArgs e)
        {
            Form2 form_ajuda = new Form2();
            form_ajuda.ShowDialog();

        }

        private void Bt_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                string strconexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb";
                OleDbConnection connection = new OleDbConnection(strconexao);
                connection.Open();

                string SQL;
                SQL = "Insert Into tb_estoque_prod(Cod_prod," +
                    "Tipo_prod," +
                    "Quantidade," +
                    "Modelo_prod," +
                    "Marca_prod," +
                    "Dt_saida_entrada)Values";
                SQL += "('" + txtb_Cod_prod.Text + "','"+txtb_Tipo_prod.Text + "','" + txtb_Quantidade.Text + "','" + txtb_Mod_prod.Text + "','" + txtb_Marca.Text + "','" + dt_picker.Value + "')";
                OleDbCommand comando = new OleDbCommand(SQL, connection);
                AddParameterWithValue(comando, "@Tipo_prod", OleDbType.VarChar, txtb_Tipo_prod.Text);
                AddParameterWithValue(comando, "@Quantidade", OleDbType.Numeric, txtb_Quantidade.Text);
                AddParameterWithValue(comando, "@Modelo_prod", OleDbType.VarChar, txtb_Mod_prod.Text);
                AddParameterWithValue(comando, "@Marca_prod", OleDbType.VarChar, txtb_Marca.Text);
                AddParameterWithValue(comando, "@Cod_prod", OleDbType.Numeric, txtb_Cod_prod.Text);
                AddParameterWithValue(comando, "@Dt_saida_entrada", OleDbType.DBDate, dt_picker.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso");
                txtb_Cod_prod.Clear();
                txtb_Tipo_prod.Clear();
                txtb_Quantidade.Clear();
                txtb_Mod_prod.Clear();
                txtb_Marca.Clear();

                connection.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        
        private void Bt_Saida_Click(object sender, EventArgs e)

        {
            try
            {
                string path = Application.StartupPath;
                string strconexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb";
                OleDbConnection connection = new OleDbConnection(strconexao);
                connection.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = connection;

               
                string del = "DELETE FROM tb_estoque_prod WHERE Cod_prod = @Cod_prod";
                comando.CommandText = del;
                AddParameterWithValue(comando, "@Cod_prod", OleDbType.Numeric, txtb_Cod_prod.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso");
                txtb_Cod_prod.Clear();
                txtb_Tipo_prod.Clear();
                txtb_Quantidade.Clear();
                txtb_Mod_prod.Clear();
                txtb_Marca.Clear();
                connection.Dispose();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void Bt_Consulta_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                string strconexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb";
                OleDbConnection connection = new OleDbConnection(strconexao);
                connection.Open();

                string procura = "SELECT + FROM tb_estoque_prod";
                if (txtb_Cod_prod_2.Text != "")
                {
                    procura = "SELECT * FROM tb_estoque_prod WHERE Cod_prod LIKE'" + txtb_Cod_prod_2.Text + "'";
                }
                DataTable dados = new DataTable();

                OleDbDataAdapter adapter = new OleDbDataAdapter(procura, connection);
                adapter.Fill(dados);

                MessageBox.Show("Consulta feita com sucesso");
                txtb_Cod_prod_2.Text = (string)dados.Rows[0][1];
                txtb_Quantidade_2.Text = (string)dados.Rows[0][2];
               
                connection.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Bt_Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                string strconexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb";
                OleDbConnection connection = new OleDbConnection(strconexao);
                connection.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = connection;


                 string atualiza ="UPDATE tb_estoque_prod Set Tipo_prod = @Tipo_prod, " +
                    "Quantidade = @Quantidade, " +
                    "Modelo_prod = @Modelo_prod, " +
                    "Marca_prod = @Marca_prod " +
                    "WHERE Cod_prod = @Cod_prod;";

                comando.CommandText = atualiza;
                AddParameterWithValue(comando, "@Tipo_prod", OleDbType.VarChar, txtb_Tipo_prod.Text);
                AddParameterWithValue(comando, "@Quantidade", OleDbType.Numeric, txtb_Quantidade.Text);
                AddParameterWithValue(comando, "@Modelo_prod", OleDbType.VarChar, txtb_Mod_prod.Text);
                AddParameterWithValue(comando, "@Marca_prod", OleDbType.VarChar, txtb_Marca.Text);
                AddParameterWithValue(comando, "@Cod_prod", OleDbType.Numeric, txtb_Cod_prod.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso");
                txtb_Cod_prod.Clear();
                txtb_Tipo_prod.Clear();
                txtb_Quantidade.Clear();
                txtb_Mod_prod.Clear();
                txtb_Marca.Clear();

                connection.Dispose();


            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        /// <summary>
        /// Acrescenta ao <paramref name="comando"/> um parâmetro identificado pelo <paramref name="parameterName"/> e com tipo e valor especificados.
        /// </summary>
        /// <param name="comando">O objeto <see cref="OleDbCommand"/> onde será criado o novo parâmetro.</param>
        /// <param name="parameterName">O nome do parâmetro. Deve iniciar com <c>@</c></param>
        /// <param name="oleDbType">O valor de <see cref="OleDbType"/> correspondente ao parâmetro a ser criado.</param>
        /// <param name="value">O valor a ser atribuído ao parâmetro que está sendo criado.</param>
        private static void AddParameterWithValue(OleDbCommand comando, string parameterName, OleDbType oleDbType, object value)
        {
            if (comando == null)
            {
                throw new ArgumentNullException(nameof(comando));
            }
            if (string.IsNullOrEmpty(parameterName))
            {
                throw new ArgumentException("O parâmetro precisa estar preenchido.", nameof(parameterName));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            comando.Parameters.Add(parameterName, oleDbType);
            comando.Parameters[parameterName].Value = value;
        }
    }
}
