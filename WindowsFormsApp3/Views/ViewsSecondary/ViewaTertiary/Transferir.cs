using System;
using System.Windows.Forms;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Views.ViewsSecondary;

namespace BancoFuncional.Views.ViewsSecondary.ViewaTertiary
{
    public partial class Transferir : Form
    {
        AccessAccount AA = new AccessAccount();
        Balance Bl = new Balance();
        CheckData CD = new CheckData();
         

        private string AccountNumber;
        public Transferir(string accountNumber)
        {
            AccountNumber = accountNumber;

            InitializeComponent();
        }

        private void btn_ACConfirmar_Click(object sender, EventArgs e)
        {
            bool check = CD.CheckDatabase(AccountNumber, txb_ConfirmationPassword.Text);
            if (check == true)
            {
                Sacar Sc = new Sacar(AccountNumber, txb_TransferAmount.Text);
                Deposit Dp = new Deposit(txb_ACDestinationAccount.Text, txb_TransferAmount.Text);
                MessageBox.Show("Transferencia realizada com sucesso");
            }
            else
            {
                MessageBox.Show("Numero da conta ou senha incorreto");
            }
            Close();
        }

        private void btn_ACCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
