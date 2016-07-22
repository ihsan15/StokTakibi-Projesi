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
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        BindingSource bs;

        private void tpUrunKartlari_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;           

            Urun u = new Urun();
            u.UrunleriGetir(lvUrunler);
            ds = u.UrunleriGetir();
            dgvStokSorgulama.DataSource = ds.Tables["Urunler"];

            Kategori k = new Kategori();
            k.KategorileriGetir(cbKategoriler);
            k.KategorileriGetir(cbKategoriler2);
            
            DataBagla();
            Konum();

            tabControl1.SelectedIndex = Genel.sayfano;
        }

        private void Konum()
        {
            lblKonum.Text = (bs.Position + 1) + "/" + bs.Count;

            UrunHareketler uh = new UrunHareketler();
            uh.UrunHareketlerGetirByUrunKodaGore(lvHareketler, txtUrunKodu2.Text);
        }

        private void DataBagla()
        {
            Urun u = new Urun();
            ds = u.UrunleriGetir();
            bs = new BindingSource();
            bs.DataSource = ds.Tables["Urunler"];

            txtUrunKodu.DataBindings.Clear();
            txtUrunAdi.DataBindings.Clear();
            txtKategoriNo.DataBindings.Clear();
            txtKategori.DataBindings.Clear();
            txtUrunNo.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            txtBirimFiyat.DataBindings.Clear();
            txtKritikSeviye.DataBindings.Clear();

            txtUrunKodu.DataBindings.Add("Text", bs, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", bs, "UrunAd");
            txtKategoriNo.DataBindings.Add("Text", bs, "KategoriNo");
            txtKategori.DataBindings.Add("Text", bs, "KategoriAd");
            txtUrunNo.DataBindings.Add("Text", bs, "UrunID");
            txtStok.DataBindings.Add("Text", bs, "Miktar");
            txtBirimFiyat.DataBindings.Add("Text", bs, "BirimFiyat");
            txtKritikSeviye.DataBindings.Add("Text", bs, "KritikSeviye");

            txtUrunKodu2.DataBindings.Clear();
            txtUrunAdi2.DataBindings.Clear();
            txtUrunNo2.DataBindings.Clear();
            txtBirimFiyat2.DataBindings.Clear();

            txtUrunKodu2.DataBindings.Add("Text", bs, "UrunKodu");
            txtUrunAdi2.DataBindings.Add("Text", bs, "UrunAd");
            txtUrunNo2.DataBindings.Add("Text", bs, "UrunID");
            txtBirimFiyat2.DataBindings.Add("Text", bs, "BirimFiyat");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
            Konum();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.Position -= 1;
            Konum();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.Position += 1;
            Konum();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
            Konum();
        }

        private void txtUrunKodunaGore_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunleriGetirByUrunKodunaGore(txtUrunKodunaGore.Text, lvUrunler);
        }

        private void txtUrunAdinaGore_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunleriGetirByUrunAdinaGore(txtUrunAdinaGore.Text, lvUrunler);
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori k =(Kategori)cbKategoriler.SelectedItem;
            txtKategori.Text = k.KategoriAd;
            txtKategoriNo.Text = k.KategoriNo.ToString();

            txtKritikSeviye.Focus();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;

            bs.AddNew();
            txtUrunKodu.Focus();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUrunKodu.Text) || string.IsNullOrEmpty(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Kodu ve Adı boş bırakılamaz.");
                txtUrunKodu.Focus();
            }
            else
            {
                Urun u = new Urun();
                if (u.UrunKontrol(txtUrunKodu.Text,txtUrunAdi.Text))
                {
                    MessageBox.Show("Bu ürün zaten stokta kayıtlı");
                    txtUrunKodu.Focus();
                }
                else
                {
                    bs.EndEdit();

                    u.UrunKodu = txtUrunKodu.Text;
                    u.UrunAd = txtUrunAdi.Text;
                    u.KategoriNo = Convert.ToInt32(txtKategoriNo.Text);
                    if (string.IsNullOrEmpty(txtKritikSeviye.Text)) txtKritikSeviye.Text = "0";
                    u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                    if (string.IsNullOrEmpty(txtBirimFiyat.Text)) txtBirimFiyat.Text = "0";
                    u.BirimFiyat = Convert.ToInt32(txtBirimFiyat.Text);
                    if(u.UrunEkle(u))
                    {
                        MessageBox.Show("Ürün Bilgileri Kayıt Edildi.");
                        u.UrunleriGetir(lvUrunler);
                        DataBagla();
                        Konum();
                        tsDegistir.Enabled = true;
                        tsSil.Enabled = true;
                        tsKaydet.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işleminde sorunla karşılaşıldı.");
                    }
                }
            }

        }

        private void tsVazgec_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
            Konum();
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            Urun u = new Urun();
            int kacinci = u.KacinciKayit(Convert.ToInt32(lvUrunler.SelectedItems[0].SubItems[7].Text));
            bs.Position = kacinci;
            Konum();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            if (u.UrunKontrol(txtUrunKodu.Text, txtUrunAdi.Text, Convert.ToInt32(txtUrunNo.Text)))
            {
                MessageBox.Show("Önceden Tanımlı Böyle Bir Ürün Zaten Mevcut!");
                txtUrunKodu.Focus();
            }
            else
            {
                bs.EndEdit();
                u.UrunID = Convert.ToInt32(txtUrunNo.Text);
                u.UrunKodu = txtUrunKodu.Text;
                u.UrunAd = txtUrunAdi.Text;
                u.KategoriNo = Convert.ToInt32(txtKategoriNo.Text);
                if (string.IsNullOrEmpty(txtKritikSeviye.Text)) txtKritikSeviye.Text = "0";
                u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                if (string.IsNullOrEmpty(txtBirimFiyat.Text)) txtBirimFiyat.Text = "0";
                u.BirimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                if (u.UrunGuncelle(u))
                {
                    MessageBox.Show("Ürün Bilgileri değiştirildi.");
                    u.UrunleriGetir(lvUrunler);
                    DataBagla();
                    Konum();
                }
                else { MessageBox.Show("Kayıt işleminde sorunla karşılaşıldı!"); }
            }
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Urun u = new Urun();
                if (u.UrunSil(Convert.ToInt32(txtUrunNo.Text)))
                {
                    MessageBox.Show("Ürün Bilgileri Silindi.");
                    u.UrunleriGetir(lvUrunler);
                    DataBagla();
                    Konum();
                }
                else
                    MessageBox.Show("Silme işleminde sorunla karşılaşıldı!!");
            }
        }

        private void lvUrunler_Click(object sender, EventArgs e)
        {
            lvUrunler_DoubleClick(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtIslemTarihi.Text = dtpIslemTarihi.Value.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTuru.SelectedItem.ToString();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirimFiyat2.Text)) { txtBirimFiyat2.Text = "0"; txtBirimFiyat2.Select(0, 2); }
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            txtTutar.Text = (Convert.ToDecimal(txtBirimFiyat2.Text) * Convert.ToInt32(txtAdet.Text)).ToString();
        }

        private void txtBirimFiyat2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirimFiyat2.Text)) { txtBirimFiyat2.Text = "0"; txtBirimFiyat2.Select(0, 2); }
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            txtTutar.Text = (Convert.ToDecimal(txtBirimFiyat2.Text) * Convert.ToInt32(txtAdet.Text)).ToString();
        }

        private void txtAdet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirimFiyat2.Text)) { txtBirimFiyat2.Text = "0"; txtBirimFiyat2.Select(0, 2); }
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            txtTutar.Text = (Convert.ToDecimal(txtBirimFiyat2.Text) * Convert.ToInt32(txtAdet.Text)).ToString();
        }

        private void txtBirimFiyat2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirimFiyat2.Text)) { txtBirimFiyat2.Text = "0"; txtBirimFiyat2.Select(0, 2); }
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            txtTutar.Text = (Convert.ToDecimal(txtBirimFiyat2.Text) * Convert.ToInt32(txtAdet.Text)).ToString();
        }

        private void btnFirmaBul_Click(object sender, EventArgs e)
        {
            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (txtIslemTuru.Text == "Stok Giriş")
                Genel.CariTipi = "Satıcı";
            else
                Genel.CariTipi = "Alıcı";
            frm.ShowDialog();

            txtFirma.Text = Genel.Unvan;
            txtFirmaNo.Text = Genel.CariNo.ToString();
            txtBelge.Focus();            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;

            txtIslemTarihi.Text = DateTime.Now.ToShortDateString();
            cbIslemTuru.SelectedIndex = 1;
            Temizle();

            btnFirmaBul.PerformClick();            
        }

        private void Temizle()
        {
            txtAdet.Text = "1";
            txtBelge.Clear();
            txtBirim.Text = "Adet";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirmaNo.Text))
            {
                MessageBox.Show("Firma Adı boş bırakılamaz.");
                btnFirmaBul.PerformClick();
            }
            else
            {
                if (cbIslemTuru.SelectedIndex==1  && Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
                {
                    MessageBox.Show("Girilen adet sayısı stok miktarını geçemez!!");
                    txtAdet.Focus();
                }
                else
                {
                    UrunHareketler uh = new UrunHareketler();
                    bs.EndEdit();
                    uh.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                    uh.IslemTuru = txtIslemTuru.Text;
                    uh.FirmaNo = Convert.ToInt32(txtFirmaNo.Text);
                    uh.UrunId = Convert.ToInt32(txtUrunNo2.Text);
                    uh.Belge = txtBelge.Text;
                    uh.Birim = txtBirim.Text;
                    uh.Adet = Convert.ToInt32(txtAdet.Text);
                    uh.BirimFiyat = Convert.ToDecimal(txtBirimFiyat2.Text);
                    int kayitno = uh.UrunHareketEkle(uh);
                    if (kayitno > 0)
                    {
                        Urun u = new Urun();
                        if (u.UrunStokGuncelleFromUrunHareketEkle(uh.UrunId, uh.Adet, uh.IslemTuru))
                        {
                            MessageBox.Show("Stok Güncellendi");
                            CariHareketler ch = new CariHareketler();
                            ch.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                            ch.IslemTuru = txtIslemTuru.Text;
                            ch.CariNo = Convert.ToInt32(txtFirmaNo.Text);
                            ch.Belge = txtBelge.Text;
                            if (cbIslemTuru.SelectedIndex == 1)
                            {
                                ch.Borc = Convert.ToDecimal(txtTutar.Text);
                                ch.Alacak = 0;
                            }

                            else
                            {
                                ch.Alacak = Convert.ToDecimal(txtTutar.Text);
                                ch.Borc = 0;
                            }
                            ch.KasaHareketId = 0;
                            ch.UrunHareketId = kayitno;
                            if (ch.CariHareketEkle(ch))
                            {
                                MessageBox.Show("Cari Hareketler Bilgisi Eklendi.");
                                Cari c = new Cari();
                                if (c.CariToplamlariGuncelleFromUrunKasaHareket(ch.CariNo, ch.Borc, ch.Alacak))
                                {
                                    MessageBox.Show("Bakiyeniz güncellendi.");
                                }
                                else
                                    MessageBox.Show("Bakiyeniz güncellenemedi.");
                            }
                            else
                                MessageBox.Show("Cari Hareketler Bilgisi Eklenemedi.");
                        }
                        else
                            MessageBox.Show("Stok Güncellenemedi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işleminde sorunla karşılaşıldı.");
                    }
                }                
            }

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün Hareketi İptal Etmek İstiyor Musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UrunHareketler uh = new UrunHareketler();
                if (uh.UrunHareketiSil(Convert.ToInt32(txtHareketID.Text)))
                {
                    MessageBox.Show("Ürün Hareket Bilgisi Silindi");
                    uh.UrunHareketlerGetirByUrunKodaGore(lvHareketler, txtUrunKodu.Text);
                    Urun u = new Urun();
                    if (u.UrunStokGuncelleFromUrunHareketSil(Convert.ToInt32(txtUrunNo.Text), Convert.ToInt32(txtAdet.Text), txtIslemTuru.Text))
                    {
                        MessageBox.Show("Stok Güncellendi");
                        CariHareketler ch = new CariHareketler();
                        decimal Borc = 0, Alacak = 0;
                        if (ch.CariHareketSil(Convert.ToInt32(txtHareketID.Text)))
                        {
                            MessageBox.Show("Cari Hareket Bilgisi Silindi.");
                            
                            if (cbIslemTuru.SelectedIndex == 1)
                            {
                                Borc = (-1) * Convert.ToDecimal(txtTutar.Text);
                                Alacak = 0;
                            }

                            else
                            {
                                Alacak = (-1)*Convert.ToDecimal(txtTutar.Text);
                                Borc = 0;
                            }
                            Cari c = new Cari();
                            if (c.CariToplamlariGuncelleFromUrunKasaHareket(Convert.ToInt32(txtFirmaNo.Text), Borc, Alacak))
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
                        MessageBox.Show("Stok Güncellenemedi!");
                }
                else
                    MessageBox.Show("Ürün Hareket Bilgisi Silinemedi.");
            }
        }

        private void lvHareketler_DoubleClick(object sender, EventArgs e)
        {
            btnSil.Enabled = true;
            btnDegistir.Enabled = true;
            btnKaydet.Enabled = false;
            txtIslemTarihi.Text = lvHareketler.SelectedItems[0].SubItems[0].Text;
            txtIslemTuru.Text= lvHareketler.SelectedItems[0].SubItems[1].Text;
            txtFirma.Text= lvHareketler.SelectedItems[0].SubItems[2].Text;
            txtBelge.Text= lvHareketler.SelectedItems[0].SubItems[3].Text;
            txtBirimFiyat2.Text= lvHareketler.SelectedItems[0].SubItems[4].Text;
            txtAdet.Text= lvHareketler.SelectedItems[0].SubItems[5].Text;
            txtTutar.Text= lvHareketler.SelectedItems[0].SubItems[6].Text;
            txtHareketID.Text= lvHareketler.SelectedItems[0].SubItems[8].Text;
            txtFirmaNo.Text= lvHareketler.SelectedItems[0].SubItems[9].Text;
            txtBirim.Text= lvHareketler.SelectedItems[0].SubItems[10].Text;


        }

        private void tpStokSorgulama_Click(object sender, EventArgs e)
        {

        }

        private void rbTumUrunler_CheckedChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            ds = u.UrunleriGetirbyTumu();
            dgvStokSorgulama.DataSource = ds.Tables["Urunler"];
            GridViewDuzenle();
            dgvStokSorgulama.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void rbKritikSeviyeninAltindakiler_CheckedChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            ds = u.UrunleriGetirbyKritikSeviye();
            dgvStokSorgulama.DataSource = ds.Tables["Urunler"];
            GridViewDuzenle();
            dgvStokSorgulama.Columns["SiparisMiktar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStokSorgulama.Columns["SiparisTutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            ToplamBul();
        }

        private void cbKategoriler2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            ds = u.UrunleriGetirByKategori(cbKategoriler2.SelectedItem.ToString());
            dgvStokSorgulama.DataSource = ds.Tables["Urunler"];
            GridViewDuzenle();
            dgvStokSorgulama.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void GridViewDuzenle()
        {
            dgvStokSorgulama.Columns["UrunAd"].Width = 130;
            dgvStokSorgulama.Columns["Miktar"].Width = 70;
            dgvStokSorgulama.Columns["Miktar"].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvStokSorgulama.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStokSorgulama.Columns["KritikSeviye"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ToplamBul()
        {
            decimal toplamTutar = 0;
            int toplamMiktar = 0;

            foreach (DataRow dr in ds.Tables["Urunler"].Rows)
            {
                toplamMiktar += Convert.ToInt32(dr["SiparisMiktar"]);
                toplamTutar += Convert.ToInt32(dr["SiparisTutar"]);
            }

            txtToplamMiktar.Text = toplamMiktar.ToString();
            txtToplamTutar.Text = toplamTutar.ToString();

            txtToplamTutar.Text = String.Format("{0:C}", toplamTutar);
        }

    }
}
