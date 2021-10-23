using System;
using System.Windows.Forms;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Views
{
    public partial class ExcluirConta : Form
    {
        CheckData CD = new CheckData();
        DeleteData DD = new DeleteData();
        public ExcluirConta()
        {
            InitializeComponent();
        }        

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ECConfirmar_Click(object sender, EventArgs e)
        {
            bool check = CD.CheckDatabase(txb_NumeroDC.Text, txb_Senha.Text);
            if (check == true)
            {
                DD.DeleteDatabase(txb_NumeroDC.Text, txb_Senha.Text);
            }
            txb_NumeroDC.Clear();
            txb_Senha.Clear();

        }

        private void btn_ECCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcluirConta_Load(object sender, EventArgs e)
        {

        }
    }
}
