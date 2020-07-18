using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Net;

namespace IsimSoftwareSimpleFTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string yol = Application.StartupPath + "\\adresler";
        ArrayList L = new ArrayList();     
        
        void yenile()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(yol);
                foreach (FileInfo f in di.GetFiles())
                    if (f.Extension.ToLower() == ".adrl") liste.Items.Add(f.Name);
            }
            catch (Exception) { }
        }
        
        void yukle()
        {
            if (liste.SelectedIndex == -1) return;
            string dsy = liste.Text;
            adresler.Items.Clear();
                        
            AdresKayit ak = new AdresKayit(dsy, yol);
            ak.Yukle();
            adresler.Items.Add(ak.Adres1);

            for (int i = 0; i < ak.Dosyalar.Length; i++)
            {
                dosyalar.Items.Add(ak.Dosyalar[i]);
            }                
        }
        private void bAdres_Click(object sender, EventArgs e)
        {
            liste.Items.Clear();
            dosyalar.Items.Clear();
            adresler.Items.Clear();
            Adres adr = new Adres("","");
            adr.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste.Items.Clear();
            dosyalar.Items.Clear();
            adresler.Items.Clear();
            yenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex == -1) return;
            DialogResult result = MessageBox.Show(liste.Text + "\r\nListeyi silmek istediginizden eminmisiniz ?", "FTP_AHS",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No) return;
            try
            {
                File.Delete(yol + "\\" + liste.Text);
                liste.Items.Clear();
                dosyalar.Items.Clear();
                adresler.Items.Clear();
                yenile();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        bool GonderFtp(string kaynakDosya, string HedefUrl, string user, string pass)
        {
            Stream yazilan = null;
            FileStream okunan = null;
            FtpWebResponse cevap = null;

            try
            {
                Uri url = new Uri(HedefUrl);
                if (url.Scheme != Uri.UriSchemeFtp)
                {
                    MessageBox.Show("Verilen ftp adres formatý yanlýþ..");
                    //lock (this)
                    //{
                    //    ck.LogHataKaydet("Hata GonderFtp...\r\nUri formati yanlis");
                    //}
                    return false;
                }
                FtpWebRequest istek =
                    (FtpWebRequest)WebRequest.Create(url);
                istek.Method = WebRequestMethods.Ftp.UploadFile;
                istek.Credentials = new NetworkCredential(user, pass);

                istek.Proxy = null;

                yazilan = istek.GetRequestStream();
                okunan = File.OpenRead(kaynakDosya);
               
               prg.Maximum =(int) okunan.Length; 

                byte[] buffer = new byte[1024];
                int bytesRead;
                int toplam = 0;
                while (true)
                {
                   
                    bytesRead = okunan.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                        break;
                    toplam += bytesRead;
                    prg.Value =toplam ;
                    yazilan.Write(buffer, 0, bytesRead);
                }
               
                yazilan.Close();
                prg.Value = 0;
                
                cevap =
                    (FtpWebResponse)istek.GetResponse();
               lDosya.Text = "Dosyalar gönderildi..." + cevap.StatusDescription;

                //ck.LogKaydet (cevap.StatusDescription,HedefUrl,false );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ck.LogHataKaydet("Hata UygulaGonderFTP...\r\n" + HedefUrl + "\r\n" + ex.Message);

            }
            finally
            {
                if (cevap != null)
                    cevap.Close();
                if (okunan != null)
                    okunan.Close();
                if (yazilan != null)
                    yazilan.Close();
            }
            return true;
        }
       
        private void bGonder_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex == -1) return;
           
            string dsy = liste.Text;
        
            AdresKayit ak;
            for (int i = 0; i < liste.CheckedItems.Count; i++)
            {
                dsy = liste.CheckedItems[i].ToString();
                ak = new AdresKayit(dsy, yol);
                ak.Yukle();

                for (int j = 0; j < ak.Dosyalar.Length; j++)
                {
                    string KaynakDosya = ak.Dosyalar[j].ToString();
                    string HedefURL = ak.Adres1 + "//" + Path.GetFileName(KaynakDosya);
                    GonderFtp(KaynakDosya, HedefURL, ak.User1, ak.Pass1);
                }
            }
        }
        private void liste_DoubleClick(object sender, System.EventArgs e)
        {
            lDosya.Text = "Dosya Gönderme Durumu";
            dosyalar.Items.Clear();
            adresler.Items.Clear();
            yukle();
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex == -1) return;

            dosyalar.Items.Clear();
            adresler.Items.Clear();
            Adres adr = new Adres(liste.Text);
            liste.Items.Clear();
            adr.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            liste.Items.Clear();
            dosyalar.Items.Clear();
            adresler.Items.Clear();
            yenile();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Hepsi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < liste.Items.Count; i++)
            {
                liste.SetItemChecked(i,true);
            }
        }

    }
}