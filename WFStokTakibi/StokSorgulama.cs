﻿using System;
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
    public partial class StokSorgulama : Form
    {
        public StokSorgulama()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        private void StokSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Kategori k = new Kategori();
            
        }

    }
}
