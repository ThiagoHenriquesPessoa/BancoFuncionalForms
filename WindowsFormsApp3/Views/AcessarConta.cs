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
    public partial class AcessarConta : Form
    {
        CheckData CD = new CheckData();
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
                AbrirFormPainel(new Conta());
            }
            
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
