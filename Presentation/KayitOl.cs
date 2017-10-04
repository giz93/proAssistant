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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.AdSoyad = txt_AdSoyad.Text;
            k.EPosta = txt_Mail.Text;
            k.Sifre = txt_Sifre.Text;
            if (txt_Sifre.Text == txt_SifreTekrar.Text)
            {
                var msj = KullaniciController.KayitOl(k);
                MessageBox.Show(msj);
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                        item.ResetText();
                }
                KullaniciController.girisYapan = k;
                new ProjeYonetim().Show();
                this.Hide();
                Application.OpenForms["Giris"].Hide();
            }
            else
                MessageBox.Show("Şifreler eşleşmedi.");
        }
    }
}
