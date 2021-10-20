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
        DataInsert DInsert = new DataInsert();

        public NovaConta()
        {
            Random random = new Random();
            int numeroConta = random.Next(50000, 100000);

            InitializeComponent();

            txt_NumeroDC.Text = Convert.ToString(numeroConta);
        }
        private void btn_NovaConta_Click(object sender, EventArgs e)
        {
           DInsert.InsertToDatabase(
               txt_NumeroDC.Text,
               txt_Saldo.Text,
               txt_Senha.Text,
               txt_NomeC.Text,
               txt_CPF.Text,
               txt_Logradouro.Text,
               txt_NumeroR.Text,
               txt_CEP.Text,
               txt_Cidade.Text,
               txt_Estado.Text);
            MessageBox.Show("Account saved successfully");

            Limpa();
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
    }
}
