using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3.Model
{
    public static class ContaBancaria
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;

        //insere os dados na tabela
        //public static MySqlDataAdapter Adaptador;

        
        //public static MySqlDataReader Le;
 
        public static void EdContaBancaria(int numeroDaConta, string senha, string nome, string cPF, string rG, string logradouro, int numeroDaResidencia, string cEP, string cidade, string estado)
        {

            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");

                string strSql = "UPDATE CONTABANCARIA SET NUMERODACONTA, LOGRADOURO, NUMERODARESIDENCIA, CEP, CIDADE, ESTADO) VALUES (@NUMERODACONTA, @LOGRADOURO, @NUMERODARESIDENCIA, @CEP, @CIDADE, @ESTADO)";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", numeroDaConta);
                Comando.Parameters.AddWithValue("@LOGRADOURO", logradouro);
                Comando.Parameters.AddWithValue("@NUMERODARESIDENCIA", numeroDaResidencia);
                Comando.Parameters.AddWithValue("@CEP", cEP);
                Comando.Parameters.AddWithValue("@CIDADE", cidade);
                Comando.Parameters.AddWithValue("@ESTADO", estado);

                Conexao.Open();

                Comando.ExecuteNonQuery();
                MessageBox.Show("Dados salvos com sucesso!");
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
        public static void ExContaBancaria(int numeroDaConta)
        {

            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");

                string strSql = "DELET FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", numeroDaConta);

                Conexao.Open();

                Comando.ExecuteNonQuery();
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

    }
}
