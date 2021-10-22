using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Views
{
    public partial class EdConta : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;

        public static MySqlDataReader Dr;

        private string AccountNumber;

        AccessAccount AA = new AccessAccount();
        SaveData SD = new SaveData();
        public EdConta(string numeroConta)
        {

            AccountNumber = numeroConta;
            InitializeComponent();
            string[] data = AA.AccessData(AccountNumber, 1).Split(',');

            txt_Logradouro.Text = data[0];
            txt_NumeroR.Text = data[1];
            txt_CEP.Text = data[2];
            txt_Cidade.Text = data[3];
            txt_Estado.Text = data[4];
        }

        private void btn_NCSalvar_Click(object sender, EventArgs e)
        {
            SD.SaveEditedData(
                AccountNumber,
                txt_Logradouro.Text,
                txt_NumeroR.Text,
                txt_CEP.Text,
                txt_Cidade.Text,
                txt_Estado.Text);
            MessageBox.Show("Dados salvos com sucesso!");
            Close();
        }

        private void btn_NCCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EdConta_Load(object sender, EventArgs e)
        {

        }
    }
}
