using BussinesLogicLayer;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (this.Text == "UyeEkle")
            {
                Kullanici k = new Kullanici();
                k.AdSoyad = txt_AdSoyad.Text;
                k.EPosta = txt_Mail.Text;
                k.Sifre = Guid.NewGuid().ToString().Substring(0, 5);
                if (comboBox1.SelectedIndex == 0)
                    k.Yetki = Yetki.Developer;
                else if (comboBox1.SelectedIndex == 1)
                    k.Yetki = Yetki.Musteri;
                var msj = KullaniciController.UyeEkle(k);
                msj += "Şifreniz: " + k.Sifre;
                MessageBox.Show(msj);
            }
            else if(this.Text == "Kullanıcı Düzenle")
            {
                Kullanici k = KullaniciController.KullaniciGetir(TumKullanicilar.secilen.KullaniciID);
                k.AdSoyad = txt_AdSoyad.Text;
                k.EPosta = txt_Mail.Text;
                k.Sifre = Guid.NewGuid().ToString().Substring(0, 5);
                if (comboBox1.SelectedIndex == 0)
                    k.Yetki = Yetki.Developer;
                else if (comboBox1.SelectedIndex == 1)
                    k.Yetki = Yetki.Musteri;
                var msj = KullaniciController.Duzenle(k);
                msj += "Şifreniz: " + k.Sifre;
                MessageBox.Show(msj);
                this.Close();
                Application.OpenForms["TumKullanicilar"].Activate();
            }
            Program.EkranGuncelle();

        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            lbl_Kadi.Text = "Merhaba " + KullaniciController.girisYapan.AdSoyad;
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();
            if(this.Text== "Kullanıcı Düzenle")
            {
                Kullanici k = KullaniciController.KullaniciGetir(TumKullanicilar.secilen.KullaniciID);
                txt_AdSoyad.Text = k.AdSoyad;
                txt_Mail.Text = k.EPosta;
                if (k.Yetki == Yetki.Developer)
                    comboBox1.SelectedIndex = 0;
                else
                    comboBox1.SelectedIndex = 1;
            }
        }
    }
}
