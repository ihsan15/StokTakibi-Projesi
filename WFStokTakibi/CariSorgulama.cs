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
    public partial class CariSorgulama : Form
    {
        public CariSorgulama()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        private void CariSorgulama_Load(object sender, EventArgs e)
        {
            if (Genel.CariTipi == "Alıcı") rbAlicilar.Checked = true;
            else if (Genel.CariTipi == "Satıcı") rbSaticilar.Checked = true;
            else rbTumFirmalar.Checked = true;
        }

        private void rbAlicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "Alıcı";

            Cari c = new Cari();
            ds = c.CarileriGetirByCariTipi(Genel.CariTipi);
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "Satıcı";

            Cari c = new Cari();
            ds = c.CarileriGetirByCariTipi(Genel.CariTipi);
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void rbTumFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            Cari c = new Cari();
            ds = c.CarileriGetir();
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void txtUnvanaGoreArama_TextChanged(object sender, EventArgs e)
        {
            Cari c = new Cari();
            ds = c.CarileriGetirByUnvan(txtUnvanaGoreArama.Text);
            dgvCariler.DataSource = ds.Tables["Cariler"];
            dgvCariler.Columns[0].Visible = false;
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            
            Genel.Unvan = dgvCariler.SelectedRows[0].Cells["Unvan"].Value.ToString();
            Genel.CariNo = Convert.ToInt32(dgvCariler.SelectedRows[0].Cells["CariNo"].Value);
            this.Close();
        }
    }
}
