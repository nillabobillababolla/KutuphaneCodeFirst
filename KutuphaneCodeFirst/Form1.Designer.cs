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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİslemleriToolStripMenuItem,
            this.calisanİslemleriToolStripMenuItem,
            this.uyeİslemleriToolStripMenuItem,
            this.kiralamaİslemleriToolStripMenuItem,
            this.yazarİslemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "File";
            // 
            // kitapİslemleriToolStripMenuItem
            // 
            this.kitapİslemleriToolStripMenuItem.Name = "kitapİslemleriToolStripMenuItem";
            this.kitapİslemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.kitapİslemleriToolStripMenuItem.Text = "Kitapİslemleri";
            this.kitapİslemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİslemleriToolStripMenuItem_Click);
            // 
            // calisanİslemleriToolStripMenuItem
            // 
            this.calisanİslemleriToolStripMenuItem.Name = "calisanİslemleriToolStripMenuItem";
            this.calisanİslemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.calisanİslemleriToolStripMenuItem.Text = "Calisanİslemleri";
            this.calisanİslemleriToolStripMenuItem.Click += new System.EventHandler(this.calisanİslemleriToolStripMenuItem_Click);
            // 
            // uyeİslemleriToolStripMenuItem
            // 
            this.uyeİslemleriToolStripMenuItem.Name = "uyeİslemleriToolStripMenuItem";
            this.uyeİslemleriToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.uyeİslemleriToolStripMenuItem.Text = "Uyeİslemleri";
            this.uyeİslemleriToolStripMenuItem.Click += new System.EventHandler(this.uyeİslemleriToolStripMenuItem_Click);
            // 
            // kiralamaİslemleriToolStripMenuItem
            // 
            this.kiralamaİslemleriToolStripMenuItem.Name = "kiralamaİslemleriToolStripMenuItem";
            this.kiralamaİslemleriToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.kiralamaİslemleriToolStripMenuItem.Text = "Kiralamaİslemleri";
            this.kiralamaİslemleriToolStripMenuItem.Click += new System.EventHandler(this.kiralamaİslemleriToolStripMenuItem_Click);
            // 
            // yazarİslemleriToolStripMenuItem
            // 
            this.yazarİslemleriToolStripMenuItem.Name = "yazarİslemleriToolStripMenuItem";
            this.yazarİslemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.yazarİslemleriToolStripMenuItem.Text = "Yazarİslemleri";
            this.yazarİslemleriToolStripMenuItem.Click += new System.EventHandler(this.yazarİslemleriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutuphane Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarİslemleriToolStripMenuItem;
    }
}

