﻿namespace WFStokTakibi
{
    partial class KasaIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtCikan = new System.Windows.Forms.TextBox();
            this.txtGiren = new System.Windows.Forms.TextBox();
            this.txtBelge = new System.Windows.Forms.TextBox();
            this.txtCariUnvan = new System.Windows.Forms.TextBox();
            this.txtIslemTuru = new System.Windows.Forms.TextBox();
            this.txtIslemTarihi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtToplamCikan = new System.Windows.Forms.TextBox();
            this.txtToplamGiren = new System.Windows.Forms.TextBox();
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtDevirBakiye = new System.Windows.Forms.TextBox();
            this.txtDevirCikan = new System.Windows.Forms.TextBox();
            this.txtDevirGiren = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKasaTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(241, 173);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(0, 22);
            this.txtCariNo.TabIndex = 79;
            this.txtCariNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCariNo.Visible = false;
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Tahsilat",
            "Ödeme"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(148, 173);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(75, 24);
            this.cbIslemTurleri.TabIndex = 78;
            this.cbIslemTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIslemTurleri_SelectedIndexChanged);
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(694, 200);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(51, 22);
            this.txtPara.TabIndex = 77;
            this.txtPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCikan
            // 
            this.txtCikan.Location = new System.Drawing.Point(611, 200);
            this.txtCikan.Name = "txtCikan";
            this.txtCikan.Size = new System.Drawing.Size(81, 22);
            this.txtCikan.TabIndex = 76;
            this.txtCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiren
            // 
            this.txtGiren.Location = new System.Drawing.Point(532, 200);
            this.txtGiren.Name = "txtGiren";
            this.txtGiren.Size = new System.Drawing.Size(79, 22);
            this.txtGiren.TabIndex = 75;
            this.txtGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBelge
            // 
            this.txtBelge.Location = new System.Drawing.Point(344, 200);
            this.txtBelge.Name = "txtBelge";
            this.txtBelge.Size = new System.Drawing.Size(188, 22);
            this.txtBelge.TabIndex = 74;
            this.txtBelge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCariUnvan
            // 
            this.txtCariUnvan.Location = new System.Drawing.Point(224, 200);
            this.txtCariUnvan.Name = "txtCariUnvan";
            this.txtCariUnvan.ReadOnly = true;
            this.txtCariUnvan.Size = new System.Drawing.Size(119, 22);
            this.txtCariUnvan.TabIndex = 73;
            this.txtCariUnvan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIslemTuru
            // 
            this.txtIslemTuru.Location = new System.Drawing.Point(148, 200);
            this.txtIslemTuru.Name = "txtIslemTuru";
            this.txtIslemTuru.ReadOnly = true;
            this.txtIslemTuru.Size = new System.Drawing.Size(75, 22);
            this.txtIslemTuru.TabIndex = 72;
            this.txtIslemTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIslemTarihi
            // 
            this.txtIslemTarihi.Location = new System.Drawing.Point(64, 200);
            this.txtIslemTarihi.Name = "txtIslemTarihi";
            this.txtIslemTarihi.ReadOnly = true;
            this.txtIslemTarihi.Size = new System.Drawing.Size(83, 22);
            this.txtIslemTarihi.TabIndex = 71;
            this.txtIslemTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(25, 200);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(38, 22);
            this.txtID.TabIndex = 70;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(599, 133);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(52, 25);
            this.btnSil.TabIndex = 69;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(523, 133);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(64, 25);
            this.btnDegistir.TabIndex = 68;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(447, 133);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 25);
            this.btnKaydet.TabIndex = 67;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(381, 133);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(54, 25);
            this.btnYeni.TabIndex = 66;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(698, 422);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(80, 22);
            this.txtBakiye.TabIndex = 65;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamCikan
            // 
            this.txtToplamCikan.Location = new System.Drawing.Point(617, 422);
            this.txtToplamCikan.Name = "txtToplamCikan";
            this.txtToplamCikan.ReadOnly = true;
            this.txtToplamCikan.Size = new System.Drawing.Size(80, 22);
            this.txtToplamCikan.TabIndex = 64;
            this.txtToplamCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamGiren
            // 
            this.txtToplamGiren.Location = new System.Drawing.Point(536, 422);
            this.txtToplamGiren.Name = "txtToplamGiren";
            this.txtToplamGiren.ReadOnly = true;
            this.txtToplamGiren.Size = new System.Drawing.Size(80, 22);
            this.txtToplamGiren.TabIndex = 63;
            this.txtToplamGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvHareketler.FullRowSelect = true;
            this.lvHareketler.GridLines = true;
            this.lvHareketler.Location = new System.Drawing.Point(25, 229);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(728, 187);
            this.lvHareketler.TabIndex = 62;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            this.lvHareketler.DoubleClick += new System.EventHandler(this.lvHareketler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İşlemTarihi";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlemTürü";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CariÜnvan";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Belge";
            this.columnHeader5.Width = 188;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giren";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Çıkan";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Para";
            this.columnHeader8.Width = 49;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CariNo";
            this.columnHeader9.Width = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "DEVİRLER";
            // 
            // txtDevirBakiye
            // 
            this.txtDevirBakiye.Location = new System.Drawing.Point(580, 90);
            this.txtDevirBakiye.Name = "txtDevirBakiye";
            this.txtDevirBakiye.ReadOnly = true;
            this.txtDevirBakiye.Size = new System.Drawing.Size(112, 22);
            this.txtDevirBakiye.TabIndex = 60;
            this.txtDevirBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirCikan
            // 
            this.txtDevirCikan.Location = new System.Drawing.Point(462, 90);
            this.txtDevirCikan.Name = "txtDevirCikan";
            this.txtDevirCikan.ReadOnly = true;
            this.txtDevirCikan.Size = new System.Drawing.Size(112, 22);
            this.txtDevirCikan.TabIndex = 59;
            this.txtDevirCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirGiren
            // 
            this.txtDevirGiren.Location = new System.Drawing.Point(344, 90);
            this.txtDevirGiren.Name = "txtDevirGiren";
            this.txtDevirGiren.ReadOnly = true;
            this.txtDevirGiren.Size = new System.Drawing.Size(112, 22);
            this.txtDevirGiren.TabIndex = 58;
            this.txtDevirGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "TL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Para Birimi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(216, 88);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(29, 22);
            this.dtpTarih.TabIndex = 55;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(103, 88);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(112, 22);
            this.txtTarih.TabIndex = 54;
            this.txtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tarih";
            // 
            // txtKasaTuru
            // 
            this.txtKasaTuru.Location = new System.Drawing.Point(103, 59);
            this.txtKasaTuru.Name = "txtKasaTuru";
            this.txtKasaTuru.ReadOnly = true;
            this.txtKasaTuru.Size = new System.Drawing.Size(112, 22);
            this.txtKasaTuru.TabIndex = 52;
            this.txtKasaTuru.Text = "Merkez Kasa";
            this.txtKasaTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Kasa Türü";
            // 
            // KasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(793, 483);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtCikan);
            this.Controls.Add(this.txtGiren);
            this.Controls.Add(this.txtBelge);
            this.Controls.Add(this.txtCariUnvan);
            this.Controls.Add(this.txtIslemTuru);
            this.Controls.Add(this.txtIslemTarihi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtToplamCikan);
            this.Controls.Add(this.txtToplamGiren);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDevirBakiye);
            this.Controls.Add(this.txtDevirCikan);
            this.Controls.Add(this.txtDevirGiren);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKasaTuru);
            this.Controls.Add(this.label1);
            this.Name = "KasaIslemleri";
            this.Text = "KasaIslemleri";
            this.Load += new System.EventHandler(this.KasaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtCikan;
        private System.Windows.Forms.TextBox txtGiren;
        private System.Windows.Forms.TextBox txtBelge;
        private System.Windows.Forms.TextBox txtCariUnvan;
        private System.Windows.Forms.TextBox txtIslemTuru;
        private System.Windows.Forms.TextBox txtIslemTarihi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtToplamCikan;
        private System.Windows.Forms.TextBox txtToplamGiren;
        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDevirBakiye;
        private System.Windows.Forms.TextBox txtDevirCikan;
        private System.Windows.Forms.TextBox txtDevirGiren;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasaTuru;
        private System.Windows.Forms.Label label1;
    }
}