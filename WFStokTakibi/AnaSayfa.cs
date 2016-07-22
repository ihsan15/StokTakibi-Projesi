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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void miCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAcilacakmi(Form AcilacakForm)
        {
            bool acikmi = false;
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); // oluşturulmuş form listesini doğrudan atabiliriz.
            }
        }

        private void miUrunKartlari_Click(object sender, EventArgs e)
        {
            Genel.sayfano = 0;
            UrunIslemleri frm = new UrunIslemleri();
            FormAcilacakmi(frm);
        }

        private void miStokSorgulama_Click(object sender, EventArgs e)
        {
            Genel.sayfano = 2;
            UrunIslemleri frm = new UrunIslemleri();
            FormAcilacakmi(frm);
        }

        private void miStokGirisCikis_Click(object sender, EventArgs e)
        {
            Genel.sayfano = 1;
            UrunIslemleri frm = new UrunIslemleri();
            FormAcilacakmi(frm);
        }

        private void günlükKasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasaIslemleri frm = new KasaIslemleri();
            FormAcilacakmi(frm);
        }

        private void miMusteriCariEkstre_Click(object sender, EventArgs e)
        {
            CariEkstre frm = new CariEkstre();
            FormAcilacakmi(frm);
        }
    }
}
