namespace KutuphaneCodeFirst
{
    partial class KiralamaIslemleri
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
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.cmbKiralayanlar = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstUyeKitaplari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(12, 12);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(437, 95);
            this.lstKitaplar.TabIndex = 0;
            // 
            // cmbKiralayanlar
            // 
            this.cmbKiralayanlar.FormattingEnabled = true;
            this.cmbKiralayanlar.Location = new System.Drawing.Point(12, 113);
            this.cmbKiralayanlar.Name = "cmbKiralayanlar";
            this.cmbKiralayanlar.Size = new System.Drawing.Size(437, 21);
            this.cmbKiralayanlar.TabIndex = 1;
            this.cmbKiralayanlar.SelectedIndexChanged += new System.EventHandler(this.cmbKiralayanlar_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(374, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kitabı Ver";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstUyeKitaplari
            // 
            this.lstUyeKitaplari.FormattingEnabled = true;
            this.lstUyeKitaplari.Location = new System.Drawing.Point(12, 343);
            this.lstUyeKitaplari.Name = "lstUyeKitaplari";
            this.lstUyeKitaplari.Size = new System.Drawing.Size(437, 95);
            this.lstUyeKitaplari.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seçili Üyenin Elinde Bulunan Kitaplar:";
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(345, 314);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(104, 23);
            this.btnTeslimAl.TabIndex = 5;
            this.btnTeslimAl.Text = "Kitabı Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // KiralamaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUyeKitaplari);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbKiralayanlar);
            this.Controls.Add(this.lstKitaplar);
            this.Name = "KiralamaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "KiralamaIslemleri";
            this.Load += new System.EventHandler(this.KiralamaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.ComboBox cmbKiralayanlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstUyeKitaplari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeslimAl;
    }
}