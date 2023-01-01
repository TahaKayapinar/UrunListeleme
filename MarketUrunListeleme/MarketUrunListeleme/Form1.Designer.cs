namespace MarketUrunListeleme
{
    partial class Form1
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
            this.lstUrunlerListesi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEkraniTemizle = new System.Windows.Forms.Button();
            this.cmbUrunSiniflari = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dtpSKT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrunlerListesi
            // 
            this.lstUrunlerListesi.FormattingEnabled = true;
            this.lstUrunlerListesi.Location = new System.Drawing.Point(281, 5);
            this.lstUrunlerListesi.Name = "lstUrunlerListesi";
            this.lstUrunlerListesi.Size = new System.Drawing.Size(194, 277);
            this.lstUrunlerListesi.TabIndex = 0;
            this.lstUrunlerListesi.SelectedIndexChanged += new System.EventHandler(this.lstUrunlerListesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(76, 19);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(173, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod No";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(76, 48);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(173, 20);
            this.txtBarkodNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birim Fiyat";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(76, 77);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(173, 20);
            this.txtBirimFiyat.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEkraniTemizle);
            this.panel1.Controls.Add(this.cmbUrunSiniflari);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.dtpSKT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBirimFiyat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBarkodNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUrunAdi);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 279);
            this.panel1.TabIndex = 3;
            // 
            // btnEkraniTemizle
            // 
            this.btnEkraniTemizle.Location = new System.Drawing.Point(16, 238);
            this.btnEkraniTemizle.Name = "btnEkraniTemizle";
            this.btnEkraniTemizle.Size = new System.Drawing.Size(233, 23);
            this.btnEkraniTemizle.TabIndex = 6;
            this.btnEkraniTemizle.Text = "Ekranı Temizle";
            this.btnEkraniTemizle.UseVisualStyleBackColor = true;
            this.btnEkraniTemizle.Click += new System.EventHandler(this.btnEkraniTemizle_Click);
            // 
            // cmbUrunSiniflari
            // 
            this.cmbUrunSiniflari.FormattingEnabled = true;
            this.cmbUrunSiniflari.Location = new System.Drawing.Point(76, 139);
            this.cmbUrunSiniflari.Name = "cmbUrunSiniflari";
            this.cmbUrunSiniflari.Size = new System.Drawing.Size(173, 21);
            this.cmbUrunSiniflari.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(136, 183);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 49);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(16, 182);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(104, 49);
            this.btnUrunEkle.TabIndex = 4;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dtpSKT
            // 
            this.dtpSKT.Location = new System.Drawing.Point(76, 108);
            this.dtpSKT.Name = "dtpSKT";
            this.dtpSKT.Size = new System.Drawing.Size(173, 20);
            this.dtpSKT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürün Sınıfı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SKT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstUrunlerListesi);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunlerListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.DateTimePicker dtpSKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUrunSiniflari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkraniTemizle;
    }
}

