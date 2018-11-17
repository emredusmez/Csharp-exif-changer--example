namespace Exiff_değiştirici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lsbResimlistesi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chbAciklama = new System.Windows.Forms.CheckBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.chbEtiketler = new System.Windows.Forms.CheckBox();
            this.txtEtiketler = new System.Windows.Forms.TextBox();
            this.chbKonu = new System.Windows.Forms.CheckBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.chbBaslik = new System.Windows.Forms.CheckBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prgDurum = new System.Windows.Forms.ProgressBar();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbResimlistesi
            // 
            this.lsbResimlistesi.FormattingEnabled = true;
            this.lsbResimlistesi.Location = new System.Drawing.Point(12, 59);
            this.lsbResimlistesi.Name = "lsbResimlistesi";
            this.lsbResimlistesi.Size = new System.Drawing.Size(268, 394);
            this.lsbResimlistesi.TabIndex = 0;
            this.lsbResimlistesi.SelectedIndexChanged += new System.EventHandler(this.lsbResimlistesi_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.chbAciklama);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.chbEtiketler);
            this.groupBox1.Controls.Add(this.txtEtiketler);
            this.groupBox1.Controls.Add(this.chbKonu);
            this.groupBox1.Controls.Add(this.txtKonu);
            this.groupBox1.Controls.Add(this.chbBaslik);
            this.groupBox1.Controls.Add(this.txtBaslik);
            this.groupBox1.Location = new System.Drawing.Point(320, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Değiştirmek istediğiniz alan için ilgili kutucuğu işaretleyin";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Tekli düzenle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Çoklu düzenle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chbAciklama
            // 
            this.chbAciklama.AutoSize = true;
            this.chbAciklama.Location = new System.Drawing.Point(6, 186);
            this.chbAciklama.Name = "chbAciklama";
            this.chbAciklama.Size = new System.Drawing.Size(69, 17);
            this.chbAciklama.TabIndex = 6;
            this.chbAciklama.Text = "Açıklama";
            this.chbAciklama.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 209);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(305, 178);
            this.txtAciklama.TabIndex = 7;
            // 
            // chbEtiketler
            // 
            this.chbEtiketler.AutoSize = true;
            this.chbEtiketler.Location = new System.Drawing.Point(6, 135);
            this.chbEtiketler.Name = "chbEtiketler";
            this.chbEtiketler.Size = new System.Drawing.Size(64, 17);
            this.chbEtiketler.TabIndex = 4;
            this.chbEtiketler.Text = "Etiketler";
            this.chbEtiketler.UseVisualStyleBackColor = true;
            // 
            // txtEtiketler
            // 
            this.txtEtiketler.Location = new System.Drawing.Point(6, 158);
            this.txtEtiketler.Name = "txtEtiketler";
            this.txtEtiketler.Size = new System.Drawing.Size(305, 20);
            this.txtEtiketler.TabIndex = 5;
            // 
            // chbKonu
            // 
            this.chbKonu.AutoSize = true;
            this.chbKonu.Location = new System.Drawing.Point(6, 86);
            this.chbKonu.Name = "chbKonu";
            this.chbKonu.Size = new System.Drawing.Size(51, 17);
            this.chbKonu.TabIndex = 2;
            this.chbKonu.Text = "Konu";
            this.chbKonu.UseVisualStyleBackColor = true;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(6, 109);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(305, 20);
            this.txtKonu.TabIndex = 3;
            // 
            // chbBaslik
            // 
            this.chbBaslik.AutoSize = true;
            this.chbBaslik.Location = new System.Drawing.Point(6, 35);
            this.chbBaslik.Name = "chbBaslik";
            this.chbBaslik.Size = new System.Drawing.Size(54, 17);
            this.chbBaslik.TabIndex = 0;
            this.chbBaslik.Text = "Başlık";
            this.chbBaslik.UseVisualStyleBackColor = true;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(6, 58);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(305, 20);
            this.txtBaslik.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dosya ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dosya çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prgDurum
            // 
            this.prgDurum.Location = new System.Drawing.Point(12, 460);
            this.prgDurum.Name = "prgDurum";
            this.prgDurum.Size = new System.Drawing.Size(268, 23);
            this.prgDurum.TabIndex = 4;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(9, 486);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Norm Yazılım -";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(527, 491);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.normyazilim.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 541);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.prgDurum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbResimlistesi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exif Değiştirici - Norm Yazılım";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbResimlistesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.CheckBox chbAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.CheckBox chbEtiketler;
        private System.Windows.Forms.TextBox txtEtiketler;
        private System.Windows.Forms.CheckBox chbKonu;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar prgDurum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.CheckBox chbBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

