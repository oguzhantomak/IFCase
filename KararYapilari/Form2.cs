﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";
            if (username == txtGelenDeger1.Text)
            {
                if (password == txtGelenDeger2.Text)
                {
                    result = "Tebrikler giriş yaptınız !";
                }
                else
                {
                    result = "Şifreniz Yanlış";
                }
                txtGelenDeger2.Clear();

            }
            else
            {
                result = "Kullanıcı Adınız Yanlış !";
            }
            txtGelenDeger1.Clear();
            MessageBox.Show(result);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";

            if (username == txtGelenDeger1.Text && password == txtGelenDeger2.Text)
            {
                result = "Tebrikler. Giriş Yaptınız !";
            }
            else
            {
                result = "Başarısız giriş !";
            }
            txtGelenDeger1.Clear();
            txtGelenDeger2.Clear();
            MessageBox.Show(result);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(txtGelenDeger1.Text);
            string notres = "Harf Notunuz : ";

            if (not >= 0 && not <= 100)
            {
                if (not <= 30)
                {
                    notres += "FF";
                }
                else if (not <= 50)
                {
                    notres += "DD";
                }
                else if (not <= 70)
                {
                    notres += "CC";
                }
                else if (not <= 85)
                {
                    notres += "BB";
                }
                else
                {
                    notres += "AA";
                }
                MessageBox.Show(notres);
            }
            else
            {
                MessageBox.Show("0-100 arasında not değeri giriniz !");
            }



            //switch (not)
            //{
            //    case 1:
            //        MessageBox.Show("Not: FF");
            //        break;
            //    case 2:
            //        MessageBox.Show("Not: DD");
            //        break;
            //    case 3:
            //        MessageBox.Show("Not: BB");
            //        break;
            //    case 4:
            //        MessageBox.Show("Not: AA");
            //        break;

            //}
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            string urunAdi = txtGelenDeger1.Text.ToLower();
            string mesaj = "Aradığınız ürün ";
            //If veya switch ile de yapılabilir.

            if (urunAdi == "domates" || urunAdi == "biber" || urunAdi == "patlıcan")
            {
                mesaj += "Sebze reyonundadır";
            }
            else if (urunAdi == "diş macunu" || urunAdi == "parfüm" || urunAdi == "şampuan")
            {
                mesaj += "Kozmetik reyonundadır.";
            }
            else if (urunAdi == "cep telefonu" || urunAdi == "bilgisyar" || urunAdi == "ses sistemi")
            {
                mesaj += "Teknoloji reyonundadır.";
            }
            else
            {
                mesaj += " Bizde bulunmamaktadır.";
            }
            MessageBox.Show(mesaj);
            txtGelenDeger1.Clear();


        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            try
            {
                double siparisAdet = Convert.ToDouble(txtGelenDeger1.Text);
                double birimFiyat = 5;
                double toplamFiyat = siparisAdet * birimFiyat;

                double indirimMiktar;
                double sonFiyat;
                if (siparisAdet > 0)
                {
                    if (siparisAdet < 20)
                    {

                        indirimMiktar = toplamFiyat * 0.05;
                        sonFiyat = toplamFiyat - indirimMiktar;

                        //MessageBox.Show("Toplam Sipariş Adedi: " + siparisAdet + "\nBirim Fiyat: " + birimFiyat + "\nToplam Tutar:" + toplamFiyat + "\nYapılan İnidirim Oranı: %5 " + "\nYapılan İndirim Miktarı: " + indirimMiktar + "\nÖdemeniz gereken tutar: " + sonFiyat);

                        MessageBox.Show(string.Format(
@"Toplam Siariş Adedi: {0} 
Birim Fiyat: {1}
Toplam Tutar: {2} 
Yapılan İndirim Oranı: %5 
Yapılan İndirim Miktarı: {3}
Ödemeniz Gereken Tutar: {4}", siparisAdet, birimFiyat, toplamFiyat, indirimMiktar, sonFiyat));
                        txtGelenDeger1.Clear();

                    }
                    else if (siparisAdet > 20 && siparisAdet <= 50)
                    {
                        indirimMiktar = toplamFiyat * 0.10;
                        sonFiyat = toplamFiyat - indirimMiktar;

                        //MessageBox.Show("Toplam Sipariş Adedi: " + siparisAdet + "\nBirim Fiyat: " + birimFiyat + "\nToplam Tutar:" + toplamFiyat + "\nYapılan İnidirim Oranı: %10 " + "\nYapılan İndirim Miktarı: " + indirimMiktar + "\nÖdemeniz gereken tutar: " + sonFiyat);

                        MessageBox.Show(string.Format(
@"Toplam Siariş Adedi: {0} 
Birim Fiyat: {1}
Toplam Tutar: {2} 
Yapılan İndirim Oranı: %10 
Yapılan İndirim Miktarı: {3}
Ödemeniz Gereken Tutar: {4}", siparisAdet, birimFiyat, toplamFiyat, indirimMiktar, sonFiyat));
                        txtGelenDeger1.Clear();
                    }
                    else if (siparisAdet > 50 && siparisAdet <= 100)
                    {
                        indirimMiktar = toplamFiyat * 0.15;
                        sonFiyat = toplamFiyat - indirimMiktar;

                        //MessageBox.Show("Toplam Sipariş Adedi: " + siparisAdet + "\nBirim Fiyat: " + birimFiyat + "\nToplam Tutar:" + toplamFiyat + "\nYapılan İnidirim Oranı: %15 " + "\nYapılan İndirim Miktarı: " + indirimMiktar + "\nÖdemeniz gereken tutar: " + sonFiyat);

                        MessageBox.Show(string.Format(
@"Toplam Siariş Adedi: {0} 
Birim Fiyat: {1}
Toplam Tutar: {2} 
Yapılan İndirim Oranı: %15 
Yapılan İndirim Miktarı: {3}
Ödemeniz Gereken Tutar: {4}", siparisAdet, birimFiyat, toplamFiyat, indirimMiktar, sonFiyat));
                        txtGelenDeger1.Clear();
                    }
                    else if (siparisAdet > 100)
                    {
                        indirimMiktar = toplamFiyat * 0.25;
                        sonFiyat = toplamFiyat - indirimMiktar;

                        //MessageBox.Show("Toplam Sipariş Adedi: " + siparisAdet + "\nBirim Fiyat: " + birimFiyat + "\nToplam Tutar:" + toplamFiyat + "\nYapılan İnidirim Oranı: %25 " + "\nYapılan İndirim Miktarı: " + indirimMiktar + "\nÖdemeniz gereken tutar: " + sonFiyat);

                        MessageBox.Show(string.Format(
@"Toplam Siariş Adedi: {0} 
Birim Fiyat: {1}
Toplam Tutar: {2} 
Yapılan İndirim Oranı: %25 
Yapılan İndirim Miktarı: {3}
Ödemeniz Gereken Tutar: {4}", siparisAdet, birimFiyat, toplamFiyat, indirimMiktar, sonFiyat));
                        txtGelenDeger1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen 0'dan büyük bir sipariş miktarı giriniz !");
                }
            }
            catch
            {
                MessageBox.Show("Sayısal ifade giriniz !");
                txtGelenDeger1.Clear();
            }


        }
    }
}
