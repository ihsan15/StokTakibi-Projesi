using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFStokTakibi.Model
{
    class Urun
    {
        private int _urunID;
        private string _urunKodu;
        private string _urunAd;
        private int _kategoriNo;
        private int _miktar;
        private int _kritikSeviye;
        private double _birimFiyat;

        #region Properties
        public int UrunID
        {
            get
            {
                return _urunID;
            }

            set
            {
                _urunID = value;
            }
        }

        public string UrunKodu
        {
            get
            {
                return _urunKodu;
            }

            set
            {
                _urunKodu = value;
            }
        }

        public string UrunAd
        {
            get
            {
                return _urunAd;
            }

            set
            {
                _urunAd = value;
            }
        }

        public int KategoriNo
        {
            get
            {
                return _kategoriNo;
            }

            set
            {
                _kategoriNo = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _miktar;
            }

            set
            {
                _miktar = value;
            }
        }

        public int KritikSeviye
        {
            get
            {
                return _kritikSeviye;
            }

            set
            {
                _kritikSeviye = value;
            }
        }

        public double BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }

            set
            {
                _birimFiyat = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();


        public DataSet UrunleriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select UrunKodu, UrunAd, KategoriAd,Miktar,BirimFiyat,KritikSeviye, Urunler.KategoriNo,UrunID from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0", conn);
            try
            {
                da.Fill(ds,"Urunler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }


            return ds;
        }

        public DataSet UrunleriGetirbyTumu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select UrunKodu, UrunAd, KategoriAd, KritikSeviye, Miktar, BirimFiyat, Miktar*BirimFiyat as Tutar from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0", conn);
            try
            {
                da.Fill(ds, "Urunler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }

        public DataSet UrunleriGetirByKategori(string kategoriad)
        {
            SqlDataAdapter da = new SqlDataAdapter("select UrunKodu, UrunAd, KategoriAd, KritikSeviye, Miktar, BirimFiyat, Miktar*BirimFiyat as Tutar from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0 and Kategoriler.KategoriAd=@KategoriAd ", conn);
            da.SelectCommand.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = kategoriad;
            try
            {
                da.Fill(ds, "Urunler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }


            return ds;
        }

        public DataSet UrunleriGetirbyKritikSeviye()
        {
            SqlDataAdapter da = new SqlDataAdapter("select UrunKodu, UrunAd, KategoriAd, KritikSeviye, Miktar, BirimFiyat, KritikSeviye-Miktar as SiparisMiktar,(KritikSeviye-Miktar)*BirimFiyat as SiparisTutar  from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0 and KritikSeviye > Miktar", conn);
            try
            {
                da.Fill(ds, "Urunler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }


            return ds;
        }

        public bool UrunleriGetir(ListView liste)
        {
            liste.Items.Clear();
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select UrunKodu, UrunAd, KategoriAd,Miktar,BirimFiyat,KritikSeviye, Urunler.KategoriNo,UrunID from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if(dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        i++;
                    }
                    dr.Close();
                }                
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public void UrunleriGetirByUrunAdinaGore( string UrunAd,ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select UrunKodu, UrunAd, KategoriAd, Miktar, BirimFiyat, KritikSeviye, Urunler.KategoriNo, UrunID from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0 and UrunAd like @UrunAd + '%'", conn);
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }            
        }

        public int KacinciKayit(int UrunID)
        {
            int kacinci = 0;
            SqlCommand comm = new SqlCommand("Select Count(*) from Urunler where Silindi=0 and UrunID < @UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                kacinci = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return kacinci;
        }

        public bool UrunEkle(Urun u)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Urunler (UrunKodu, UrunAd, KategoriNo, KritikSeviye, BirimFiyat) values(@UrunKodu, @UrunAd, @KategoriNo, @KritikSeviye, @BirimFiyat)", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = u._kategoriNo;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = u._birimFiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public void UrunleriGetirByUrunKodunaGore(string UrunKodu, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunKodu, UrunAd, KategoriAd,Miktar,BirimFiyat,KritikSeviye, Urunler.KategoriNo,UrunID from Urunler inner join Kategoriler on Urunler.KategoriNo=Kategoriler.KategoriNo where Urunler.Silindi=0 and Urunler.UrunKodu like @UrunKodu+'%'", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public bool UrunSil(int ID)
        {
            SqlCommand comm = new SqlCommand("update Urunler set Silindi=1 where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }

        public bool UrunKontrol(string UrunKodu, string UrunAdi)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select count(*) from Urunler where Silindi=0 and UrunKodu=@UrunKodu and UrunAd=@UrunAd", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAdi;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayisi = 0;
            try
            {
                sayisi = Convert.ToInt32(comm.ExecuteScalar());
                if (sayisi > 0) sonuc = true;
            }
            catch (SqlException ex)
            {
                string haata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool UrunKontrol(string UrunKodu, string UrunAdi, int ID)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select Count(*) from Urunler where Silindi=0 and UrunKodu=@UrunKodu and UrunAd=@UrunAd and UrunID != @UrunID", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAdi;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }

        public bool UrunGuncelle(Urun u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Urunler Set UrunKodu=@UrunKodu, UrunAd=@UrunAd, KategoriNo=@KategoriNo, KritikSeviye=@KritikSeviye, BirimFiyat=@BirimFiyat where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@KategoriNo", SqlDbType.Int).Value = u._kategoriNo;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = u._birimFiyat;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = u._urunID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool UrunStokGuncelleFromUrunHareketEkle(int urunıd, int adet,string islemturu)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Urunler Set Miktar=Miktar+@Miktar where UrunID=@UrunID", conn);
            if (islemturu == "Stok Çıkış") adet = (-1) * adet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = adet;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunıd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc=Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool UrunStokGuncelleFromUrunHareketSil(int urunıd, int adet, string islemturu)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Urunler Set Miktar=Miktar+@Miktar where UrunID=@UrunID", conn);
            if (islemturu == "Stok Giriş") adet = (-1) * adet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = adet;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = urunıd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }


    }
}
