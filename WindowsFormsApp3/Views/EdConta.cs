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

        EditData ED = new EditData();
        public EdConta(string numeroConta)
        {
            InitializeComponent();
            ED.EditDatabase(numeroConta);

            txt_Logradouro.Text = ED.PublicPlace;
            txt_NumeroR.Text = ED.HouseNumber;
            txt_CEP.Text = ED.Cep;
            txt_Cidade.Text = ED.City;
            txt_Estado.Text = ED.State;
        }

        private void btn_NCSalvar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_NCCancelar_Click(object sender, EventArgs e)
        {

        }

        private void EdConta_Load(object sender, EventArgs e)
        {

        }
    }
}
