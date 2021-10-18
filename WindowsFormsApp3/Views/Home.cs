using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApp3.Views;

namespace WindowsFormsApp3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width==200)
            {
                MenuVertical.Width = 60;
            }
            else
            {
                MenuVertical.Width = 200;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }        

        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormPainel(object Formhijo)
        {
            if (this.PainelContencedor.Controls.Count>0)
            {
                this.PainelContencedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PainelContencedor.Controls.Add(fh);
            this.PainelContencedor.Tag = fh;
            fh.Show();
        }

        private void btn_NovaRenda_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new ListaDeContas());
        }

        private void btn_NovaConta_Click(object sender, EventArgs e)
        {            
            AbrirFormPainel(new NovaConta());
        }

        private void btn_ExcluirConta_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new ExcluirConta());
        }

        private void btn_AcessarConta_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new AcessarConta());

        }

        private void btn_EditarC_Click(object sender, EventArgs e)
        {
            AbrirFormPainel(new EditarConta());
        }
    }
}
