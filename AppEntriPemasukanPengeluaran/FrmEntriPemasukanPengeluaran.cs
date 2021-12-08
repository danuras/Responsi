using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppEntriPemasukanPengeluaran
{
    public partial class FrmEntriPemasukanPengeluaran : Form
    {
        public delegate void InputPemasukanPengeluaranEventHandler(string date, string jumlah, bool isDebit);
        public event InputPemasukanPengeluaranEventHandler OnInput;
        // constructor default
        public FrmEntriPemasukanPengeluaran()
        {
            InitializeComponent();
            cmbDebitKredit.SelectedIndex = 0;
        }

        public FrmEntriPemasukanPengeluaran(string header, string noRekening, string nasabah)
            : this() // panggil constructor default
        {
            this.Text = header;
            lblHeader.Text = header;

            txtNoRekening.Text = noRekening;
            txtNasabah.Text = nasabah;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            OnInput(dtpTanggal.Text, txtNominal.Text, cmbDebitKredit.SelectedIndex == 0);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
