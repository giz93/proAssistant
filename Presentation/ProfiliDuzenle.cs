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
    public partial class ProfiliDuzenle : Form
    {
        public ProfiliDuzenle()
        {
            InitializeComponent();
        }

        private void ProfiliDuzenle_Load(object sender, EventArgs e)
        {
            txt_AdSoyad.Text = KullaniciController.girisYapan.AdSoyad;
            txt_Mail.Text = KullaniciController.girisYapan.EPosta;
            txt_Sifre.Text = KullaniciController.girisYapan.Sifre;
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (txt_Sifre.Text != txt_SifreTekrar.Text)
                MessageBox.Show("Şifreler eşleşmedi");
            else
            {
                Kullanici k = KullaniciController.KullaniciGetir(KullaniciController.girisYapan.KullaniciID);
                k.AdSoyad = txt_AdSoyad.Text;
                k.EPosta = txt_Mail.Text;
                k.Sifre = txt_Sifre.Text;
                var msj = KullaniciController.Duzenle(k);
                MessageBox.Show(msj);
            }
           
        }
    }
}
