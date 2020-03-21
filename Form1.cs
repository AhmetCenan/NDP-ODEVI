/***********************************************************************************************
**                                      SAKARYA ÜNİVERSİTESİ
**                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                      BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                      2019-2020 BAHAR DÖNEMİ
**
**                                      ÖDEV NUMARASI ........:
**                                      ÖĞRENCİ ADI Ahmet Cenan Akdoğan:
**                                      ÖĞRENCİ NUMARASI B191200040:
**                                      DERSİN ALINDIĞI GRUP...:
***********************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPD_Deneme
{
    public partial class Form1 : Form
    {
        int index,sayac;
        int Hesap (int dakika)
        {
            //Fiyatlandırma burada oluyor...
            //0-2 saat arası 5TL.
            //2-5 saat arası 15TL.
            //Süresiz 30TL.
            int fiyat;
            if (dakika < 120)
            {
                fiyat = 5;
            }
            else if (dakika < 300)
            {
                fiyat = 15;
            }
            else
            {
                fiyat = 30;
            }
            return fiyat;
        }
        int deger(string fiyat,int fiyatint)
        {
            int fiyat1 = Convert.ToInt32(fiyat);
            return (fiyat1 + fiyatint);
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaka.Text))
                return;
            listAraclar.Items.Add(txtPlaka.Text + "...: ");
            listPlaka2.Items.Add(txtPlaka.Text + "...: ");
            listSure.Items.Add(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
            txtPlaka.Clear();
            txtPlaka.Focus();
            sayac++;
            lblSayac.Text = sayac.ToString();
            
        }
        //Otoparktan çıkan arabaları listeden çıkartıyoruz.
        private void BtnFiyatgor_Click(object sender, EventArgs e)
        {

            index = listAraclar.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Plaka Seçilmedi");
            }
            else
            {


                listAraclar.Items.RemoveAt(index);
                listSure.Items.RemoveAt(index);
                sayac--;
                if (sayac == 0)
                {
                    lblSayac.Text = "-";
                }
                else
                {
                    lblSayac.Text = sayac.ToString();
                }
            }

        }

        private void BtnFiyat_Click(object sender, EventArgs e)
        {
            int hesap = Hesap(Convert.ToInt32(txtSure.Text));
            lblFiyat.Text = hesap.ToString()+" TL";
            lblTOPLAM.Text=deger(lblTOPLAM.Text,hesap).ToString();
        }

        private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece sayı girişi için.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
