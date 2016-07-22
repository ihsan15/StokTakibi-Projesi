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
    class UrunHareketler
    {
        private int _hareketId;
        private DateTime _tarih;
        private string _ıslemTuru;
        private int _firmaNo;
        private int _urunId;
        private string _belge;
        private string _birim;
        private int _adet;
        private decimal _birimFiyat;
        private decimal _tutar;

        #region Properties
        public int HareketId
        {
            get
            {
                return _hareketId;
            }

            set
            {
                _hareketId = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public string IslemTuru
        {
            get
            {
                return _ıslemTuru;
            }

            set
            {
                _ıslemTuru = value;
            }
        }

        public int FirmaNo
        {
            get
            {
                return _firmaNo;
            }

            set
            {
                _firmaNo = value;
            }
        }

        public int UrunId
        {
            get
            {
                return _urunId;
            }

            set
            {
                _urunId = value;
            }
        }

        public string Belge
        {
            get
            {
                return _belge;
            }

            set
            {
                _belge = value;
            }
        }

        public string Birim
        {
            get
            {
                return _birim;
            }

            set
            {
                _birim = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        }

        public decimal Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
            }
        }

        public decimal BirimFiyat
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

        public bool UrunHareketlerGetirByUrunKodaGore(ListView liste, string UrunKodu)
        {
            liste.Items.Clear();
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select Tarih, IslemTuru, Unvan, Belge, UrunHareketler.BirimFiyat, UrunHareketler.Adet, Tutar, UrunHareketler.UrunID, UrunHareketler.HareketID, UrunHareketler.FirmaNo, UrunHareketler.Birim from UrunHareketler inner join Urunler on Urunler.UrunID=UrunHareketler.UrunID inner join Cariler on UrunHareketler.FirmaNo=Cariler.CariNo where UrunHareketler.Silindi=0 and Urunler.UrunKodu=@UrunKodu", conn);
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
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
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

        public int UrunHareketEkle(UrunHareketler uh)
        {
            //bool sonuc = false;
            int sonkayitno = 0;
            SqlCommand comm = new SqlCommand("insert into UrunHareketler (Tarih, IslemTuru, FirmaNo, UrunID, Belge, Birim, Adet, BirimFiyat) values(@Tarih, @IslemTuru, @FirmaNo, @UrunID, @Belge, @Birim, @Adet,@BirimFiyat); select Scope_Identity()", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = uh._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = uh._ıslemTuru;
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = uh._firmaNo;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = uh._urunId;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = uh._belge;
            comm.Parameters.Add("@Birim", SqlDbType.VarChar).Value = uh._birim;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = uh._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = uh._birimFiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonkayitno = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonkayitno;
        }

        public bool UrunHareketiSil(int UrunHareketId)
        {
            SqlCommand comm = new SqlCommand("update UrunHareketler set Silindi=1 where HareketID=@HareketID", conn);
            comm.Parameters.Add("@HareketID", SqlDbType.Int).Value = UrunHareketId;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }
    }
}
