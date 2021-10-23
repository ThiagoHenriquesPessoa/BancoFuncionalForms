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

namespace WindowsFormsApp3.Views.ViewsSecondary
{
    public partial class Deposit : Form
    {
        AccessAccount AA = new AccessAccount();
        Balance Bl = new Balance();
        

        private string AccountNumber;
        
        public Deposit(string accountNumber)
        {
            AccountNumber = accountNumber;
            InitializeComponent();
        }
        public Deposit(string accountNumber, string amount)
        {
            DepositAmount(accountNumber, amount);
        }

        private void btn_ACConfirmar_Click(object sender, EventArgs e)
        {
            DepositAmount(AccountNumber, txb_ACDepositAmount.Text);
            MessageBox.Show("Deposito realisado com sucesso");
            Close();
        }

        private void DepositAmount(string accountNumber, string amount)
        {
            int balace = int.Parse(AA.AccessData(accountNumber, 3));
            balace += int.Parse(amount);

            Bl.BalanceAmount(accountNumber, Convert.ToString(balace));
        }

        private void btn_ACCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
