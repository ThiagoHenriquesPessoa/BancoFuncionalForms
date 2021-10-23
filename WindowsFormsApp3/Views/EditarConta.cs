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
    public partial class EditarConta : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conexao;

        //responsavel pelas instruções a serem executadas
        public static MySqlCommand Comando;

        public static MySqlDataReader Dr;

        CheckData ED = new CheckData();
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
            bool check = ED.CheckDatabase(txb_EdNConta.Text, txb_EdSenha.Text);
            if (check == true)
            {
                txb_EdNConta.ReadOnly = true;
                txb_EdSenha.ReadOnly = true;
                btn_ECConfirmar.Visible = false;
                btn_ECCancelar.Visible = false;                

                AbrirFormPainel(new EdConta(txb_EdNConta.Text));
            }
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ECCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EditarConta_Load(object sender, EventArgs e)
        {

        }
    }
}
