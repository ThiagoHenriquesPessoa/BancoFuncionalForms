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

namespace WindowsFormsApp3.Views
{

    public partial class ListaDeContas : Form
    {
        //Conexão com o banco
        public static MySqlConnection Conn;

        public static MySqlCommand Comm;

        public static MySqlDataAdapter Ad;

        DataList DL = new DataList();



        public ListaDeContas()
        {
            InitializeComponent();
            DataTable Dt = new DataTable();
            Dt = DL.AccountList();
            dgv_ListaDeDados.DataSource = Dt;
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ListaDeDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Fecha_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
