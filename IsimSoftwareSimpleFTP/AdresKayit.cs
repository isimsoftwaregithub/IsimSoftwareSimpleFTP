using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace IsimSoftwareSimpleFTP
{
    class AdresKayit
    {
        string adres1="";	
		string user1="";
		string pass1="";
        string gonDos1 = "";
        public string[] Dosyalar;
		bool yazildi=false;
		
		string anayol="",dosyaismi;


		public AdresKayit()
		{

		}
		public AdresKayit(string Dosyaismi,string AnaYol)
		{
          anayol=AnaYol;
		  dosyaismi=Dosyaismi;
		}
        ~AdresKayit()
		{
         
		}
        		
		public void Kaydet()
		{		

			string toplam=Adres1 + "*" + User1 + "*" + Pass1 + "*" + gonDos1; 
			try
			{                
				StreamWriter sr=File.CreateText(anayol + "\\"+dosyaismi);	          
				sr.Write(toplam);
				sr.Close();
				Yazildi=true;
			}
			catch
			{
				Yazildi=false;
				return;
			}
		}

        public void Yukle()
        {
            try
            {
                StreamReader r = File.OpenText(anayol + "\\" + dosyaismi);
                string ftpUserPass = "";               
                while ((ftpUserPass = r.ReadLine()) != null)
                {
                    string[] gelen = ftpUserPass.Split('*');
                    this.Adres1 = gelen[0];
                    this.User1 = gelen[1];
                    this.Pass1 = gelen[2];

                    string GelenDosyalar = gelen[3];
                    string[] dosya = GelenDosyalar.Split(',');
                    Dosyalar = new string[dosya.Length];
                    for (int i = 0; i < dosya.Length; i++)
                    {
                        this.Dosyalar[i] = dosya[i];
                    }
                }
                Yazildi = true;
                r.Close();
            }
            catch
            {
                Yazildi = false;
                return;
            }
        }

        #region Metodlar
        /// <summary>
        /// geri ismini donderir
        /// </summary>

        public bool Yazildi
        {
            get
            {
                return yazildi;
            }
            set
            {
                yazildi = value;
            }
        }
        public string Adres1
        {
            get
            {
                return adres1;
            }
            set
            {
                adres1 = value;
            }
        }
        
        public string User1
        {
            get
            {
                return user1;
            }
            set
            {
                user1 = value;
            }
        }
        public string Pass1
        {
            get
            {
                return pass1;
            }
            set
            {
                pass1 = value;
            }
        }
        public string GonDos1
        {
            get
            {
                return gonDos1;
            }
            set
            {
                gonDos1 = value;
            }
        }
        
        #endregion
        
    }
}
