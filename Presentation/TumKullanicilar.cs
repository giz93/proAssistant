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
    public partial class TumKullanicilar : Form,IGuncelleyebilme
    {
        public TumKullanicilar()
        {
            InitializeComponent();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            if (cb_Kullanicilar.SelectedIndex == 0)
                dataGridView1.DataSource = KullaniciController.DeveloperGetir();
            else if(cb_Kullanicilar.SelectedIndex == 1)
                dataGridView1.DataSource = KullaniciController.MusteriGetir();
            else
                dataGridView1.DataSource = KullaniciController.TumKullanicilar();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Kullanici k = KullaniciController.KullaniciGetir((int)dataGridView1.SelectedRows[0].Cells["KullaniciID"].Value);
            var msj = KullaniciController.Sil(k);
            MessageBox.Show(msj);
            Guncelleme();
        }

        private void TumKullanicilar_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }
        public  static Kullanici secilen { get; set; }
        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            Kullanici k = KullaniciController.KullaniciGetir((int)dataGridView1.SelectedRows[0].Cells["KullaniciID"].Value);
            secilen = k;
            UyeEkle u = new UyeEkle();
            u.Text = "Kullanıcı Düzenle";
            u.Show();
        }

        public void Guncelleme()
        {
            dataGridView1.DataSource = KullaniciController.TumKullanicilar();
        }

        private void TumKullanicilar_Activated(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
