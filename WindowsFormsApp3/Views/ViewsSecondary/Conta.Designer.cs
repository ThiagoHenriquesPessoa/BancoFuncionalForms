
namespace WindowsFormsApp3.Views
{
    partial class Conta
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
            this.lbl_NomedoCliente = new System.Windows.Forms.Label();
            this.txb_ACBalance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_DTAS = new System.Windows.Forms.PictureBox();
            this.btn_CSaldo = new System.Windows.Forms.Button();
            this.btn_Sacar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_DTAS)).BeginInit();
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
            this.btn_ECCancelar.Location = new System.Drawing.Point(17, 172);
            this.btn_ECCancelar.Name = "btn_ECCancelar";
            this.btn_ECCancelar.Size = new System.Drawing.Size(139, 33);
            this.btn_ECCancelar.TabIndex = 48;
            this.btn_ECCancelar.Text = "Transferência";
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
            this.btn_ECConfirmar.Location = new System.Drawing.Point(17, 211);
            this.btn_ECConfirmar.Name = "btn_ECConfirmar";
            this.btn_ECConfirmar.Size = new System.Drawing.Size(139, 33);
            this.btn_ECConfirmar.TabIndex = 47;
            this.btn_ECConfirmar.Text = "Alterar Senha";
            this.btn_ECConfirmar.UseVisualStyleBackColor = false;
            this.btn_ECConfirmar.Click += new System.EventHandler(this.btn_ECConfirmar_Click);
            // 
            // lbl_NomedoCliente
            // 
            this.lbl_NomedoCliente.AutoSize = true;
            this.lbl_NomedoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomedoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.lbl_NomedoCliente.Location = new System.Drawing.Point(12, 9);
            this.lbl_NomedoCliente.Name = "lbl_NomedoCliente";
            this.lbl_NomedoCliente.Size = new System.Drawing.Size(0, 25);
            this.lbl_NomedoCliente.TabIndex = 42;
            // 
            // txb_ACBalance
            // 
            this.txb_ACBalance.Location = new System.Drawing.Point(231, 64);
            this.txb_ACBalance.Name = "txb_ACBalance";
            this.txb_ACBalance.Size = new System.Drawing.Size(118, 20);
            this.txb_ACBalance.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 49;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_DTAS
            // 
            this.pnl_DTAS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_DTAS.Location = new System.Drawing.Point(0, 250);
            this.pnl_DTAS.Name = "pnl_DTAS";
            this.pnl_DTAS.Size = new System.Drawing.Size(400, 150);
            this.pnl_DTAS.TabIndex = 50;
            this.pnl_DTAS.TabStop = false;
            // 
            // btn_CSaldo
            // 
            this.btn_CSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_CSaldo.FlatAppearance.BorderSize = 0;
            this.btn_CSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_CSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_CSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CSaldo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CSaldo.ForeColor = System.Drawing.Color.White;
            this.btn_CSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CSaldo.Location = new System.Drawing.Point(17, 55);
            this.btn_CSaldo.Name = "btn_CSaldo";
            this.btn_CSaldo.Size = new System.Drawing.Size(139, 33);
            this.btn_CSaldo.TabIndex = 51;
            this.btn_CSaldo.Text = "Saldo";
            this.btn_CSaldo.UseVisualStyleBackColor = false;
            this.btn_CSaldo.Click += new System.EventHandler(this.btn_CSaldo_Click);
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_Sacar.FlatAppearance.BorderSize = 0;
            this.btn_Sacar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_Sacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sacar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sacar.ForeColor = System.Drawing.Color.White;
            this.btn_Sacar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sacar.Location = new System.Drawing.Point(17, 133);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(139, 33);
            this.btn_Sacar.TabIndex = 52;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = false;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btn_Sacar);
            this.Controls.Add(this.btn_CSaldo);
            this.Controls.Add(this.pnl_DTAS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ECCancelar);
            this.Controls.Add(this.btn_ECConfirmar);
            this.Controls.Add(this.lbl_NomedoCliente);
            this.Controls.Add(this.txb_ACBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conta";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_DTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ECCancelar;
        private System.Windows.Forms.Button btn_ECConfirmar;
        private System.Windows.Forms.Label lbl_NomedoCliente;
        private System.Windows.Forms.TextBox txb_ACBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pnl_DTAS;
        private System.Windows.Forms.Button btn_CSaldo;
        private System.Windows.Forms.Button btn_Sacar;
    }
}