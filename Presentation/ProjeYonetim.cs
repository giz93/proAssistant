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
    public partial class ProjeYonetim : Form,IGuncelleyebilme
    {
        public static Proje incelenen {get;set; }

        public ProjeYonetim()
        {
            InitializeComponent();
        }

        private void ProjeYonetim_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }

        private void btn_UyeEkle_Click(object sender, EventArgs e)
        {
            new UyeEkle().Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Profil_Click(object sender, EventArgs e)
        {
            new ProfiliDuzenle().Show();
        }

        private void btn_Incele_Click(object sender, EventArgs e)
        {
            new Incele().Show();
        }

        private void btn_ProjeEkle_Click(object sender, EventArgs e)
        {
            new ProjeEkle().Show();
        }
        

        private void btn_RaporAl_Click(object sender, EventArgs e)
        {
            new RaporAl().Show();
        }

        private void LB_doing_DoubleClick(object sender, EventArgs e)
        {
            flp_Developer.Controls.Clear();
            Proje p = ProjeController.ProjeGetir((int)LB_doing.SelectedValue);
            txt_ProjeAdi.Text = p.ProjeAdi;
            Label l;
            foreach (Kullanici item in ProjeController.DeveloperGetir(p.ProjeAdi))
            {
                l = new Label();
                l.Text = item.AdSoyad;
                flp_Developer.Controls.Add(l);
            }
            lbl_Basla.Text = p.BaslamaTarihi.ToShortDateString();
            lbl_Bitir.Text = p.BitisTarihi.ToShortDateString();
        }

        private void LB_Done_DoubleClick(object sender, EventArgs e)
        {
            Proje p = ProjeController.ProjeGetir((int)LB_Done.SelectedValue);
            txt_BitenProjeAdi.Text = p.ProjeAdi;
            rtxt_Aciklama.Text = p.Aciklama;
            lbl_BitisTarihi.Text = p.BitisTarihi.ToString();
        }
        

        public void LB_IstekBug_DoubleClick(object sender, EventArgs e)
        {
            Proje p = ProjeController.ProjeGetir((int)LB_IstekBug.SelectedValue);
            incelenen = p;
            new Incele().Show();
        }

        private void btn_Kullanicilar_Click(object sender, EventArgs e)
        {
            new TumKullanicilar().Show();
        }

        public void Guncelleme()
        {
            lbl_BitisTarihi.Text = "";
            lbl_Kadi.Text = "Merhaba " + KullaniciController.girisYapan.AdSoyad;
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();

            LB_IstekBug.DataSource = ProjeController.AtanmamısProjeler();
            LB_IstekBug.DisplayMember = "ProjeAdi";
            LB_IstekBug.ValueMember = "ProjeID";

            LB_Done.DataSource = ProjeController.BitmisProjeler();
            LB_Done.DisplayMember = "ProjeAdi";
            LB_Done.ValueMember = "ProjeID";

            LB_doing.DataSource = ProjeController.DevamProjeler();
            LB_doing.DisplayMember = "ProjeAdi";
            LB_doing.ValueMember = "ProjeID";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
