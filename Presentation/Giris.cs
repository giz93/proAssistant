using BussinesLogicLayer;
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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void lbl_KayitOl_Click(object sender, EventArgs e)
        {
            new KayitOl().Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {

            var msj = KullaniciController.GirisYap(txt_KAdi.Text, txt_Sifre.Text);
            KullaniciController.girisYapan.EPosta = txt_KAdi.Text;
            KullaniciController.girisYapan.Sifre = txt_Sifre.Text;

            if (KullaniciController.girisYapan == null)
                MessageBox.Show(msj);
            else
            {
                this.Hide();
                if (KullaniciController.girisYapan.Yetki==Entity.Models.Yetki.ProjeYoneticisi)
                    new ProjeYonetim().Show();
                else
                    new Anasayfa().Show();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            if (KullaniciController.yoneticiSayisi() != 0)
                lbl_KayitOl.Visible = false;
        }
    }
}
