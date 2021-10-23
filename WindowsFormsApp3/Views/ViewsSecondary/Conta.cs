using BancoFuncional.Views.ViewsSecondary.ViewaTertiary;
using System;
using System.Windows.Forms;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Views.ViewsSecondary;

namespace WindowsFormsApp3.Views
{
   
     
    public partial class Conta : Form
    {
        AccessAccount AA = new AccessAccount();

        private string AccaountNumber;
        public Conta(string accountNumber, string name, string balace)
        {
            InitializeComponent();
            AccaountNumber = accountNumber;
            lbl_NomedoCliente.Text = name;
            txb_ACBalance.Text = balace;
            txb_ACBalance.Visible = false;
            
        }
        private void AbrirFormPainel(object Formhijo)
        {
            if (this.pnl_DTAS.Controls.Count > 0)
            {
                this.pnl_DTAS.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_DTAS.Controls.Add(fh);
            this.pnl_DTAS.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txb_ACBalance.Visible = false;
            AbrirFormPainel(new Deposit(AccaountNumber));
        }

        private void Conta_Load(object sender, EventArgs e)
        {

        }

        private void btn_CSaldo_Click(object sender, EventArgs e)
        {
            txb_ACBalance.Text = AA.AccessData(AccaountNumber, 3);
            txb_ACBalance.Visible = true;
            txb_ACBalance.ReadOnly = true;
        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            txb_ACBalance.Visible = false;
            AbrirFormPainel(new Sacar(AccaountNumber));
        }

        private void btn_ECCancelar_Click(object sender, EventArgs e)
        {
            txb_ACBalance.Visible = false;
            AbrirFormPainel(new Transferir(AccaountNumber));
        }

        private void btn_ECConfirmar_Click(object sender, EventArgs e)
        {
            txb_ACBalance.Visible = false;
            AbrirFormPainel(new AlterarSenha(AccaountNumber));
        }
    }
}
