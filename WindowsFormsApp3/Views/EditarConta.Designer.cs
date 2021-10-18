
namespace WindowsFormsApp3.Views
{
    partial class EditarConta
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
            this.btn_ECCancelar = new System.Windows.Forms.Button();
            this.btn_ECConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_EdSenha = new System.Windows.Forms.TextBox();
            this.txb_EdNConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fecha = new System.Windows.Forms.Label();
            this.pnl_EdConta = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ECCancelar
            // 
            this.btn_ECCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_ECCancelar.FlatAppearance.BorderSize = 0;
            this.btn_ECCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ECCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ECCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ECCancelar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ECCancelar.ForeColor = System.Drawing.Color.White;
            this.btn_ECCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ECCancelar.Location = new System.Drawing.Point(38, 133);
            this.btn_ECCancelar.Name = "btn_ECCancelar";
            this.btn_ECCancelar.Size = new System.Drawing.Size(120, 33);
            this.btn_ECCancelar.TabIndex = 50;
            this.btn_ECCancelar.Text = "Cancelar";
            this.btn_ECCancelar.UseVisualStyleBackColor = false;
            // 
            // btn_ECConfirmar
            // 
            this.btn_ECConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_ECConfirmar.FlatAppearance.BorderSize = 0;
            this.btn_ECConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ECConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ECConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ECConfirmar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ECConfirmar.ForeColor = System.Drawing.Color.White;
            this.btn_ECConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ECConfirmar.Location = new System.Drawing.Point(208, 133);
            this.btn_ECConfirmar.Name = "btn_ECConfirmar";
            this.btn_ECConfirmar.Size = new System.Drawing.Size(120, 33);
            this.btn_ECConfirmar.TabIndex = 49;
            this.btn_ECConfirmar.Text = "Confirmar";
            this.btn_ECConfirmar.UseVisualStyleBackColor = false;
            this.btn_ECConfirmar.Click += new System.EventHandler(this.btn_ECConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(137, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Editar Conta";
            // 
            // txb_EdSenha
            // 
            this.txb_EdSenha.Location = new System.Drawing.Point(164, 93);
            this.txb_EdSenha.Name = "txb_EdSenha";
            this.txb_EdSenha.Size = new System.Drawing.Size(164, 20);
            this.txb_EdSenha.TabIndex = 48;
            // 
            // txb_EdNConta
            // 
            this.txb_EdNConta.Location = new System.Drawing.Point(164, 67);
            this.txb_EdNConta.Name = "txb_EdNConta";
            this.txb_EdNConta.Size = new System.Drawing.Size(164, 20);
            this.txb_EdNConta.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Número da Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(34, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Senha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fecha);
            this.panel1.Controls.Add(this.btn_ECConfirmar);
            this.panel1.Controls.Add(this.btn_ECCancelar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_EdSenha);
            this.panel1.Controls.Add(this.txb_EdNConta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 51;
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fecha.AutoSize = true;
            this.btn_Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_Fecha.Location = new System.Drawing.Point(373, 12);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(15, 13);
            this.btn_Fecha.TabIndex = 51;
            this.btn_Fecha.Text = "X";
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // pnl_EdConta
            // 
            this.pnl_EdConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_EdConta.Location = new System.Drawing.Point(0, 200);
            this.pnl_EdConta.Name = "pnl_EdConta";
            this.pnl_EdConta.Size = new System.Drawing.Size(400, 400);
            this.pnl_EdConta.TabIndex = 52;
            // 
            // EditarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.pnl_EdConta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarConta";
            this.Text = "EditarConta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ECCancelar;
        private System.Windows.Forms.Button btn_ECConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_EdSenha;
        private System.Windows.Forms.TextBox txb_EdNConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_EdConta;
        private System.Windows.Forms.Label btn_Fecha;
    }
}