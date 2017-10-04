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
    
    public partial class Incele : Form
    {
        public static Proje atanacak { get; set; }

        public Incele()
        {
            InitializeComponent();
        }

        private void Incele_Load(object sender, EventArgs e)
        {
            

            if (KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Developer)
            {
                btn_KabulEt.Visible = false;
                btn_Reddet.Visible = false;

                txt_ProjeAdi.Text = Anasayfa.incelenen.ProjeAdi;
                rtxt_Isintanimi.Text = Anasayfa.incelenen.IsinTanimi;
                if (Anasayfa.incelenen.IstekMi == true)
                    cb_Istek_Bug.Text = "İstek";
                else
                    cb_Istek_Bug.Text = "Bug";
                rtxt_Aciklama.Text += Anasayfa.incelenen.Aciklama;
            }
            else if(KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.ProjeYoneticisi)
            {
                gb_Developer.Visible = false;

                txt_ProjeAdi.Text = ProjeYonetim.incelenen.ProjeAdi;
                rtxt_Isintanimi.Text = ProjeYonetim.incelenen.IsinTanimi;
                if (ProjeYonetim.incelenen.IstekMi == true)
                    cb_Istek_Bug.Text = "İstek";
                else
                    cb_Istek_Bug.Text = "Bug";
                rtxt_Aciklama.Text += ProjeYonetim.incelenen.Aciklama;

            }
            else if (KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Musteri)
            {
                gb_Developer.Visible = false;
                btn_KabulEt.Visible = false;
                btn_Reddet.Text = "Geri Gönder";

                txt_ProjeAdi.Text = Anasayfa.secilen.ProjeAdi;
                rtxt_Isintanimi.Text = Anasayfa.secilen.IsinTanimi;
                if (Anasayfa.secilen.IstekMi == true)
                    cb_Istek_Bug.Text = "İstek";
                else
                    cb_Istek_Bug.Text = "Bug";
                rtxt_Aciklama.Text += Anasayfa.secilen.Aciklama;
            }
        }

        public void btn_KabulEt_Click(object sender, EventArgs e)
        {
            Proje p = ProjeController.ProjeGetir(ProjeYonetim.incelenen.ProjeID);
            p.Aciklama = rtxt_Aciklama.Text;
            atanacak = p;
            Program.EkranGuncelle();
            new Developerlar().Show();
        }

        public void btn_Tamam_Click(object sender, EventArgs e)
        {
            if (KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.ProjeYoneticisi)
            {
                this.Close();
                Application.OpenForms["ProjeYonetim"].Activate();

            }
            else if(KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Developer)
            {
                Proje p = ProjeController.ProjeGetir(Anasayfa.incelenen.ProjeID);
                p.BaslamaTarihi = Convert.ToDateTime(dtp_BaslamaTarihi.Value.ToString());
                p.BitisTarihi = Convert.ToDateTime(dtp_BitisTarihi.Value.ToString());
                p.GecenSure = (int)numUD_BeklenenSure.Value;
                var msj = ProjeController.Guncelle(p);
                Kullanici k = KullaniciController.KullaniciGetir(KullaniciController.girisYapan.KullaniciID);
                k.Yogunluk += (int)numUD_BeklenenSure.Value;
                KullaniciController.Duzenle(k);
                atanacak = p;
                MessageBox.Show(msj);
                Program.EkranGuncelle();
                this.Close();
                Application.OpenForms["Anasayfa"].Activate();
            }
            else if (KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Musteri)
            {
                Proje p = ProjeController.ProjeGetir(Anasayfa.secilen.ProjeID);
                p.ProjeAdi = p.ProjeAdi + " (Checked)";
                ProjeController.Guncelle(p);
                atanacak = p;
                this.Close();
                Application.OpenForms["Anasayfa"].Activate();
            }
        }
        private void btn_Reddet_Click(object sender, EventArgs e)
        {
            if(KullaniciController.girisYapan.Yetki == Yetki.ProjeYoneticisi)
            {
                Proje p = ProjeController.ProjeGetir(ProjeYonetim.incelenen.ProjeID);
                p.BittiMi = true;
                ProjeController.Guncelle(p);
                this.Close();
                MessageBox.Show("Reddedildi.");
                Program.EkranGuncelle();
            }
            else if(KullaniciController.girisYapan.Yetki == Yetki.Musteri)
            {
                Proje p = ProjeController.ProjeGetir(Anasayfa.secilen.ProjeID);
                if (cb_Istek_Bug.Text == "İstek")
                    p.IstekMi = true;
                else
                    p.IstekMi = false;
                p.Aciklama = Anasayfa.secilen.ProjeAdi + " " + rtxt_Aciklama.Text;
                p.BaslamaTarihi = Convert.ToDateTime("1-2-1753");
                p.BitisTarihi = Convert.ToDateTime("1-2-1753");
                p.GecenSure = 0;
                p.BittiMi = false;
                p.DeveloperID = 0;
                var msj = ProjeController.Ekle(p);
                atanacak = p;
                MessageBox.Show(msj);
                ProjeController.Sil(Anasayfa.secilen);
                Program.EkranGuncelle();
                
                this.Close();
                Application.OpenForms["Anasayfa"].Activate();
                
            }
           
        }

    }
}
