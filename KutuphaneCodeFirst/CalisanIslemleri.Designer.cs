namespace KutuphaneCodeFirst
{
    partial class CalisanIslemleri
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
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.gbCalisanEkle = new System.Windows.Forms.GroupBox();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalisanKaydet = new System.Windows.Forms.Button();
            this.txtCalisanSoyad = new System.Windows.Forms.TextBox();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.gbCalisanEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.Location = new System.Drawing.Point(218, 139);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(570, 173);
            this.lstCalisanlar.TabIndex = 3;
            this.lstCalisanlar.SelectedIndexChanged += new System.EventHandler(this.lstCalisanlar_SelectedIndexChanged);
            // 
            // gbCalisanEkle
            // 
            this.gbCalisanEkle.Controls.Add(this.txtGorev);
            this.gbCalisanEkle.Controls.Add(this.btnGuncelle);
            this.gbCalisanEkle.Controls.Add(this.txtMaas);
            this.gbCalisanEkle.Controls.Add(this.label4);
            this.gbCalisanEkle.Controls.Add(this.label3);
            this.gbCalisanEkle.Controls.Add(this.label2);
            this.gbCalisanEkle.Controls.Add(this.label1);
            this.gbCalisanEkle.Controls.Add(this.btnCalisanKaydet);
            this.gbCalisanEkle.Controls.Add(this.txtCalisanSoyad);
            this.gbCalisanEkle.Controls.Add(this.txtCalisanAdi);
            this.gbCalisanEkle.Location = new System.Drawing.Point(12, 139);
            this.gbCalisanEkle.Name = "gbCalisanEkle";
            this.gbCalisanEkle.Size = new System.Drawing.Size(200, 173);
            this.gbCalisanEkle.TabIndex = 2;
            this.gbCalisanEkle.TabStop = false;
            this.gbCalisanEkle.Text = "Çalışan Ekleme";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(63, 85);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(121, 20);
            this.txtGorev.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(126, 137);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(58, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(63, 111);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(121, 20);
            this.txtMaas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Görevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calisan Adı:";
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.Location = new System.Drawing.Point(62, 137);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(58, 23);
            this.btnCalisanKaydet.TabIndex = 4;
            this.btnCalisanKaydet.Text = "Ekle";
            this.btnCalisanKaydet.UseVisualStyleBackColor = true;
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // txtCalisanSoyad
            // 
            this.txtCalisanSoyad.Location = new System.Drawing.Point(63, 59);
            this.txtCalisanSoyad.Name = "txtCalisanSoyad";
            this.txtCalisanSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtCalisanSoyad.TabIndex = 1;
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(63, 33);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(121, 20);
            this.txtCalisanAdi.TabIndex = 0;
            // 
            // CalisanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCalisanlar);
            this.Controls.Add(this.gbCalisanEkle);
            this.Name = "CalisanIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CalisanIslemleri";
            this.Load += new System.EventHandler(this.CalisanIslemleri_Load);
            this.gbCalisanEkle.ResumeLayout(false);
            this.gbCalisanEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCalisanlar;
        private System.Windows.Forms.GroupBox gbCalisanEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalisanKaydet;
        private System.Windows.Forms.TextBox txtCalisanSoyad;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.TextBox txtGorev;
    }
}