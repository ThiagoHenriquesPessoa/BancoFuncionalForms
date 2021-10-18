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
using WindowsFormsApp3.Validacao;

namespace WindowsFormsApp3.Views
{
    public partial class EditarConta : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;

        public static MySqlDataReader Dr;
        public EditarConta()
        {
            InitializeComponent();
        }
        private void AbrirFormPainel(object Formhijo)
        {
            if (this.pnl_EdConta.Controls.Count > 0)
            {
                this.pnl_EdConta.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_EdConta.Controls.Add(fh);
            this.pnl_EdConta.Tag = fh;
            fh.Show();
        }

        private void btn_ECConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;user id=Thiago;database=contafuncionaldb; password=Rayane18@; port=3306");

                string strSql = "SELECT * FROM CONTABANCARIA WHERE NUMERODACONTA = @NUMERODACONTA";
                Comando = new MySqlCommand(strSql, Conexao);
                Comando.Parameters.AddWithValue("@NUMERODACONTA", txb_EdNConta.Text);

                Conexao.Open();

                Dr = Comando.ExecuteReader();
                Dr.Read();

                string numeroConta = Convert.ToString(Dr["NUMERODACONTA"]);
                string senha = Convert.ToString(Dr["SENHA"]);
                SetaSenha(txb_EdSenha.Text);
                
                if (txb_EdNConta.Text == numeroConta && txb_EdSenha.Text == senha)
                {

                    txb_EdNConta.ReadOnly = true;
                    txb_EdSenha.ReadOnly = true;
                    btn_ECConfirmar.Visible = false;
                    btn_ECCancelar.Visible = false;
                    AbrirFormPainel(new EdConta(txb_EdNConta.Text));
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
                Conexao = null;
                Comando = null;
            }
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

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
