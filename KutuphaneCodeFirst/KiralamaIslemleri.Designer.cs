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
            // KiralamaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbKiralayanlar);
            this.Controls.Add(this.lstKitaplar);
            this.Name = "KiralamaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "KiralamaIslemleri";
            this.Load += new System.EventHandler(this.KiralamaIslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.ComboBox cmbKiralayanlar;
        private System.Windows.Forms.Button btnKaydet;
    }
}