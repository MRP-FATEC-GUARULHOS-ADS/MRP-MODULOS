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

namespace MRPPROJETO
{
    public partial class FormCadProdFinal : Form
    {
        public FormCadProdFinal()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtCodigo.Clear();
            txtTipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtDiscorigido.Clear();
            txtPlacaMae.Clear();
            txtRAM.Clear();
            txtGabinete.Clear();
            txtProcessador.Clear();
            txtCooler.Clear();
            txtPlacadeVideo.Clear();
            txtCodigo.Focus();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;
                
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path +  @"\database\DBP1-MRP_final.mdb");

                con.Open();

                string SQL;

                SQL = "Insert Into tb_produtofinal(Tipo, Marca, Modelo, Ano, DiscoRigido, Gabinete, RAM, PlacaMae, Processador, Cooler, PlacadeVideo) Values";

                SQL += "('" + txtTipo.Text + "', '" + txtMarca.Text + "', '" + txtModelo.Text + "', '" + txtAno.Text + "', '" + txtDiscorigido.Text + "', '" + txtGabinete.Text + "', '" + txtRAM.Text + "', '" + txtPlacaMae.Text + "', '" + txtProcessador.Text + "', '" + txtCooler.Text + "', '" + txtPlacadeVideo.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso");

                string SQLATT = "SELECT * FROM tb_produtofinal";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLATT, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "tb_produtofinal");

                DgProdutosFinais.DataSource = DS.Tables["tb_produtofinal"];

                limpar();


                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb");

                con.Open();

                string SQL = "SELECT * FROM tb_produtofinal";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "tb_produtofinal");

                DgProdutosFinais.DataSource = DS.Tables["tb_produtofinal"];

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb");

                con.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = con;

                string cons = "UPDATE tb_produtofinal SET Tipo = '" + txtTipo.Text +
                                            "', Marca = '" + txtMarca.Text +
                                            "', Modelo = '" + txtModelo.Text +
                                            "', Ano = '" + txtAno.Text +
                                            "', DiscoRigido = '" + txtDiscorigido.Text +
                                            "', Gabinete = '" + txtPlacaMae.Text +
                                            "', RAM = '" + txtRAM.Text +
                                            "', PlacaMae = '" + txtGabinete.Text +
                                            "', Processador = '" + txtProcessador.Text +
                                            "', Cooler = '" + txtCooler.Text +
                                            "', PlacadeVideo = '" + txtPlacadeVideo.Text +
                                            "' WHERE Codigo = " + txtCodigo.Text + "";

                cmd.CommandText = cons;

                cmd.ExecuteNonQuery();

                limpar();

                string SQLATT = "Select * from tb_produtofinal";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLATT, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "tb_produtofinal");

                DgProdutosFinais.DataSource = DS.Tables["tb_produtofinal"];

                con.Dispose();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {

                string path = Application.StartupPath;

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb");

                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;

                cmd.CommandText = " DELETE FROM tb_produtofinal WHERE Codigo = " + txtCodigo.Text + "";

                cmd.ExecuteNonQuery();

                limpar();

                string SQLATT = "Select * from tb_produtofinal";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLATT, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "tb_produtofinal");

                DgProdutosFinais.DataSource = DS.Tables["tb_produtofinal"];

                con.Dispose();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath;

                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + path + @"\database\DBP1-MRP_final.mdb");

                string procura = "SELECT * FROM tb_produtofinal";

                if (textBox1.Text != "")
                {
                    procura = "SELECT * FROM tb_produtofinal WHERE Codigo LIKE " + textBox1.Text + "";
                }

                DataTable dados = new DataTable();

                OleDbDataAdapter adpt = new OleDbDataAdapter(procura, con);

                con.Open();

                adpt.Fill(dados);

                txtTipo.Text = (string)dados.Rows[0][1];
                txtMarca.Text = (string)dados.Rows[0][2];
                txtModelo.Text = (string)dados.Rows[0][3];
                txtAno.Text = (string)dados.Rows[0][4];
                txtDiscorigido.Text = (string)dados.Rows[0][5];
                txtPlacaMae.Text = (string)dados.Rows[0][6];
                txtRAM.Text = (string)dados.Rows[0][7];
                txtGabinete.Text = (string)dados.Rows[0][8];
                txtProcessador.Text = (string)dados.Rows[0][9];
                txtCooler.Text = (string)dados.Rows[0][10];
                txtPlacadeVideo.Text = (string)dados.Rows[0][11];

                string SQL = "SELECT * FROM tb_produtofinal WHERE Codigo = " + textBox1.Text + "";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "tb_produtofinal");

                DgProdutosFinais.DataSource = DS.Tables["tb_produtofinal"];
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbreArquivo(string caminho)
        {
            string caminhoInicial = Application.StartupPath;
            string caminhoArquivo = caminhoInicial.Substring(0, caminhoInicial.Length - 9) + caminho;
            System.Diagnostics.Process.Start(caminhoArquivo);
        }

        private void fichasTécnicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreArquivo(@"assets\2cadastro_produtofinal\fichatecnica.html");
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreArquivo(@"assets\2cadastro_produtofinal\xpto1.html");
        }

        private void FormCadProdFinal_Load(object sender, EventArgs e)
        {

        }
    }
}

