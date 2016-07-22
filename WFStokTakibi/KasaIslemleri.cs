using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFStokTakibi.Model;

namespace WFStokTakibi
{
    public partial class KasaIslemleri : Form
    {
        public KasaIslemleri()
        {
            InitializeComponent();
        }

        private void KasaIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            Kasa k = new Kasa();
            k.KasaDevirleriGetir(txtTarih.Text, txtDevirGiren, txtDevirCikan, txtDevirBakiye);
            k.KasaHareketleriGetirByTarih(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;

            Temizle();
        }

        private void Temizle()
        {
            txtID.Clear();
            txtIslemTarihi.Text = txtTarih.Text;
            txtIslemTuru.Clear();
            txtCariUnvan.Clear();
            txtCariNo.Clear();
            txtBelge.Clear();
            txtGiren.Text = "0";
            txtCikan.Text = "0";
            txtPara.Text = "Tl";
            txtIslemTuru.Focus();
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTurleri.SelectedItem.ToString();
            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (txtIslemTuru.Text == "Tahsilat")
            {
                Genel.CariTipi = "Alıcı";
                txtGiren.ReadOnly = false;
                txtCikan.ReadOnly = true;
            }
            else if (txtIslemTuru.Text == "Ödeme")
            {
                Genel.CariTipi = "Satıcı";
                txtGiren.ReadOnly = true;
                txtCikan.ReadOnly = false;
            }
            frm.ShowDialog();

            txtCariUnvan.Text = Genel.Unvan;
            txtCariNo.Text = Genel.CariNo.ToString();

            txtBelge.Focus();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIslemTuru.Text) || string.IsNullOrEmpty(txtCariNo.Text))
            {
                MessageBox.Show("İşlem Türü ve Cari boş bırakılamaz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbIslemTurleri.Focus();
            }
            else
            {
                if (txtGiren.Text == "0" && txtCikan.Text == "0")
                {
                    MessageBox.Show("Mutlaka Tutar girmelisiniz.");
                    if (txtIslemTuru.Text == "Tahsilat")
                    {
                        txtCikan.Focus();
                    }
                    else if (txtIslemTuru.Text == "Ödeme")
                    {
                        txtGiren.Focus();
                    }
                }
                else
                {
                    Kasa k = new Kasa();
                    k.IslemTuru = txtIslemTuru.Text;
                    k.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                    k.CariNo = Convert.ToInt32(txtCariNo.Text);
                    k.Belge = txtBelge.Text;
                    k.Cikan = Convert.ToDouble(txtCikan.Text);
                    k.Giren = Convert.ToDouble(txtGiren.Text);
                    int sonuc = k.KasaHareketEkle(k);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Ürün Bilgileri Kayıt Edildi.");
                        k.KasaHareketleriGetirByTarih(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);

                        CariHareketler ch = new CariHareketler();
                        ch.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                        ch.IslemTuru = txtIslemTuru.Text;
                        ch.CariNo = Convert.ToInt32(txtCariNo.Text);
                        ch.Belge = txtBelge.Text;
                        ch.Borc = Convert.ToDecimal(txtCikan.Text);
                        ch.Alacak = Convert.ToDecimal(txtGiren.Text);
                        ch.KasaHareketId = sonuc;
                        ch.UrunHareketId = 0;
                        if (ch.CariHareketEkle(ch))
                        {
                            MessageBox.Show("Cari Hareketler Bilgisi Eklendi.");
                            Cari c = new Cari();
                            if (c.CariToplamlariGuncelleFromUrunKasaHareket(ch.CariNo, ch.Borc, ch.Alacak))
                            {
                                MessageBox.Show("Bakiyeniz güncellendi.");
                                Temizle();
                                btnKaydet.Enabled = false;
                            }
                            else
                                MessageBox.Show("Bakiyeniz güncellenemedi.");
                        }
                        else
                            MessageBox.Show("Cari Hareketler Bilgisi Eklenemedi.");                       
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işleminde sorunla karşılaşıldı.");
                    }

                }
                
            }
        }

        private void lvHareketler_DoubleClick(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
            btnDegistir.Enabled = true;
            btnKaydet.Enabled = false;
            txtID.Text = lvHareketler.SelectedItems[0].SubItems[0].Text;
            txtIslemTarihi.Text = lvHareketler.SelectedItems[0].SubItems[1].Text;
            txtIslemTuru.Text = lvHareketler.SelectedItems[0].SubItems[2].Text;
            txtCariUnvan.Text = lvHareketler.SelectedItems[0].SubItems[3].Text;
            txtBelge.Text = lvHareketler.SelectedItems[0].SubItems[4].Text;
            txtGiren.Text = lvHareketler.SelectedItems[0].SubItems[5].Text;
            txtCikan.Text = lvHareketler.SelectedItems[0].SubItems[6].Text;
            txtPara.Text = lvHareketler.SelectedItems[0].SubItems[7].Text;
            txtCariNo.Text = lvHareketler.SelectedItems[0].SubItems[8].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün Hareketi İptal Etmek İstiyor Musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kasa k = new Kasa();
                if (k.KasaHareketiSil(Convert.ToInt32(txtID.Text)))
                {
                    MessageBox.Show("Ürün Hareket Bilgisi Silindi");
                    k.KasaHareketleriGetirByTarih(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
                    CariHareketler ch = new CariHareketler();
                    decimal Borc = 0, Alacak = 0;
                    if (ch.CariHareketSilByKasa(Convert.ToInt32(txtID.Text)))
                    {
                        MessageBox.Show("Cari Hareket Bilgisi Silindi.");
                        Borc = (-1) * Convert.ToDecimal(txtCikan.Text);
                        Alacak = (-1) * Convert.ToDecimal(txtGiren.Text);
                        Cari c = new Cari();
                        if (c.CariToplamlariGuncelleFromUrunKasaHareket(Convert.ToInt32(txtCariNo.Text), Borc, Alacak))
                        {
                            MessageBox.Show("Bakiyeniz güncellendi.");
                        }
                        else
                            MessageBox.Show("Bakiyeniz güncellenemedi.");
                    }
                    else
                        MessageBox.Show("Cari Hareketler Bilgisi Silinemedi.");

                }
                else
                    MessageBox.Show("Ürün Hareket Bilgisi Silinemedi.");
            }
        }


    }
}
