using System;
using System.Windows.Forms;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Views
{
    public partial class AcessarConta : Form
    {
        CheckData CD = new CheckData();
        AccessAccount AA = new AccessAccount();
        public AcessarConta()
        {
            InitializeComponent();
        }
        private void AbrirFormPainel(object Formhijo)
        {
            if (this.pnl_Conta.Controls.Count > 0)
            {
                this.pnl_Conta.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Conta.Controls.Add(fh);
            this.pnl_Conta.Tag = fh;
            fh.Show();
        }

        private void btn_ECConfirmar_Click(object sender, EventArgs e)
        {
            bool check = CD.CheckDatabase(txb_NCAcessar.Text, txb_SAcessar.Text);
            if (check == true)
            {                
                string[] data = AA.AccessData(txb_NCAcessar.Text, 2).Split(',');
                string name = data[0];
                string balance = data[1];

                txb_NCAcessar.ReadOnly = true;
                txb_SAcessar.ReadOnly = true;
                btn_ECConfirmar.Visible = false;

                AbrirFormPainel(new Conta(txb_NCAcessar.Text, name, balance));
            }
            
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ECCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
