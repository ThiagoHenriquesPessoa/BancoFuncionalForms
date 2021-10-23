
namespace BancoFuncional.Views.ViewsSecondary.ViewaTertiary
{
    partial class Sacar
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
            this.btn_ACConfirmar = new System.Windows.Forms.Button();
            this.btn_ACCancelar = new System.Windows.Forms.Button();
            this.txb_ACWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ACConfirmar
            // 
            this.btn_ACConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_ACConfirmar.FlatAppearance.BorderSize = 0;
            this.btn_ACConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ACConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ACConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ACConfirmar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ACConfirmar.ForeColor = System.Drawing.Color.White;
            this.btn_ACConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ACConfirmar.Location = new System.Drawing.Point(240, 84);
            this.btn_ACConfirmar.Name = "btn_ACConfirmar";
            this.btn_ACConfirmar.Size = new System.Drawing.Size(120, 33);
            this.btn_ACConfirmar.TabIndex = 55;
            this.btn_ACConfirmar.Text = "Confirmar";
            this.btn_ACConfirmar.UseVisualStyleBackColor = false;
            this.btn_ACConfirmar.Click += new System.EventHandler(this.btn_ACConfirmar_Click);
            // 
            // btn_ACCancelar
            // 
            this.btn_ACCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_ACCancelar.FlatAppearance.BorderSize = 0;
            this.btn_ACCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btn_ACCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ACCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ACCancelar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ACCancelar.ForeColor = System.Drawing.Color.White;
            this.btn_ACCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ACCancelar.Location = new System.Drawing.Point(70, 84);
            this.btn_ACCancelar.Name = "btn_ACCancelar";
            this.btn_ACCancelar.Size = new System.Drawing.Size(120, 33);
            this.btn_ACCancelar.TabIndex = 56;
            this.btn_ACCancelar.Text = "Cancelar";
            this.btn_ACCancelar.UseVisualStyleBackColor = false;
            this.btn_ACCancelar.Click += new System.EventHandler(this.btn_ACCancelar_Click);
            // 
            // txb_ACWithdrawalAmount
            // 
            this.txb_ACWithdrawalAmount.Location = new System.Drawing.Point(170, 34);
            this.txb_ACWithdrawalAmount.Name = "txb_ACWithdrawalAmount";
            this.txb_ACWithdrawalAmount.Size = new System.Drawing.Size(164, 20);
            this.txb_ACWithdrawalAmount.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(40, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Valor do Saque";
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btn_ACConfirmar);
            this.Controls.Add(this.btn_ACCancelar);
            this.Controls.Add(this.txb_ACWithdrawalAmount);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sacar";
            this.Text = "Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ACConfirmar;
        private System.Windows.Forms.Button btn_ACCancelar;
        private System.Windows.Forms.TextBox txb_ACWithdrawalAmount;
        private System.Windows.Forms.Label label3;
    }
}