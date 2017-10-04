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
    public partial class BitisOnay : Form
    {
        public BitisOnay()
        {
            InitializeComponent();
        }

        private void BitisOnay_Load(object sender, EventArgs e)
        {
            txt_ProjeAdi.Text = Anasayfa.secilen.ProjeAdi;
        }

        private void btn_Bitir_Click(object sender, EventArgs e)
        {
            Anasayfa.secilen.BittiMi = true;
            Anasayfa.secilen.Aciklama += " " + rtxt_Aciklama.Text;
            var msj = ProjeController.Guncelle(Anasayfa.secilen);
            Kullanici k = KullaniciController.KullaniciGetir(KullaniciController.girisYapan.KullaniciID);
            Proje p = ProjeController.ProjeGetir(Anasayfa.secilen.ProjeID);
            k.Yogunluk = k.Yogunluk- p.GecenSure;
            KullaniciController.Duzenle(k);
            MessageBox.Show(msj);
            Program.EkranGuncelle("Anasayfa");
            this.Close();

        }
    }
}
