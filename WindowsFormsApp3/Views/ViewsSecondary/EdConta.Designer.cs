
namespace WindowsFormsApp3.Views
{
    partial class EdConta
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
            this.btn_NCCancelar = new System.Windows.Forms.Button();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.txt_NumeroR = new System.Windows.Forms.TextBox();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_NCSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NCCancelar
            // 
            this.btn_NCCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_NCCancelar.FlatAppearance.BorderSize = 0;
            this.btn_NCCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_NCCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_NCCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NCCancelar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NCCancelar.ForeColor = System.Drawing.Color.White;
            this.btn_NCCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NCCancelar.Location = new System.Drawing.Point(57, 183);
            this.btn_NCCancelar.Name = "btn_NCCancelar";
            this.btn_NCCancelar.Size = new System.Drawing.Size(120, 33);
            this.btn_NCCancelar.TabIndex = 53;
            this.btn_NCCancelar.Text = "Cancelar";
            this.btn_NCCancelar.UseVisualStyleBackColor = false;
            this.btn_NCCancelar.Click += new System.EventHandler(this.btn_NCCancelar_Click);
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(188, 143);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(153, 20);
            this.txt_Estado.TabIndex = 52;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(188, 114);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(153, 20);
            this.txt_Cidade.TabIndex = 51;
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(188, 87);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(153, 20);
            this.txt_CEP.TabIndex = 50;
            // 
            // txt_NumeroR
            // 
            this.txt_NumeroR.Location = new System.Drawing.Point(188, 61);
            this.txt_NumeroR.Name = "txt_NumeroR";
            this.txt_NumeroR.Size = new System.Drawing.Size(153, 20);
            this.txt_NumeroR.TabIndex = 49;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(188, 35);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(153, 20);
            this.txt_Logradouro.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label9.Location = new System.Drawing.Point(53, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label8.Location = new System.Drawing.Point(53, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(53, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(53, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(53, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Logradouro";
            // 
            // btn_NCSalvar
            // 
            this.btn_NCSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_NCSalvar.FlatAppearance.BorderSize = 0;
            this.btn_NCSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_NCSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_NCSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NCSalvar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NCSalvar.ForeColor = System.Drawing.Color.White;
            this.btn_NCSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NCSalvar.Location = new System.Drawing.Point(221, 183);
            this.btn_NCSalvar.Name = "btn_NCSalvar";
            this.btn_NCSalvar.Size = new System.Drawing.Size(120, 33);
            this.btn_NCSalvar.TabIndex = 30;
            this.btn_NCSalvar.Text = "Salvar";
            this.btn_NCSalvar.UseVisualStyleBackColor = false;
            this.btn_NCSalvar.Click += new System.EventHandler(this.btn_NCSalvar_Click);
            // 
            // EdConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btn_NCCancelar);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt_NumeroR);
            this.Controls.Add(this.txt_Logradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_NCSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdConta";
            this.Text = "EdConta";
            this.Load += new System.EventHandler(this.EdConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NCCancelar;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.TextBox txt_NumeroR;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_NCSalvar;
    }
}