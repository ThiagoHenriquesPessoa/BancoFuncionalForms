using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Views
{
    public partial class AcessarConta : Form
    {
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
            AbrirFormPainel(new Conta());
        }

        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
