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

        public static MySqlDataReader Dr;

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
    class CheckData : ConnectionDB
    {
        public bool CheckDatabase(string accountNumber, string password)
        {
            using (Comm = new MySqlCommand())
            {
                bool check = false;
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "SELECT * FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", accountNumber);

                    Dr = Comm.ExecuteReader();
                    Dr.Read();

                    string accountN = Convert.ToString(Dr["NUMERODACONTA"]);
                    string pass = Convert.ToString(Dr["SENHA"]);
                    password.SetaSenha();

                    if (accountNumber == accountN && password == pass)
                    {
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Conn = null;
                    Comm = null;
                }
                return check;
            }
        }
    }
    class EditData : ConnectionDB
    {
        public string PublicPlace { get; set; }
        public string HouseNumber { get; set; }
        public string Cep { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public void EditDatabase(string accountNumber)
        {

            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "SELECT * FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", accountNumber);

                    //preenche os campos com os respectivos dados
                    Dr = Comm.ExecuteReader();
                    Dr.Read();

                    PublicPlace = Convert.ToString(Dr["Logradouro"]);
                    HouseNumber = Convert.ToString(Dr["NumeroDaResidencia"]);
                    Cep = Convert.ToString(Dr["CEP"]);
                    City = Convert.ToString(Dr["Cidade"]);
                    State = Convert.ToString(Dr["Estado"]);
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
    class SaveData : ConnectionDB
    {
        public void SaveEditedData()
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "UPDATE CONTABANCARIA SET LOGRADOURO = @LOGRADOURO, NUMERODARESIDENCIA = @NUMERODARESIDENCIA, CEP = @CEP, CIDADE = @CIDADE, ESTADO = @ESTADO WHERE NUMERODACONTA = @NUMERODACONTA";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", numeroConta);
                    Comm.Parameters.AddWithValue("@LOGRADOURO", txt_Logradouro.Text.ValidacaoString());
                    Comm.Parameters.AddWithValue("@NUMERODARESIDENCIA", txt_NumeroR.Text.ValidacaoString());
                    Comm.Parameters.AddWithValue("@CEP", txt_CEP.Text.ValidacaoString());
                    Comm.Parameters.AddWithValue("@CIDADE", txt_Cidade.Text.ValidacaoString());
                    Comm.Parameters.AddWithValue("@ESTADO", txt_Estado.Text.ValidacaoString());

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
        }
    }

}
