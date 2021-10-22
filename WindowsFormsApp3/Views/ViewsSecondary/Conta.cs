using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Views.ViewsSecondary;

namespace WindowsFormsApp3.Views
{
   
     
    public partial class Conta : Form
    {
        private string AccaountNumber;
        public Conta(string accountNumber, string name, string balace)
        {
            InitializeComponent();
            AccaountNumber = accountNumber;
            lbl_NomedoCliente.Text = name;
            txb_ACBalance.Text = balace;
            txb_ACBalance.ReadOnly = true;
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

            AbrirFormPainel(new Deposit(AccaountNumber));
        }
    }
}
