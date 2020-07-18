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
using System.Diagnostics;

namespace IsimSoftwareSimpleFTP
{
    public partial class Adres : Form
    {
        public Adres(string file,string a)
        {
            InitializeComponent();
            tDosya.Text = file;
            if (file != "") yuklenecek = true;
        }
        public Adres(string gelenD)
        {
            InitializeComponent();           
            Duzenle(gelenD);
          //  if (file != "") yuklenecek = true;
        }
              
        bool yuklenecek = false;
        ArrayList L = new ArrayList();
        string yol = Application.StartupPath + "\\adresler";

        void Duzenle(string gelen)
        {            
            string dsy = gelen;

            AdresKayit ak = new AdresKayit(dsy, yol);
            ak.Yukle();

            tDosya.Text = gelen;
            tAdres.Text = ak.Adres1;
            tUser.Text = ak.User1;
            tPass.Text = ak.Pass1;
          
            for (int i = 0; i < ak.Dosyalar.Length; i++)
            {
                dosyalar.Items.Add(ak.Dosyalar[i]);
            }
        }

        void Kaydet()
        {
            if (tDosya.Text.Trim() == "" || L.Count <= 0) return;
            string Dliste = "";
            ArrayList LL = new ArrayList();

            if (tDosya.Text.IndexOf(".") > 0)
                tDosya.Text = tDosya.Text.Substring(0, tDosya.Text.IndexOf("."));

            tDosya.Text += ".adrl";

            LL.AddRange(L);
            if (dosyalar.Items.Count > 0)
            {
                foreach (string str in dosyalar.Items)
                { Dliste += str + ","; }
            }
            if (Dliste.EndsWith(",")) Dliste = Dliste.Remove(Dliste.Length - 1, 1);

            LL.Add(Dliste);
            string dosya = Application.StartupPath + "\\ftp\\" + tDosya.Text.Trim();

            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\ftp"))
                    Directory.CreateDirectory(Application.StartupPath + "\\ftp");

                Stream s = new FileStream(dosya, FileMode.Create);


                BinaryFormatter b = new BinaryFormatter();

                b.Serialize(s, LL);
                s.Close();

                MessageBox.Show(dosya, "Dosya Kaydedildi...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        ArrayList GonDosyalar = new ArrayList();
        private void button6_Click(object sender, EventArgs e)
        {           
            string adr = "";

            if (tDosya.Text.IndexOf(".") > 0)
                tDosya.Text = tDosya.Text.Substring(0, tDosya.Text.IndexOf("."));

            adr = tDosya.Text + ".adrl";
            string yol = Application.StartupPath+"\\adresler";
            if (!Directory.Exists(yol)) Directory.CreateDirectory(yol); 
            AdresKayit ak = new AdresKayit(adr, yol);
            ak.Adres1 = tAdres.Text.Trim();
            ak.User1 = tUser.Text.Trim();
            ak.Pass1 = tPass.Text.Trim();

            ArrayList gd = new ArrayList();
            gd.AddRange(GonDosyalar);

            if(dosyalar.Items.Count>0)
            {
                foreach (string str in dosyalar.Items)
                { ak.GonDos1 += str + ","; }
            }
            if (ak.GonDos1.EndsWith(",")) ak.GonDos1 = ak.GonDos1.Remove(ak.GonDos1.Length - 1, 1);
            
            ak.Kaydet();

            MessageBox.Show(ak.Yazildi.ToString());
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            liste.Items.Add(tAdres.Text.Trim());
            string str = tAdres.Text.Trim() + "," + tUser.Text.Trim() + "," + tPass.Text.Trim();
            L.Add(str);
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex == -1) return;
            int index = liste.SelectedIndex;
            liste.Items.RemoveAt(index);
            L.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dosyalar.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dosyalar.SelectedIndex == -1) return;
            dosyalar.Items.RemoveAt(dosyalar.SelectedIndex);
        }

        private void bDosyaEkle_Click(object sender, EventArgs e)
        {
            openFD.Title = "Gonderilecek Dosyalari Seciniz";
            DialogResult result = openFD.ShowDialog();

            if (result == DialogResult.Cancel) return;

            foreach (string str in openFD.FileNames)
                dosyalar.Items.Add(str);
        }

        private void bKapat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}