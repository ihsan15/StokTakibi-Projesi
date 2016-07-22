namespace WFStokTakibi
{
    partial class CariEkstre
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
            this.rbTumFirmalar = new System.Windows.Forms.RadioButton();
            this.rbSaticilar = new System.Windows.Forms.RadioButton();
            this.rbAlicilar = new System.Windows.Forms.RadioButton();
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.txtFirmaNo = new System.Windows.Forms.TextBox();
            this.btnFirmaBul = new System.Windows.Forms.Button();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTumFirmalar
            // 
            this.rbTumFirmalar.AutoSize = true;
            this.rbTumFirmalar.Checked = true;
            this.rbTumFirmalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTumFirmalar.Location = new System.Drawing.Point(299, 70);
            this.rbTumFirmalar.Name = "rbTumFirmalar";
            this.rbTumFirmalar.Size = new System.Drawing.Size(130, 24);
            this.rbTumFirmalar.TabIndex = 32;
            this.rbTumFirmalar.TabStop = true;
            this.rbTumFirmalar.Text = "Tüm Firmalar";
            this.rbTumFirmalar.UseVisualStyleBackColor = true;
            this.rbTumFirmalar.CheckedChanged += new System.EventHandler(this.rbTumFirmalar_CheckedChanged);
            // 
            // rbSaticilar
            // 
            this.rbSaticilar.AutoSize = true;
            this.rbSaticilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSaticilar.Location = new System.Drawing.Point(161, 70);
            this.rbSaticilar.Name = "rbSaticilar";
            this.rbSaticilar.Size = new System.Drawing.Size(91, 24);
            this.rbSaticilar.TabIndex = 31;
            this.rbSaticilar.Text = "Satıcılar";
            this.rbSaticilar.UseVisualStyleBackColor = true;
            this.rbSaticilar.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbAlicilar
            // 
            this.rbAlicilar.AutoSize = true;
            this.rbAlicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAlicilar.Location = new System.Drawing.Point(22, 70);
            this.rbAlicilar.Name = "rbAlicilar";
            this.rbAlicilar.Size = new System.Drawing.Size(81, 24);
            this.rbAlicilar.TabIndex = 30;
            this.rbAlicilar.Text = "Alıcılar";
            this.rbAlicilar.UseVisualStyleBackColor = true;
            this.rbAlicilar.CheckedChanged += new System.EventHandler(this.rbAlicilar_CheckedChanged);
            // 
            // dgvCariler
            // 
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(12, 100);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.RowTemplate.Height = 24;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(417, 439);
            this.dgvCariler.TabIndex = 27;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // txtFirmaNo
            // 
            this.txtFirmaNo.BackColor = System.Drawing.Color.Turquoise;
            this.txtFirmaNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirmaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaNo.Location = new System.Drawing.Point(11, 11);
            this.txtFirmaNo.Name = "txtFirmaNo";
            this.txtFirmaNo.ReadOnly = true;
            this.txtFirmaNo.Size = new System.Drawing.Size(1, 20);
            this.txtFirmaNo.TabIndex = 34;
            // 
            // btnFirmaBul
            // 
            this.btnFirmaBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaBul.Location = new System.Drawing.Point(293, 28);
            this.btnFirmaBul.Name = "btnFirmaBul";
            this.btnFirmaBul.Size = new System.Drawing.Size(40, 26);
            this.btnFirmaBul.TabIndex = 33;
            this.btnFirmaBul.Text = "...";
            this.btnFirmaBul.UseVisualStyleBackColor = true;
            this.btnFirmaBul.Click += new System.EventHandler(this.btnFirmaBul_Click);
            // 
            // txtFirma
            // 
            this.txtFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirma.Location = new System.Drawing.Point(96, 28);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(191, 27);
            this.txtFirma.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(17, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Firma :";
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(471, 33);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(149, 22);
            this.dtpIlkTarih.TabIndex = 37;
            this.dtpIlkTarih.ValueChanged += new System.EventHandler(this.dtpIlkTarih_ValueChanged);
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(642, 33);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(149, 22);
            this.dtpSonTarih.TabIndex = 38;
            this.dtpSonTarih.ValueChanged += new System.EventHandler(this.dtpSonTarih_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(467, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(638, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Son Tarih";
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Location = new System.Drawing.Point(435, 100);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.RowTemplate.Height = 24;
            this.dgvHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareketler.Size = new System.Drawing.Size(417, 439);
            this.dgvHareketler.TabIndex = 41;
            // 
            // CariEkstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(893, 582);
            this.Controls.Add(this.dgvHareketler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.txtFirmaNo);
            this.Controls.Add(this.btnFirmaBul);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rbTumFirmalar);
            this.Controls.Add(this.rbSaticilar);
            this.Controls.Add(this.rbAlicilar);
            this.Controls.Add(this.dgvCariler);
            this.Name = "CariEkstre";
            this.Text = "CariEkstre";
            this.Load += new System.EventHandler(this.CariEkstre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTumFirmalar;
        private System.Windows.Forms.RadioButton rbSaticilar;
        private System.Windows.Forms.RadioButton rbAlicilar;
        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.TextBox txtFirmaNo;
        private System.Windows.Forms.Button btnFirmaBul;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHareketler;
    }
}