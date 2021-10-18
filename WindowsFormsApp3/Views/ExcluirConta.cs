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

namespace WindowsFormsApp3.Views
{
    public partial class ExcluirConta : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;
        public ExcluirConta()
        {
            InitializeComponent();
        }        

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btn_ECConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");
                //Exclui uma conta no banco de dados 
                string strSql = "DELETE FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", int.Parse(txb_NumeroDC.Text));

                Conexao.Open();

                Comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                
                MessageBox.Show("Conta excluida con sucesso!");
                Limpa();
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }

        private void ExcluirConta_Load(object sender, EventArgs e)
        {

        }
        private void Limpa()
        {
            txb_NumeroDC.Clear();
            txb_Senha.Clear();
        }

        private void btn_ECCancelar_Click(object sender, EventArgs e)
        {
            Limpa();
        }
    }
}
