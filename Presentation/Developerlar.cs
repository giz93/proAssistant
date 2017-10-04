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
    public partial class Developerlar : Form
    {
        public Developerlar()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Developerlar_Load(object sender, EventArgs e)
        {
            DGV_dev.DataSource = KullaniciController.TumDeveloper();
            

            cb_Developer.DataSource = KullaniciController.TumDeveloper();
            cb_Developer.DisplayMember = "AdSoyad";
            cb_Developer.ValueMember = "KullaniciID";

            
            txt_ProjeAdi.Text = Incele.atanacak.ProjeAdi;
            rtxt_Aciklama.Text = Incele.atanacak.Aciklama;
        }

        private void DGV_dev_DoubleClick(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Text = DGV_dev.SelectedRows[0].Cells["AdSoyad"].Value.ToString();
            flowLayoutPanel2.Controls.Add(l);
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            DGV_Gorev.Rows.Add(txt_Gorevler.Text, cb_Developer.Text, cb_Developer.SelectedValue);
           
        }

        private void btn_Ata_Click(object sender, EventArgs e)
        {
            string Projeadi = Incele.atanacak.ProjeAdi;
            Proje p;
            foreach (DataGridViewRow item in DGV_Gorev.Rows)
            {
                if(item.Cells["DeveloperID"].Value!= null)
                {
                    p = new Proje();
                    p = Incele.atanacak;
                    p.ProjeAdi = Projeadi + " " + item.Cells["Gorevler"].Value.ToString();
                    p.DeveloperID = Convert.ToInt32(item.Cells["DeveloperID"].Value);
                    p.BaslamaTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    p.BitisTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    p.Aciklama +=" " + item.Cells["Gorevler"].Value.ToString();
                    ProjeController.Ekle(p);
                    
                }
            }
            ProjeController.Sil(Incele.atanacak);
            MessageBox.Show("Başarıyla atandı");
            Program.EkranGuncelle("ProjeYonetim");
            this.Close();
            Application.OpenForms["Incele"].Close();
        }
        
    }
}
