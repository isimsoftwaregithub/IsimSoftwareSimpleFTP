namespace IsimSoftwareSimpleFTP
{
    partial class Adres
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
            this.P1 = new System.Windows.Forms.Panel();
            this.bEkle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.tPass = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.ListBox();
            this.dosyalar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bDosyaEkle = new System.Windows.Forms.Button();
            this.tDosya = new System.Windows.Forms.TextBox();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bKapat = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P1.Controls.Add(this.bEkle);
            this.P1.Controls.Add(this.bSil);
            this.P1.Controls.Add(this.tPass);
            this.P1.Controls.Add(this.tUser);
            this.P1.Controls.Add(this.tAdres);
            this.P1.Controls.Add(this.label3);
            this.P1.Controls.Add(this.label2);
            this.P1.Controls.Add(this.label1);
            this.P1.Location = new System.Drawing.Point(12, 11);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(294, 118);
            this.P1.TabIndex = 2;
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(208, 85);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(75, 23);
            this.bEkle.TabIndex = 7;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(127, 85);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(75, 23);
            this.bSil.TabIndex = 6;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(63, 59);
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(222, 20);
            this.tPass.TabIndex = 5;
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(63, 33);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(222, 20);
            this.tUser.TabIndex = 4;
            // 
            // tAdres
            // 
            this.tAdres.Location = new System.Drawing.Point(63, 7);
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(222, 20);
            this.tAdres.TabIndex = 3;
            this.tAdres.Text = "ftp://";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres";
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(12, 122);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(294, 134);
            this.liste.TabIndex = 3;
            // 
            // dosyalar
            // 
            this.dosyalar.FormattingEnabled = true;
            this.dosyalar.HorizontalScrollbar = true;
            this.dosyalar.Location = new System.Drawing.Point(310, 23);
            this.dosyalar.Name = "dosyalar";
            this.dosyalar.Size = new System.Drawing.Size(359, 199);
            this.dosyalar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gönderilecek Dosyalar                                                            " +
    "                      ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tümünü Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDosyaEkle
            // 
            this.bDosyaEkle.Location = new System.Drawing.Point(569, 232);
            this.bDosyaEkle.Name = "bDosyaEkle";
            this.bDosyaEkle.Size = new System.Drawing.Size(100, 23);
            this.bDosyaEkle.TabIndex = 11;
            this.bDosyaEkle.Text = "Dosya Ekle";
            this.bDosyaEkle.UseVisualStyleBackColor = true;
            this.bDosyaEkle.Click += new System.EventHandler(this.bDosyaEkle_Click);
            // 
            // tDosya
            // 
            this.tDosya.Location = new System.Drawing.Point(12, 263);
            this.tDosya.Name = "tDosya";
            this.tDosya.Size = new System.Drawing.Size(213, 20);
            this.tDosya.TabIndex = 8;
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(231, 262);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(75, 23);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.button6_Click);
            // 
            // bKapat
            // 
            this.bKapat.Location = new System.Drawing.Point(312, 262);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(357, 23);
            this.bKapat.TabIndex = 12;
            this.bKapat.Text = "K A P A T";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click_1);
            // 
            // Adres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(675, 295);
            this.Controls.Add(this.bKapat);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.tDosya);
            this.Controls.Add(this.bDosyaEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dosyalar);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.P1);
            this.Name = "Adres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adres";
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.ListBox dosyalar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bDosyaEkle;
        private System.Windows.Forms.TextBox tDosya;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bKapat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}