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
        DepositAccount Dp = new DepositAccount();

        private string AccountNumber;
        public Deposit(string accountNumber)
        {
            AccountNumber = accountNumber;
            InitializeComponent();
        }

        private void btn_ACConfirmar_Click(object sender, EventArgs e)
        {
            int balace = int.Parse(AA.AccessData(AccountNumber, 3));
            balace += int.Parse(txb_ACDepositAmount.Text);

            Dp.DepositAmount(AccountNumber, Convert.ToString(balace));
            MessageBox.Show("Deposito realisado com sucesso");
            Close();
        }

        private void btn_ACCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
