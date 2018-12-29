namespace KutuphaneCodeFirst
{
    partial class KitapIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.nuAdet = new System.Windows.Forms.NumericUpDown();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.cmsKitapSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).BeginInit();
            this.cmsKitapSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKitapKaydet);
            this.groupBox1.Controls.Add(this.nuAdet);
            this.groupBox1.Controls.Add(this.cmbYazar);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekleme";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(63, 33);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(63, 59);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(121, 20);
            this.txtKategori.TabIndex = 1;
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(63, 85);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(121, 21);
            this.cmbYazar.TabIndex = 2;
            // 
            // nuAdet
            // 
            this.nuAdet.Location = new System.Drawing.Point(64, 112);
            this.nuAdet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAdet.Name = "nuAdet";
            this.nuAdet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nuAdet.Size = new System.Drawing.Size(120, 20);
            this.nuAdet.TabIndex = 3;
            this.nuAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(109, 138);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKitapKaydet.TabIndex = 4;
            this.btnKitapKaydet.Text = "Kitap Ekle";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adet:";
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.ContextMenuStrip = this.cmsKitapSil;
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(218, 18);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(570, 134);
            this.lstKitaplar.TabIndex = 1;
            this.lstKitaplar.SelectedIndexChanged += new System.EventHandler(this.lstKitaplar_SelectedIndexChanged);
            // 
            // cmsKitapSil
            // 
            this.cmsKitapSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsKitapSil.Name = "cmsKitapSil";
            this.cmsKitapSil.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KitapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).EndInit();
            this.cmsKitapSil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.NumericUpDown nuAdet;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.ContextMenuStrip cmsKitapSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}