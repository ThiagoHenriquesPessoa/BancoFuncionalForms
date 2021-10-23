
namespace WindowsFormsApp3.Views
{
    partial class ListaDeContas
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
            this.dgv_ListaDeDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaDeDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fecha.AutoSize = true;
            this.btn_Fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.btn_Fecha.Location = new System.Drawing.Point(373, 9);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(15, 13);
            this.btn_Fecha.TabIndex = 35;
            this.btn_Fecha.Text = "X";
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(201)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lista de contas cadastradas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_ListaDeDados
            // 
            this.dgv_ListaDeDados.AllowUserToAddRows = false;
            this.dgv_ListaDeDados.AllowUserToDeleteRows = false;
            this.dgv_ListaDeDados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ListaDeDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaDeDados.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_ListaDeDados.Location = new System.Drawing.Point(12, 51);
            this.dgv_ListaDeDados.Name = "dgv_ListaDeDados";
            this.dgv_ListaDeDados.ReadOnly = true;
            this.dgv_ListaDeDados.Size = new System.Drawing.Size(376, 537);
            this.dgv_ListaDeDados.TabIndex = 36;
            this.dgv_ListaDeDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaDeDados_CellContentClick);
            // 
            // ListaDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.dgv_ListaDeDados);
            this.Controls.Add(this.btn_Fecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDeContas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaDeDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ListaDeDados;
    }
}