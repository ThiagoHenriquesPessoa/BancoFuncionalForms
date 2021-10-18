
namespace WindowsFormsApp3.Views
{
    partial class ExcluirConta
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
            this.btn_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NumeroDC = new System.Windows.Forms.TextBox();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.btn_ECCancelar = new System.Windows.Forms.Button();
            this.btn_ECConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fecha.AutoSize = true;
            this.btn_Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_Fecha.Location = new System.Drawing.Point(303, 9);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(15, 13);
            this.btn_Fecha.TabIndex = 6;
            this.btn_Fecha.Text = "X";
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Excluir Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número da Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha";
            // 
            // txb_NumeroDC
            // 
            this.txb_NumeroDC.Location = new System.Drawing.Point(143, 65);
            this.txb_NumeroDC.Name = "txb_NumeroDC";
            this.txb_NumeroDC.Size = new System.Drawing.Size(164, 20);
            this.txb_NumeroDC.TabIndex = 11;
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(143, 91);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.Size = new System.Drawing.Size(164, 20);
            this.txb_Senha.TabIndex = 12;
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
            this.btn_ECCancelar.Location = new System.Drawing.Point(17, 130);
            this.btn_ECCancelar.Name = "btn_ECCancelar";
            this.btn_ECCancelar.Size = new System.Drawing.Size(120, 33);
            this.btn_ECCancelar.TabIndex = 31;
            this.btn_ECCancelar.Text = "Cancelar";
            this.btn_ECCancelar.UseVisualStyleBackColor = false;
            this.btn_ECCancelar.Click += new System.EventHandler(this.btn_ECCancelar_Click);
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
            this.btn_ECConfirmar.Location = new System.Drawing.Point(187, 130);
            this.btn_ECConfirmar.Name = "btn_ECConfirmar";
            this.btn_ECConfirmar.Size = new System.Drawing.Size(120, 33);
            this.btn_ECConfirmar.TabIndex = 30;
            this.btn_ECConfirmar.Text = "Confirmar";
            this.btn_ECConfirmar.UseVisualStyleBackColor = false;
            this.btn_ECConfirmar.Click += new System.EventHandler(this.btn_ECConfirmar_Click);
            // 
            // ExcluirConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 198);
            this.Controls.Add(this.btn_ECCancelar);
            this.Controls.Add(this.btn_ECConfirmar);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.txb_NumeroDC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Fecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcluirConta";
            this.Text = "ExcluirConta";
            this.Load += new System.EventHandler(this.ExcluirConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NumeroDC;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.Button btn_ECCancelar;
        private System.Windows.Forms.Button btn_ECConfirmar;
    }
}