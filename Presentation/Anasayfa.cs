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
    public partial class Anasayfa : Form,IGuncelleyebilme
    {
        public static Proje incelenen { get; set; }

        public static Proje secilen { get; set; }
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Profil_Click(object sender, EventArgs e)
        {
            new ProfiliDuzenle().Show();
        }

        private void btn_incele_Click(object sender, EventArgs e)
        {
            new Incele().Show();
        }

        private void LB_Doing_DoubleClick(object sender, EventArgs e)
        {
            if (KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Developer)
            {
                Proje p = ProjeController.ProjeGetir((int)LB_Doing.SelectedValue);
                secilen = p;
                new BitisOnay().Show();
            }
            else if(KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Musteri)
            {
                Proje p = ProjeController.ProjeGetir(((Proje)LB_Doing.SelectedItem).ProjeID);
                secilen = p;
                new Incele().Show();

            }
        }

        public void LB_Gorevler_DoubleClick(object sender, EventArgs e)
        {
            Proje p = ProjeController.ProjeGetir((int)LB_Gorevler.SelectedValue);
            incelenen = p;
            new Incele().Show();
        }

        private void LB_ToDo_DoubleClick(object sender, EventArgs e)
        {
            if (KullaniciController.girisYapan.Yetki == Entity.Models.Yetki.Musteri)
            {
                LB_Doing.DisplayMember = "ProjeAdi";
                LB_Doing.ValueMember = "ProjeID";
                Proje p = ProjeController.ProjeGetir((int)LB_ToDo.SelectedValue);
                LB_Doing.Items.Add(p);
                //LB_ToDo.SelectedValue = -1;
            }
        }

        private void Anasayfa_Activated(object sender, EventArgs e)
        {

            Guncelleme();
        }

        public void Guncelleme()
        {

            lbl_Kadi.Text = "Merhaba " + KullaniciController.girisYapan.AdSoyad;
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();
                

            if (KullaniciController.girisYapan.Yetki == Yetki.Developer)
            {
                lbl_Musteri.Visible = false;
                LB_Gorevler.DataSource = ProjeController.AtanmısProjeler(KullaniciController.girisYapan.KullaniciID);
                LB_Gorevler.DisplayMember = "ProjeAdi";
                LB_Gorevler.ValueMember = "ProjeID";

                LB_ToDo.DataSource = ProjeController.ToDoProje(KullaniciController.girisYapan.KullaniciID);
                LB_ToDo.DisplayMember = "ProjeAdi";
                LB_ToDo.ValueMember = "ProjeID";

                LB_Doing.DataSource = ProjeController.DoingProje(KullaniciController.girisYapan.KullaniciID);
                LB_Doing.DisplayMember = "ProjeAdi";
                LB_Doing.ValueMember = "ProjeID";

                LB_Done.DataSource = ProjeController.BitmisProjeler(KullaniciController.girisYapan.KullaniciID);
                LB_Done.DisplayMember = "ProjeAdi";
                LB_Done.ValueMember = "ProjeID";
            }
            else if (KullaniciController.girisYapan.Yetki == Yetki.Musteri)
            {
                lbl_SonDurum.Text = "Reddedilenler";
                lbl_developer.Visible = false;

                LB_Gorevler.DataSource = ProjeController.Reddedilenler();
                LB_Gorevler.DisplayMember = "ProjeAdi";
                LB_Gorevler.ValueMember = "ProjeID";

                LB_ToDo.DataSource = ProjeController.BitmisProjeler();
                LB_ToDo.DisplayMember = "ProjeAdi";
                LB_ToDo.ValueMember = "ProjeID";

                try
                {
                    Proje p1 = ProjeController.ProjeGetir(Incele.atanacak.ProjeID);

                    LB_Done.DisplayMember = "ProjeAdi";
                    LB_Done.ValueMember = "ProjeID";
                    LB_Done.Items.Add(p1);

                    LB_Doing.Items.Remove(LB_Doing.SelectedItem);
                }
                catch { }
            }
        }
    }
}
