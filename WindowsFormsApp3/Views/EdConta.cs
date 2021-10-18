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
using WindowsFormsApp3.Validacao;

namespace WindowsFormsApp3.Views
{
    public partial class EdConta : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;

        public static MySqlDataReader Dr;

        public int nConta;
        public EdConta(string numeroConta)
        {
            nConta = int.Parse(numeroConta);
            InitializeComponent();

            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");

                string strSql = "SELECT * FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", nConta);

                Conexao.Open();

                //preenche os campos com os respectivos dados
                Dr = Comando.ExecuteReader();
                Dr.Read();
                txt_Logradouro.Text = Convert.ToString(Dr["Logradouro"]);
                txt_NumeroR.Text = Convert.ToString(Dr["NumeroDaResidencia"]);
                txt_CEP.Text = Convert.ToString(Dr["CEP"]);
                txt_Cidade.Text = Convert.ToString(Dr["Cidade"]);
                txt_Estado.Text = Convert.ToString(Dr["Estado"]); 
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

        private void btn_NCSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");
                
                //Salva as auterações no banco de dados
                string strSql = "UPDATE CONTABANCARIA SET LOGRADOURO = @LOGRADOURO, NUMERODARESIDENCIA = @NUMERODARESIDENCIA, CEP = @CEP, CIDADE = @CIDADE, ESTADO = @ESTADO WHERE NUMERODACONTA = @NUMERODACONTA";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", nConta);
                Comando.Parameters.AddWithValue("@LOGRADOURO", txt_Logradouro.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@NUMERODARESIDENCIA", txt_NumeroR.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@CEP", txt_CEP.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@CIDADE", txt_Cidade.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@ESTADO", txt_Estado.Text.ValidacaoString());

                Conexao.Open();

                Comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                MessageBox.Show("Dados salvos com sucesso!");
                Conexao.Close();
                Conexao = null;
                Comando = null;
                Close();
            }
        }

        private void btn_NCCancelar_Click(object sender, EventArgs e)
        {

        }

        private void EdConta_Load(object sender, EventArgs e)
        {

        }
    }
}
