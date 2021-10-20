using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Views
{

    public partial class ListaDeContas : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adapter;

        public DataTable dataTable = new DataTable();

        
        public ListaDeContas()
        {
            InitializeComponent();
            
            CarregarDados();

            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");
                //Exclui uma conta no banco de dados 
                string strSql = "SELECT NUMERODACONTA, NOME FROM CONTABANCARIA";
                Adapter = new MySqlDataAdapter(strSql, Conexao);

                

                Adapter.Fill(dataTable);

                dgv_ListaDeDados.DataSource = Adapter;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }

        private void CarregarDados()
        {
            dataTable.Columns.Add("Número da Conta", typeof(int));
            dataTable.Columns.Add("Nome do cliente", typeof(string));

            dataTable.Rows.Add(new object[] { 123465, "Thiago"});

            dgv_ListaDeDados.DataSource = dataTable;
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ListaDeDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Fecha_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
