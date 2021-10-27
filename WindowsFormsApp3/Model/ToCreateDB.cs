using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BancoFuncional.Model
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
            string server = "186.202.152.237";
            string dataBase = "adpardb";
            string useId = "adpardb";
            string password = "adpar2021@";
            //string port = "3306";

            string connectionString = "server=" + server + ";user id=" + useId + ";database=" + dataBase + "; password=" + password;

            Conn = new MySqlConnection(connectionString);
        }
    }
    class ToCreateDB : ConnectionDB
    {
        public void ToCreateDatabase()
        {
            try
            {
                //Cria um projeto no banco de dados de nome contafuncionaldb se caso ele já não existir
                Conn.Open();
                string instructionProjectSql = "CREATE DATABASE IF NOT EXISTS adpardb; USE adpardb";
                Comm = new MySqlCommand(instructionProjectSql, Conn);
                Comm.ExecuteNonQuery();
                //Cria uma tabela com seus respectivos campos se caso ela já não exista
                string instructionTableSql =
                    "CREATE TABLE IF NOT EXISTS CONTABANCARIA " + 
                    "(NUMERODACONTA INTEGER PRIMARY KEY, " + 
                    "SALDO DECIMAL(10,0), " + 
                    "SENHA VARCHAR(12), " + 
                    "NOME VARCHAR(45), " + 
                    "CPF VARCHAR(45), " + 
                    "LOGRADOURO VARCHAR(100), " +
                    "NUMERODARESIDENCIA INTEGER, " +
                    "CEP VARCHAR(45), " +
                    "CIDADE VARCHAR(45), " +
                    "ESTADO VARCHAR(45)) ";
                Comm = new MySqlCommand(instructionTableSql, Conn);
                Comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                //Fecha conexão
                Conn.Close();
                Comm = null;
            }
        }
    }
}
