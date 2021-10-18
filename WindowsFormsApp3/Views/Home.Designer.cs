
namespace WindowsFormsApp3
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btn_EditarC = new System.Windows.Forms.Button();
            this.btn_AcessarConta = new System.Windows.Forms.Button();
            this.btn_ExcluirConta = new System.Windows.Forms.Button();
            this.btn_NovaConta = new System.Windows.Forms.Button();
            this.btn_ListaDeContas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnFechar = new System.Windows.Forms.PictureBox();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.PainelContencedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DarkGreen;
            this.MenuVertical.Controls.Add(this.btn_EditarC);
            this.MenuVertical.Controls.Add(this.btn_AcessarConta);
            this.MenuVertical.Controls.Add(this.btn_ExcluirConta);
            this.MenuVertical.Controls.Add(this.btn_NovaConta);
            this.MenuVertical.Controls.Add(this.btn_ListaDeContas);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // btn_EditarC
            // 
            this.btn_EditarC.FlatAppearance.BorderSize = 0;
            this.btn_EditarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_EditarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_EditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarC.ForeColor = System.Drawing.Color.White;
            this.btn_EditarC.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditarC.Image")));
            this.btn_EditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarC.Location = new System.Drawing.Point(-6, 261);
            this.btn_EditarC.Name = "btn_EditarC";
            this.btn_EditarC.Size = new System.Drawing.Size(256, 50);
            this.btn_EditarC.TabIndex = 5;
            this.btn_EditarC.Text = "Editar Conta";
            this.btn_EditarC.UseVisualStyleBackColor = true;
            this.btn_EditarC.Click += new System.EventHandler(this.btn_EditarC_Click);
            // 
            // btn_AcessarConta
            // 
            this.btn_AcessarConta.FlatAppearance.BorderSize = 0;
            this.btn_AcessarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_AcessarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_AcessarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AcessarConta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcessarConta.ForeColor = System.Drawing.Color.White;
            this.btn_AcessarConta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AcessarConta.Image")));
            this.btn_AcessarConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AcessarConta.Location = new System.Drawing.Point(-6, 317);
            this.btn_AcessarConta.Name = "btn_AcessarConta";
            this.btn_AcessarConta.Size = new System.Drawing.Size(256, 50);
            this.btn_AcessarConta.TabIndex = 4;
            this.btn_AcessarConta.Text = "Acessar Conta";
            this.btn_AcessarConta.UseVisualStyleBackColor = true;
            this.btn_AcessarConta.Click += new System.EventHandler(this.btn_AcessarConta_Click);
            // 
            // btn_ExcluirConta
            // 
            this.btn_ExcluirConta.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ExcluirConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ExcluirConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirConta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirConta.ForeColor = System.Drawing.Color.White;
            this.btn_ExcluirConta.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirConta.Image")));
            this.btn_ExcluirConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExcluirConta.Location = new System.Drawing.Point(-6, 205);
            this.btn_ExcluirConta.Name = "btn_ExcluirConta";
            this.btn_ExcluirConta.Size = new System.Drawing.Size(256, 50);
            this.btn_ExcluirConta.TabIndex = 3;
            this.btn_ExcluirConta.Text = "Excluir Conta";
            this.btn_ExcluirConta.UseVisualStyleBackColor = true;
            this.btn_ExcluirConta.Click += new System.EventHandler(this.btn_ExcluirConta_Click);
            // 
            // btn_NovaConta
            // 
            this.btn_NovaConta.FlatAppearance.BorderSize = 0;
            this.btn_NovaConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_NovaConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_NovaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NovaConta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaConta.ForeColor = System.Drawing.Color.White;
            this.btn_NovaConta.Image = ((System.Drawing.Image)(resources.GetObject("btn_NovaConta.Image")));
            this.btn_NovaConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NovaConta.Location = new System.Drawing.Point(-6, 149);
            this.btn_NovaConta.Name = "btn_NovaConta";
            this.btn_NovaConta.Size = new System.Drawing.Size(256, 50);
            this.btn_NovaConta.TabIndex = 2;
            this.btn_NovaConta.Text = "Nova Conta";
            this.btn_NovaConta.UseVisualStyleBackColor = true;
            this.btn_NovaConta.Click += new System.EventHandler(this.btn_NovaConta_Click);
            // 
            // btn_ListaDeContas
            // 
            this.btn_ListaDeContas.FlatAppearance.BorderSize = 0;
            this.btn_ListaDeContas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ListaDeContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ListaDeContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListaDeContas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListaDeContas.ForeColor = System.Drawing.Color.White;
            this.btn_ListaDeContas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ListaDeContas.Image")));
            this.btn_ListaDeContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ListaDeContas.Location = new System.Drawing.Point(-6, 93);
            this.btn_ListaDeContas.Name = "btn_ListaDeContas";
            this.btn_ListaDeContas.Size = new System.Drawing.Size(256, 50);
            this.btn_ListaDeContas.TabIndex = 1;
            this.btn_ListaDeContas.Text = "Lista de Contas";
            this.btn_ListaDeContas.UseVisualStyleBackColor = true;
            this.btn_ListaDeContas.Click += new System.EventHandler(this.btn_NovaRenda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.Controls.Add(this.BtnMinimizar);
            this.BarraDeTitulo.Controls.Add(this.BtnFechar);
            this.BarraDeTitulo.Controls.Add(this.BtnSlide);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(400, 50);
            this.BarraDeTitulo.TabIndex = 1;
            this.BarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraDeTitulo_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(312, 9);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(353, 9);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(35, 35);
            this.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.TabStop = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnSlide
            // 
            this.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSlide.Image = ((System.Drawing.Image)(resources.GetObject("BtnSlide.Image")));
            this.BtnSlide.Location = new System.Drawing.Point(6, 9);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(35, 35);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSlide.TabIndex = 0;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // PainelContencedor
            // 
            this.PainelContencedor.BackColor = System.Drawing.Color.White;
            this.PainelContencedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PainelContencedor.BackgroundImage")));
            this.PainelContencedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PainelContencedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelContencedor.Location = new System.Drawing.Point(200, 50);
            this.PainelContencedor.Name = "PainelContencedor";
            this.PainelContencedor.Size = new System.Drawing.Size(400, 600);
            this.PainelContencedor.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.PainelContencedor);
            this.Controls.Add(this.BarraDeTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraDeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.Panel PainelContencedor;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnFechar;
        private System.Windows.Forms.Button btn_ListaDeContas;
        private System.Windows.Forms.Button btn_AcessarConta;
        private System.Windows.Forms.Button btn_ExcluirConta;
        private System.Windows.Forms.Button btn_NovaConta;
        private System.Windows.Forms.Button btn_EditarC;
    }
}

