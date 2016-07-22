namespace WFStokTakibi
{
    partial class CariSorgulama
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
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnvanaGoreArama = new System.Windows.Forms.TextBox();
            this.rbAlicilar = new System.Windows.Forms.RadioButton();
            this.rbSaticilar = new System.Windows.Forms.RadioButton();
            this.rbTumFirmalar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariler
            // 
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(12, 207);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.RowTemplate.Height = 24;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(774, 447);
            this.dgvCariler.TabIndex = 0;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Unvana Gore Arama";
            // 
            // txtUnvanaGoreArama
            // 
            this.txtUnvanaGoreArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnvanaGoreArama.Location = new System.Drawing.Point(27, 144);
            this.txtUnvanaGoreArama.Name = "txtUnvanaGoreArama";
            this.txtUnvanaGoreArama.Size = new System.Drawing.Size(182, 26);
            this.txtUnvanaGoreArama.TabIndex = 22;
            this.txtUnvanaGoreArama.TextChanged += new System.EventHandler(this.txtUnvanaGoreArama_TextChanged);
            // 
            // rbAlicilar
            // 
            this.rbAlicilar.AutoSize = true;
            this.rbAlicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAlicilar.Location = new System.Drawing.Point(238, 144);
            this.rbAlicilar.Name = "rbAlicilar";
            this.rbAlicilar.Size = new System.Drawing.Size(81, 24);
            this.rbAlicilar.TabIndex = 24;
            this.rbAlicilar.Text = "Alıcılar";
            this.rbAlicilar.UseVisualStyleBackColor = true;
            this.rbAlicilar.CheckedChanged += new System.EventHandler(this.rbAlicilar_CheckedChanged);
            // 
            // rbSaticilar
            // 
            this.rbSaticilar.AutoSize = true;
            this.rbSaticilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSaticilar.Location = new System.Drawing.Point(343, 144);
            this.rbSaticilar.Name = "rbSaticilar";
            this.rbSaticilar.Size = new System.Drawing.Size(91, 24);
            this.rbSaticilar.TabIndex = 25;
            this.rbSaticilar.Text = "Satıcılar";
            this.rbSaticilar.UseVisualStyleBackColor = true;
            this.rbSaticilar.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbTumFirmalar
            // 
            this.rbTumFirmalar.AutoSize = true;
            this.rbTumFirmalar.Checked = true;
            this.rbTumFirmalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTumFirmalar.Location = new System.Drawing.Point(460, 144);
            this.rbTumFirmalar.Name = "rbTumFirmalar";
            this.rbTumFirmalar.Size = new System.Drawing.Size(130, 24);
            this.rbTumFirmalar.TabIndex = 26;
            this.rbTumFirmalar.TabStop = true;
            this.rbTumFirmalar.Text = "Tüm Firmalar";
            this.rbTumFirmalar.UseVisualStyleBackColor = true;
            this.rbTumFirmalar.CheckedChanged += new System.EventHandler(this.rbTumFirmalar_CheckedChanged);
            // 
            // CariSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(795, 720);
            this.Controls.Add(this.rbTumFirmalar);
            this.Controls.Add(this.rbSaticilar);
            this.Controls.Add(this.rbAlicilar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUnvanaGoreArama);
            this.Controls.Add(this.dgvCariler);
            this.Name = "CariSorgulama";
            this.Text = "CariSorgulama";
            this.Load += new System.EventHandler(this.CariSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnvanaGoreArama;
        private System.Windows.Forms.RadioButton rbAlicilar;
        private System.Windows.Forms.RadioButton rbSaticilar;
        private System.Windows.Forms.RadioButton rbTumFirmalar;
    }
}