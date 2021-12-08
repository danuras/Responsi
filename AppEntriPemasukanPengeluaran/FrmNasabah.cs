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
    public partial class FrmNasabah : Form
    {
        private int totalDebit = 0;
        private int totalKredit = 0;

        public FrmNasabah()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {            
            lvwHistoriPemasukanPengeluaran.View = View.Details;
            lvwHistoriPemasukanPengeluaran.FullRowSelect = true;
            lvwHistoriPemasukanPengeluaran.GridLines = true;

            lvwHistoriPemasukanPengeluaran.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Tanggal", 100, HorizontalAlignment.Center);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Debit", 100, HorizontalAlignment.Right);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Kredit", 100, HorizontalAlignment.Right);
        }

        private void btnInputPemasukanPengeluaran_Click(object sender, EventArgs e)
        {
            FrmEntriPemasukanPengeluaran frmEntriPemasukanPengeluaran = new FrmEntriPemasukanPengeluaran("Entri Pemasukan/Pengeluaran", txtNoRekening.Text, txtNasabah.Text);
            frmEntriPemasukanPengeluaran.OnInput += PemasukanPengeluaranEventHandler;
            frmEntriPemasukanPengeluaran.ShowDialog();
        }

        private void PemasukanPengeluaranEventHandler(string tanggal, string nominal, bool isDebit)
        {
            int noUrut = lvwHistoriPemasukanPengeluaran.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(tanggal);
            if (isDebit)
            {
                item.SubItems.Add(nominal);
                item.SubItems.Add("0");
                totalDebit += int.Parse(nominal);
            }
            else
            {
                item.SubItems.Add("0");
                item.SubItems.Add(nominal);
                totalKredit += int.Parse(nominal);
            }
            lvwHistoriPemasukanPengeluaran.Items.Add(item);
            lblTotalDebit.Text = totalDebit.ToString();
            lblTotalKredit.Text = totalKredit.ToString();
        }
    }
}
