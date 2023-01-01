using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketUrunListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id = 0;
        Urun selectedUrun;

        ArrayList urunlerListesi = new ArrayList();
        ArrayList urunSiniflariListesi = new ArrayList()
        {
           "Gıda", "Manav","Fırın", "Şarküteri","Kasap", "Kuruyemiş", "Temizlik vb.", "Kişisel Bakım", "Elektronik Eşya",
        };
       

        private void Form1_Load(object sender, EventArgs e)
        {
            FormFill();
        }

        private void FormFill()
        {
            FillClass();
        }

        private void FillClass()
        {
            cmbUrunSiniflari.Items.Clear();
            foreach (string item in urunSiniflariListesi)
            {
                cmbUrunSiniflari.Items.Add(item);
            }
            cmbUrunSiniflari.SelectedIndex = 0;
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (formValidation())
            {
                FormSave();
            }
        }

        private bool formValidation()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtBirimFiyat.Text) || string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                MessageBox.Show("Tüm bilgiler doldurulmalıdır", "Ürünler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUrunAdi.Focus();
                result = false;
            }
            return result;
        }

        private void FormSave()
        {
            Urun urun = null;
            if (selectedUrun != null)
            {
                urun = selectedUrun;
            }
            else
            {
                urun = new Urun();
                urun.Id = GetId();
                urunlerListesi.Add(urun);
            }

            urun.BarkodNo = txtBarkodNo.Text;
            urun.BirimFiyat = txtBirimFiyat.Text;
            urun.UrunAdi = txtUrunAdi.Text;
            urun.SKT = dtpSKT.Value;
            urun.UrunSinifi = cmbUrunSiniflari.SelectedItem.ToString();

            RefreshListBox();
            FormClear();
        }

        private void RefreshListBox()
        {
            lstUrunlerListesi.Items.Clear();
            foreach (Urun urun in urunlerListesi)
            {
                lstUrunlerListesi.Items.Add(urun);
            }
        }











        // G E N E L  
        private void btnEkraniTemizle_Click(object sender, EventArgs e)
        {
            FormClear();
        }
        private void FormClear()
        {
            txtBarkodNo.Text = "";
            txtBirimFiyat.Text = "";
            txtUrunAdi.Text = "";
            dtpSKT.Value = DateTime.Now;
            cmbUrunSiniflari.SelectedIndex = 0;
            selectedUrun = null;  // ekranı boşaltırken eğer seçili bir nesne var ise onuda null set et
        }
        private int GetId()
        {
            return ++id;
        }

        private void lstUrunlerListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunlerListesi.SelectedIndex == -1) return;
            selectedUrun = lstUrunlerListesi.SelectedItem as Urun;
            FillRecordForm();
        }

        private void FillRecordForm()
        {
            txtUrunAdi.Text = selectedUrun.UrunAdi;
            txtBirimFiyat.Text = selectedUrun.BirimFiyat;
            txtBarkodNo.Text = selectedUrun.BarkodNo;
            dtpSKT.Value = selectedUrun.SKT;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            RecordRemove();
        }

        private void RecordRemove()
        {
            var dialogResult = MessageBox.Show("Seçilen kaydı silmek istiyormusunuz?", "Ürün ekleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                urunlerListesi.Remove(selectedUrun);
                RefreshListBox();
                FormClear();
            }
        }
    }
}
