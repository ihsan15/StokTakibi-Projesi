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
    public partial class CariEkstre : Form
    {
        public CariEkstre()
        {
            InitializeComponent();
        }

        Cari c = new Cari();
        CariHareketler ch = new CariHareketler();
        DataSet ds = new DataSet();

        private void CariEkstre_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            dtpIlkTarih.Value = DateTime.Now.AddMonths(-1);
            
        }

        private void rbAlicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "Alıcı";
            ds = c.CarileriGetirByCariTipi(Genel.CariTipi);
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "Satıcı";
            ds = c.CarileriGetirByCariTipi(Genel.CariTipi);
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbTumFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "";
            ds = c.CarileriGetirByCariTipi(Genel.CariTipi);
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            Genel.CariNo = Convert.ToInt32(Convert.ToInt32(dgvCariler.SelectedRows[0].Cells[0].Value));
            ds = ch.HareketleriGetirByCariAndtarih(Genel.CariNo, dtpIlkTarih.Value, dtpSonTarih.Value);

            dgvHareketler.DataSource = ds.Tables["CariHareketler"];
        }

        private void btnFirmaBul_Click(object sender, EventArgs e)
        {
            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            Genel.CariTipi = "";
            frm.ShowDialog();
            txtFirma.Text = Genel.Unvan;
            txtFirmaNo.Text = Genel.CariNo.ToString();
            ds = ch.HareketleriGetirByCariAndtarih(Genel.CariNo, dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvHareketler.DataSource = ds.Tables["CariHareketler"];
        }

        private void dtpIlkTarih_ValueChanged(object sender, EventArgs e)
        {
            if(Genel.CariNo != 0 )
            {
                ch.HareketleriGetirByCariAndtarih(Genel.CariNo, dtpIlkTarih.Value, dtpSonTarih.Value);
                dgvHareketler.DataSource = ds.Tables["CariHareketler"];
            }
            
        }

        private void dtpSonTarih_ValueChanged(object sender, EventArgs e)
        {
            if (Genel.CariNo != 0)
            {
                ch.HareketleriGetirByCariAndtarih(Genel.CariNo, dtpIlkTarih.Value, dtpSonTarih.Value);
                dgvHareketler.DataSource = ds.Tables["CariHareketler"];
            }
        }
    }
}
