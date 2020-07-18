namespace IsimSoftwareSimpleFTP
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
            this.bAdres = new System.Windows.Forms.Button();
            this.bYenile = new System.Windows.Forms.Button();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.adresler = new System.Windows.Forms.ListBox();
            this.dosyalar = new System.Windows.Forms.ListBox();
            this.bGonder = new System.Windows.Forms.Button();
            this.prg = new System.Windows.Forms.ProgressBar();
            this.liste = new System.Windows.Forms.CheckedListBox();
            this.lDosya = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Hepsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAdres
            // 
            this.bAdres.Location = new System.Drawing.Point(6, 203);
            this.bAdres.Name = "bAdres";
            this.bAdres.Size = new System.Drawing.Size(75, 23);
            this.bAdres.TabIndex = 1;
            this.bAdres.Text = "Liste Ekle";
            this.bAdres.UseVisualStyleBackColor = true;
            this.bAdres.Click += new System.EventHandler(this.bAdres_Click);
            // 
            // bYenile
            // 
            this.bYenile.Location = new System.Drawing.Point(87, 203);
            this.bYenile.Name = "bYenile";
            this.bYenile.Size = new System.Drawing.Size(75, 23);
            this.bYenile.TabIndex = 2;
            this.bYenile.Text = "Göster";
            this.bYenile.UseVisualStyleBackColor = true;
            this.bYenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDuzenle
            // 
            this.bDuzenle.Location = new System.Drawing.Point(87, 232);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(75, 23);
            this.bDuzenle.TabIndex = 4;
            this.bDuzenle.Text = "Düzenle";
            this.bDuzenle.UseVisualStyleBackColor = true;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(6, 232);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(75, 23);
            this.bSil.TabIndex = 3;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // adresler
            // 
            this.adresler.FormattingEnabled = true;
            this.adresler.HorizontalScrollbar = true;
            this.adresler.Location = new System.Drawing.Point(167, 7);
            this.adresler.Name = "adresler";
            this.adresler.Size = new System.Drawing.Size(204, 277);
            this.adresler.TabIndex = 5;
            // 
            // dosyalar
            // 
            this.dosyalar.FormattingEnabled = true;
            this.dosyalar.HorizontalScrollbar = true;
            this.dosyalar.Location = new System.Drawing.Point(377, 6);
            this.dosyalar.Name = "dosyalar";
            this.dosyalar.Size = new System.Drawing.Size(286, 277);
            this.dosyalar.TabIndex = 6;
            // 
            // bGonder
            // 
            this.bGonder.Location = new System.Drawing.Point(5, 259);
            this.bGonder.Name = "bGonder";
            this.bGonder.Size = new System.Drawing.Size(156, 46);
            this.bGonder.TabIndex = 7;
            this.bGonder.Text = "G Ö N D E R";
            this.bGonder.UseVisualStyleBackColor = true;
            this.bGonder.Click += new System.EventHandler(this.bGonder_Click);
            // 
            // prg
            // 
            this.prg.Location = new System.Drawing.Point(167, 306);
            this.prg.Name = "prg";
            this.prg.Size = new System.Drawing.Size(496, 23);
            this.prg.TabIndex = 8;
            // 
            // liste
            // 
            this.liste.CheckOnClick = true;
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(5, 7);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(156, 169);
            this.liste.TabIndex = 9;
            this.liste.SelectedIndexChanged += new System.EventHandler(this.liste_DoubleClick);
            // 
            // lDosya
            // 
            this.lDosya.AutoSize = true;
            this.lDosya.Location = new System.Drawing.Point(167, 290);
            this.lDosya.Name = "lDosya";
            this.lDosya.Size = new System.Drawing.Size(216, 13);
            this.lDosya.TabIndex = 10;
            this.lDosya.Text = "Dosya Gönderme Durumu                             ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "K A P A T";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Hepsi
            // 
            this.Hepsi.Location = new System.Drawing.Point(5, 177);
            this.Hepsi.Name = "Hepsi";
            this.Hepsi.Size = new System.Drawing.Size(156, 23);
            this.Hepsi.TabIndex = 12;
            this.Hepsi.Text = "Tümünü Seç";
            this.Hepsi.UseVisualStyleBackColor = true;
            this.Hepsi.Click += new System.EventHandler(this.Hepsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(669, 338);
            this.Controls.Add(this.Hepsi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lDosya);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.prg);
            this.Controls.Add(this.bGonder);
            this.Controls.Add(this.dosyalar);
            this.Controls.Add(this.adresler);
            this.Controls.Add(this.bDuzenle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bYenile);
            this.Controls.Add(this.bAdres);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdres;
        private System.Windows.Forms.Button bYenile;
        private System.Windows.Forms.Button bDuzenle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.ListBox adresler;
        private System.Windows.Forms.ListBox dosyalar;
        private System.Windows.Forms.Button bGonder;
        private System.Windows.Forms.ProgressBar prg;
        private System.Windows.Forms.CheckedListBox liste;
        private System.Windows.Forms.Label lDosya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Hepsi;

    }
}

