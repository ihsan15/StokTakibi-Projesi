using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFStokTakibi.Model
{
    class CariHareketler
    {
        private int _hareketId;
        private DateTime _tarih;
        private string _ıslemTuru;
        private int _cariNo;
        private string _belge;
        private decimal _borc;
        private decimal _alacak;
        private int _kasaHareketId;
        private int _urunHareketId;

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

        public int CariNo
        {
            get
            {
                return _cariNo;
            }

            set
            {
                _cariNo = value;
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

        public decimal Borc
        {
            get
            {
                return _borc;
            }

            set
            {
                _borc = value;
            }
        }


        public decimal Alacak
        {
            get
            {
                return _alacak;
            }

            set
            {
                _alacak = value;
            }
        }

        public int KasaHareketId
        {
            get
            {
                return _kasaHareketId;
            }

            set
            {
                _kasaHareketId = value;
            }
        }

        public int UrunHareketId
        {
            get
            {
                return _urunHareketId;
            }

            set
            {
                _urunHareketId = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();

        public bool CariHareketEkle(CariHareketler ch)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into CariHareketler (Tarih, IslemTuru, CariNo, Belge, Borc,    Alacak, KasaHareketID, UrunHareketID) values(@Tarih, @IslemTuru, @FirmaNo, @Belge, @Borc, @Alacak, @KasaHareketID, @UrunHareketID)", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = ch._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = ch._ıslemTuru;
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = ch._cariNo;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = ch._belge;
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = ch._borc;
            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = ch._alacak;
            comm.Parameters.Add("@KasaHareketID", SqlDbType.Int).Value = ch._kasaHareketId;
            comm.Parameters.Add("@UrunHareketID", SqlDbType.Int).Value = ch._urunHareketId;
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

        public bool CariHareketSil(int hareketıd)
        {
            SqlCommand comm = new SqlCommand("update CariHareketler set Silindi=1 where UrunHareketID=@UrunHareketID", conn);
            comm.Parameters.Add("@UrunHareketID", SqlDbType.Int).Value = hareketıd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }

        public bool CariHareketSilByKasa(int hareketıd)
        {
            SqlCommand comm = new SqlCommand("update CariHareketler set Silindi=1 where KasaHareketID=@KasaHareketID", conn);
            comm.Parameters.Add("@KasaHareketID", SqlDbType.Int).Value = hareketıd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }

        public DataSet HareketleriGetirByCariAndtarih(int CariNo, DateTime ilktarih, DateTime sontarih)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Convert(date, Tarih, 104) as Tarih, IslemTuru, Belge, Borc, Alacak from CariHareketler where Silindi=0 and CariNo=@CariNo and Convert(date, Tarih, 104) Between Convert(date, @Tarih1, 104) and Convert(date, @Tarih2, 104)", conn);
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.DateTime).Value = ilktarih;
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.DateTime).Value = sontarih;
            try
            {
                da.Fill(ds, "CariHareketler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }
    }
}
