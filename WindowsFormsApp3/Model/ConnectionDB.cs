using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp3.Validacao;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3.Model
{
    class ConnectionDB
    {
        //Conexão com o banco
        public static MySqlConnection Conn;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comm;

        //Função de conexão com o banco
        public ConnectionDB()
        {
            string server = "localhost";
            string dataBase = "contafuncionaldb";
            string useId = "Thiago";
            string password = "Rayane18@";
            string port = "3306";

            string connectionString = "server=" + server + ";user id=" + useId + ";database=" + dataBase + "; password=" + password + "; port=" + port;

            Conn = new MySqlConnection(connectionString);
        }
    }
    //Classe para inserir os dados
    class DataInsert : ConnectionDB
    {
        //Função para inserir os dados
        public void InsertToDatabase(string accountNumber, string balance, string password, string name, string cPF, string publicPlace, string houseNumber, string cEP, string city, string state)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "INSERT INTO CONTABANCARIA (NUMERODACONTA, SALDO, SENHA, NOME, CPF, LOGRADOURO, NUMERODARESIDENCIA, CEP, CIDADE, ESTADO) VALUES (@NUMERODACONTA, @SALDO, @SENHA, @NOME, @CPF, @LOGRADOURO, @NUMERODARESIDENCIA, @CEP, @CIDADE, @ESTADO)";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", accountNumber.ValidacaoString());
                    Comm.Parameters.AddWithValue("@SALDO", balance.ValidacaoString());
                    Comm.Parameters.AddWithValue("@SENHA", password.SetaSenha());
                    Comm.Parameters.AddWithValue("@NOME", name.ValidacaoString());
                    Comm.Parameters.AddWithValue("@CPF", cPF.ValidacaoString());
                    Comm.Parameters.AddWithValue("@LOGRADOURO", publicPlace.ValidacaoString());
                    Comm.Parameters.AddWithValue("@NUMERODARESIDENCIA", houseNumber.ValidacaoString());
                    Comm.Parameters.AddWithValue("@CEP", cEP.ValidacaoString());
                    Comm.Parameters.AddWithValue("@CIDADE", city.ValidacaoString());
                    Comm.Parameters.AddWithValue("@ESTADO", state.ValidacaoString());


                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Conn = null;
                    Comm = null;
                }
            }


        }


    }

}
