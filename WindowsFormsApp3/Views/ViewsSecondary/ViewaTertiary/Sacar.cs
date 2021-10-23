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

namespace BancoFuncional.Views.ViewsSecondary.ViewaTertiary
{
    public partial class Sacar : Form
    {
        AccessAccount AA = new AccessAccount();
        Balance Bl = new Balance();

        private string AccountNumber;
        public Sacar(string accountNumber)
        {
            AccountNumber = accountNumber;
            InitializeComponent();
        }
        public Sacar(string accountNumber, string value)
        {
            WithdrawValue(accountNumber, value);
        }

        private void btn_ACConfirmar_Click(object sender, EventArgs e)
        {
            WithdrawValue(AccountNumber, txb_ACWithdrawalAmount.Text);
            MessageBox.Show("Saque realisado com sucesso");
            Close();
        }
        private void WithdrawValue(string accountNumber, string value)
        {
            int balace = int.Parse(AA.AccessData(accountNumber, 3));
            if (balace >= int.Parse(value))
            {
                balace -= int.Parse(value);

                Bl.BalanceAmount(accountNumber, Convert.ToString(balace));
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void btn_ACCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
