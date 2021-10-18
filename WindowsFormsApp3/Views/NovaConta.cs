using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Validacao;

namespace WindowsFormsApp3.Views
{
    public partial class NovaConta : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;
        public NovaConta()
        {
            Random random = new Random();
            int numeroConta = random.Next(50000, 100000);

            InitializeComponent();

            txt_NumeroDC.Text = Convert.ToString(numeroConta);
        }

        private void btn_NovaRenda_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");

                string strSql = "INSERT INTO CONTABANCARIA (NUMERODACONTA, SALDO, SENHA, NOME, CPF, LOGRADOURO, NUMERODARESIDENCIA, CEP, CIDADE, ESTADO) VALUES (@NUMERODACONTA, @SALDO, @SENHA, @NOME, @CPF, @LOGRADOURO, @NUMERODARESIDENCIA, @CEP, @CIDADE, @ESTADO)";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", txt_NumeroDC.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@SALDO", txt_Saldo.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@SENHA", SetaSenha(txt_Senha.Text));
                Comando.Parameters.AddWithValue("@NOME", txt_NomeC.Text.ValidacaoString());
                Comando.Parameters.AddWithValue("@CPF", txt_CPF.Text.ValidacaoString());
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
                MessageBox.Show("Conta salvos com sucesso!");
                Limpa();
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
        }
        private void Limpa()
        {
            Random random = new Random();
            int numeroConta = random.Next(50000, 100000);
            txt_NumeroDC.Text = Convert.ToString(numeroConta);
            txt_Saldo.Clear();
            txt_Senha.Clear();
            txt_NomeC.Clear();
            txt_CPF.Clear();
            txt_RG.Clear();
            txt_Logradouro.Clear();
            txt_NumeroR.Clear();
            txt_CEP.Clear();
            txt_Cidade.Clear();
            txt_Estado.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string SetaSenha(string senha)
        {
            senha = senha.ValidacaoString();
            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                throw new Exception("Senha invalida");
            }
            return senha;
        }
    }
}
