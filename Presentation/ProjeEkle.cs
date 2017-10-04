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
    public partial class ProjeEkle : Form
    {
        public ProjeEkle()
        {
            InitializeComponent();
        }

        private void ProjeEkle_Load(object sender, EventArgs e)
        {
            lbl_Kadi.Text = "Merhaba " + KullaniciController.girisYapan.AdSoyad;
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();
            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Proje p = new Proje();
            p.ProjeAdi = txt_ProjeAdi.Text;
            p.IsinTanimi = rtxt_IsTanimi.Text;
            if (comboBox1.SelectedIndex == 0)
                p.IstekMi = true;
            else if (comboBox1.SelectedIndex == 1)
                p.IstekMi = false;
            p.Aciklama = rtxt_Aciklama.Text;
            p.DeveloperID = 0;
            p.BaslamaTarihi = Convert.ToDateTime("1-2-1753");
            p.BitisTarihi =Convert.ToDateTime("1-2-1753");
            p.GecenSure = 0;
            p.BittiMi = false;
            var msj = ProjeController.Ekle(p);
            Program.EkranGuncelle("ProjeYonetim");
            MessageBox.Show(msj);
        }
    }
}
