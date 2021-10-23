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
    public partial class AlterarSenha : Form
    {
        CheckData CD = new CheckData();
        NewPassword NP = new NewPassword();

        private string AccaountNumber;
        public AlterarSenha(string accaountNumber)
        {
            AccaountNumber = accaountNumber;
            InitializeComponent();
        }

        private void btn_ACConfirmar_Click(object sender, EventArgs e)
        {
            bool chech = CD.CheckDatabase(AccaountNumber, txb_ACCurrentPassword.Text);
            if (chech == true)
            {
                if (txb_NewPassword.Text == txb_ConfirmPassword.Text)
                {
                    NP.SaveNewPassword(AccaountNumber, txb_NewPassword.Text);
                    MessageBox.Show("Senha Alterada");
                    Close();
                }
                else
                {
                    MessageBox.Show("Nova senha incorreta");
                }
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }

        private void btn_ACCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
