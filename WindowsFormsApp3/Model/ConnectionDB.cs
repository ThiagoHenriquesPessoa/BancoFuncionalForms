using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp3.Validacao;

namespace WindowsFormsApp3.Model
{
    class ConnectionDB
    {
        //Conexão com o banco
        public static MySqlConnection Conn;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comm;

        public static MySqlDataAdapter Ad;

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
    class DataList  : ConnectionDB
    {
        public DataTable AccountList()
        {
            DataTable DT = new DataTable();
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "SELECT NUMERODACONTA, NOME FROM contafuncionaldb.contabancaria";
                    Comm = new MySqlCommand(instructionInsertSql, Conn);
                    Ad = new MySqlDataAdapter(instructionInsertSql, Conn);
                                        
                    Ad.Fill(DT);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
                return DT;
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
                    Comm = null;
                }
            }


        }


    }
    //Verifica se o nuúmero e a senha da conta estão corretos
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
                    //Conn = null;
                    Comm = null;
                }
                return check;
            }
        }
    }
    //salva os dados que foram editados
    class SaveData : ConnectionDB
    {
        public void SaveEditedData(string accountNumber, string publicPlace, string houseNumber, string cep, string city, string state)
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

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", accountNumber);
                    Comm.Parameters.AddWithValue("@LOGRADOURO", publicPlace.ValidacaoString());
                    Comm.Parameters.AddWithValue("@NUMERODARESIDENCIA", houseNumber.ValidacaoString());
                    Comm.Parameters.AddWithValue("@CEP", cep.ValidacaoString());
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
                    //Conn = null;
                    Comm = null;
                }
            }
        }
    }
    //exclui uma conta
    class DeleteData : ConnectionDB
    {
        public void DeleteDatabase(string accountNumber, string password)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "DELETE FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA"; Comm.CommandText = instructionInsertSql;
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", int.Parse(accountNumber));



                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {

                    MessageBox.Show("Conta excluida con sucesso!");
                    Conn.Close();
                    Comm = null;
                }
            }
        }
    }
    class AccessAccount : ConnectionDB
    {        
        private string NameClient;
        private string Balance;
        private string PublicPlace;
        private string HouseNumber;
        private string Cep;
        private string City;
        private string State;
        public string AccessData(string accountNumber, int number)
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

                    Dr = Comm.ExecuteReader();
                    Dr.Read();

                    NameClient = Convert.ToString(Dr["NOME"]);
                    Balance = Convert.ToString(Dr["SALDO"]);
                    PublicPlace = Convert.ToString(Dr["Logradouro"]);
                    HouseNumber = Convert.ToString(Dr["NumeroDaResidencia"]);
                    Cep = Convert.ToString(Dr["CEP"]);
                    City = Convert.ToString(Dr["Cidade"]);
                    State = Convert.ToString(Dr["Estado"]);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                    //Conn = null;
                    Comm = null;
                }
                if (number == 1)
                {
                    return PublicPlace + "," + HouseNumber + "," + Cep + "," + City + "," + State;
                }
                else if(number == 2)
                {
                    return NameClient + "," + Balance;
                }
                else
                {
                    return Balance;
                }
                
                
            }
        }

    }
    //Deposito um valor na conta
    class Balance : ConnectionDB
    {
        public void BalanceAmount(string accountNumber, string newBalance)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "UPDATE CONTABANCARIA SET SALDO = @SALDO WHERE NUMERODACONTA = @NUMERODACONTA";
                    Comm.CommandText = instructionInsertSql;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", accountNumber);
                    Comm.Parameters.AddWithValue("@SALDO", newBalance);

                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
            }
        }
    }
    class NewPassword : ConnectionDB
    {
        public void SaveNewPassword(string accountNumber, string password)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "UPDATE CONTABANCARIA SET SENHA = @SENHA WHERE NUMERODACONTA = @NUMERODACONTA";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@NUMERODACONTA", accountNumber);
                    Comm.Parameters.AddWithValue("@SENHA", password.SetaSenha());

                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
            }
        }
    }
}
