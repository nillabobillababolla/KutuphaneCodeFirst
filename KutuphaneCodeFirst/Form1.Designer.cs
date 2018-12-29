namespace KutuphaneCodeFirst
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
            this.components = new System.ComponentModel.Container();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstKiralayanlar = new System.Windows.Forms.ListBox();
            this.kitabıKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(12, 38);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(229, 355);
            this.lstKitaplar.TabIndex = 0;
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(276, 61);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(218, 342);
            this.lstYazarlar.TabIndex = 0;
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.Location = new System.Drawing.Point(513, 61);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(218, 342);
            this.lstCalisanlar.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitabıKiralaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // lstKiralayanlar
            // 
            this.lstKiralayanlar.FormattingEnabled = true;
            this.lstKiralayanlar.Location = new System.Drawing.Point(747, 61);
            this.lstKiralayanlar.Name = "lstKiralayanlar";
            this.lstKiralayanlar.Size = new System.Drawing.Size(218, 342);
            this.lstKiralayanlar.TabIndex = 0;
            // 
            // kitabıKiralaToolStripMenuItem
            // 
            this.kitabıKiralaToolStripMenuItem.Name = "kitabıKiralaToolStripMenuItem";
            this.kitabıKiralaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitabıKiralaToolStripMenuItem.Text = "Kitabı Kirala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.lstKiralayanlar);
            this.Controls.Add(this.lstCalisanlar);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.lstKitaplar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutuphane Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.ListBox lstCalisanlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lstKiralayanlar;
        private System.Windows.Forms.ToolStripMenuItem kitabıKiralaToolStripMenuItem;
    }
}

