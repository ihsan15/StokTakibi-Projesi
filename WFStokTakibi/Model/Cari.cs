using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFStokTakibi.Model
{
    class Cari
    {
        private int _cariNo;
        private string _unvan;
        private string _yetkili;
        private string _telefon;
        private string _adres;
        private string _ılce;
        private string _ıl;
        private string _vergiNo;
        private string _vergiDairesi;
        private decimal _toplamBorc;
        private decimal _toplamAlacak;
        private decimal _bakiye;

        #region Properties
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

        public string Unvan
        {
            get
            {
                return _unvan;
            }

            set
            {
                _unvan = value;
            }
        }

        public string Yetkili
        {
            get
            {
                return _yetkili;
            }

            set
            {
                _yetkili = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        public string Ilce
        {
            get
            {
                return _ılce;
            }

            set
            {
                _ılce = value;
            }
        }

        public string Il
        {
            get
            {
                return _ıl;
            }

            set
            {
                _ıl = value;
            }
        }

        public string VergiNo
        {
            get
            {
                return _vergiNo;
            }

            set
            {
                _vergiNo = value;
            }
        }

        public string VergiDairesi
        {
            get
            {
                return _vergiDairesi;
            }

            set
            {
                _vergiDairesi = value;
            }
        }

        public decimal ToplamBorc
        {
            get
            {
                return _toplamBorc;
            }

            set
            {
                _toplamBorc = value;
            }
        }

        public decimal ToplamAlacak
        {
            get
            {
                return _toplamAlacak;
            }

            set
            {
                _toplamAlacak = value;
            }
        }

        public decimal Bakiye
        {
            get
            {
                return _bakiye;
            }

            set
            {
                _bakiye = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();

        public DataSet CarileriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Cariler where Silindi=0", conn);
            try
            {
                da.Fill(ds, "Cariler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }

        public DataSet CarileriGetirByCariTipi(string CariTipi)
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from Cariler where Silindi=0 and CariTipi like @CariTipi +'%'", conn);
            da.SelectCommand.Parameters.Add("@CariTipi", SqlDbType.VarChar).Value = CariTipi;
            try
            {
                da.Fill(ds, "Cariler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }

        public DataSet CarileriGetirByUnvan(string Unvan)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Cariler where Silindi=0 and Unvan like @Unvan+'%'", conn);
            da.SelectCommand.Parameters.Add("@Unvan", SqlDbType.VarChar).Value = Unvan;
            try
            {
                da.Fill(ds, "Cariler");
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return ds;
        }

        public bool CariToplamlariGuncelleFromUrunKasaHareket(int cariNo, decimal borc, decimal alacak)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Update Cariler Set ToplamBorc=ToplamBorc+@Borc, ToplamAlacak=ToplamAlacak+@Alacak where CariNo=@CariNo", conn);
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = borc;
            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = alacak;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = cariNo;
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
