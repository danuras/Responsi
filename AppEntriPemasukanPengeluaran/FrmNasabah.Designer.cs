namespace AppEntriPemasukanPengeluaran
{
    partial class FrmNasabah
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
            this.txtNasabah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoRekening = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwHistoriPemasukanPengeluaran = new System.Windows.Forms.ListView();
            this.btnInputPemasukanPengeluaran = new System.Windows.Forms.Button();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.lblTotalKredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNasabah
            // 
            this.txtNasabah.Location = new System.Drawing.Point(93, 41);
            this.txtNasabah.Name = "txtNasabah";
            this.txtNasabah.Size = new System.Drawing.Size(234, 20);
            this.txtNasabah.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nasabah";
            // 
            // txtNoRekening
            // 
            this.txtNoRekening.Location = new System.Drawing.Point(93, 12);
            this.txtNoRekening.Name = "txtNoRekening";
            this.txtNoRekening.Size = new System.Drawing.Size(100, 20);
            this.txtNoRekening.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. Rekening";
            // 
            // lvwHistoriPemasukanPengeluaran
            // 
            this.lvwHistoriPemasukanPengeluaran.HideSelection = false;
            this.lvwHistoriPemasukanPengeluaran.Location = new System.Drawing.Point(17, 86);
            this.lvwHistoriPemasukanPengeluaran.Name = "lvwHistoriPemasukanPengeluaran";
            this.lvwHistoriPemasukanPengeluaran.Size = new System.Drawing.Size(348, 213);
            this.lvwHistoriPemasukanPengeluaran.TabIndex = 2;
            this.lvwHistoriPemasukanPengeluaran.UseCompatibleStateImageBehavior = false;
            // 
            // btnInputPemasukanPengeluaran
            // 
            this.btnInputPemasukanPengeluaran.Location = new System.Drawing.Point(160, 340);
            this.btnInputPemasukanPengeluaran.Name = "btnInputPemasukanPengeluaran";
            this.btnInputPemasukanPengeluaran.Size = new System.Drawing.Size(200, 23);
            this.btnInputPemasukanPengeluaran.TabIndex = 5;
            this.btnInputPemasukanPengeluaran.Text = "Input Pemasukan/Pengeluaran";
            this.btnInputPemasukanPengeluaran.UseVisualStyleBackColor = true;
            this.btnInputPemasukanPengeluaran.Click += new System.EventHandler(this.btnInputPemasukanPengeluaran_Click);
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalDebit.Location = new System.Drawing.Point(157, 302);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(100, 20);
            this.lblTotalDebit.TabIndex = 3;
            this.lblTotalDebit.Text = "0";
            this.lblTotalDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalKredit
            // 
            this.lblTotalKredit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalKredit.Location = new System.Drawing.Point(260, 302);
            this.lblTotalKredit.Name = "lblTotalKredit";
            this.lblTotalKredit.Size = new System.Drawing.Size(100, 20);
            this.lblTotalKredit.TabIndex = 4;
            this.lblTotalKredit.Text = "0";
            this.lblTotalKredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 375);
            this.Controls.Add(this.btnInputPemasukanPengeluaran);
            this.Controls.Add(this.lvwHistoriPemasukanPengeluaran);
            this.Controls.Add(this.txtNasabah);
            this.Controls.Add(this.lblTotalKredit);
            this.Controls.Add(this.lblTotalDebit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoRekening);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmNasabah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nasabah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNasabah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoRekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwHistoriPemasukanPengeluaran;
        private System.Windows.Forms.Button btnInputPemasukanPengeluaran;
        private System.Windows.Forms.Label lblTotalDebit;
        private System.Windows.Forms.Label lblTotalKredit;
    }
}

