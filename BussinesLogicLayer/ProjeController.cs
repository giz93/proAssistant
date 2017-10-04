using DataAccessLayer;
using Entity.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public static class ProjeController
    {
       


        public static string Ekle(Proje p)
        {
            try
            {
                
                var p2 = new SqlParameter("projeadi", p.ProjeAdi);
                var p3 = new SqlParameter("isintanimi", p.IsinTanimi);
                var p4 = new SqlParameter("baslamatarihi", p.BaslamaTarihi);
                var p5 = new SqlParameter("bitistarihi", p.BitisTarihi);
                var p6 = new SqlParameter("gecensure", p.GecenSure);
                var p7 = new SqlParameter("istekmi", p.IstekMi);
                var p8 = new SqlParameter("aciklama", p.Aciklama);
                var p9= new SqlParameter("developerid", p.DeveloperID);
                var p10 = new SqlParameter("bittimi", p.BittiMi);
                Veri.Execute("INSERT INTO tbl_Proje (ProjeAdi,IsinTanimi,BaslamaTarihi,BitisTarihi, GecenSure,IstekMi, Aciklama,DeveloperID,BittiMi) VALUES (@projeadi, @isintanimi,@baslamatarihi,@bitistarihi,@gecensure,@istekmi,@aciklama,@developerid,@bittimi)", p2, p3,p4,p5, p6, p7, p8, p9,p10);
                return "Başarıyla eklendi.";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message;
            }
        }
        public static string Sil(Proje p)
        {
            try
            {
                var p1 = new SqlParameter("id",p.ProjeID);
                Veri.Execute("DELETE FROM tbl_Proje WHERE ProjeID= @id", p1);
                return "Başarıyla silindi";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message;
            }
        }
        public static DataTable ProjeGetir(DateTime basla, DateTime bitis)
        {
            var p1 = new SqlParameter("basla", basla);
            var p2 = new SqlParameter("bitis", bitis);
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BaslamaTarihi >= @basla AND BitisTarihi<= @bitis AND GecenSure !=0", p1,p2);
            return dt;
        }
        public static string Guncelle(Proje p)
        {
            try
            {
                var p1 = new SqlParameter("projeadi", p.ProjeAdi);
                var p2 = new SqlParameter("isintanimi", p.IsinTanimi);
                var p3 = new SqlParameter("basla", p.BaslamaTarihi);
                var p4 = new SqlParameter("bitis", p.BitisTarihi);
                var p5 = new SqlParameter("sure", p.GecenSure);
                var p6 = new SqlParameter("istekmi", p.IstekMi);
                var p7 = new SqlParameter("aciklama", p.Aciklama);
                var p8 = new SqlParameter("deveid", p.DeveloperID);
                var p9 = new SqlParameter("id", p.ProjeID);
                var p10 = new SqlParameter("bittimi", p.BittiMi);
                Veri.Execute("UPDATE tbl_Proje SET ProjeAdi=@projeadi, IsinTanimi=@isintanimi,BaslamaTarihi=@basla,BitisTarihi=@bitis, GecenSure=@sure,IstekMi=@istekmi, Aciklama=@aciklama,DeveloperID=@deveid, BittiMi= @bittimi WHERE ProjeID=@id", p1,p2,p3,p4,p5,p6,p7,p8,p10,p9);
                return "Başarıyla güncellendi";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message;
            }
        }
        public static DataTable DevamProjeler()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BittiMi = 'false' AND GecenSure != 0");
            return dt;
        }
        public static DataTable BitmisProjeler()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BittiMi = 'true' AND GecenSure != 0");
            return dt;
        }
        public static DataTable BitmisProjeler(int id)
        {
            var p1 = new SqlParameter("id", id);
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BittiMi = 'true' AND DeveloperID=@id",p1);
            return dt;
        }
        public static DataTable AtanmamısProjeler()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BaslamaTarihi='1753-2-1' AND BitisTarihi='1753-2-1' AND GecenSure = 0 AND BittiMi='False'");
            return dt;
        }
        public static DataTable AtanmısProjeler(int id)
        {
            var p1 = new SqlParameter("id", id);
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BaslamaTarihi !='1753-2-1' AND BitisTarihi !='1753-2-1' AND GecenSure= 0 AND DeveloperID=@id", p1);
            return dt;
        }
        public static DataTable ToDoProje(int id)
        {
            var p1 = new SqlParameter("tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            var p2 = new SqlParameter("id", id);
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE BaslamaTarihi >@tarih AND GecenSure != 0 AND DeveloperID=@id",p1,p2);
            return dt;
        }
        public static DataTable DoingProje(int id)
        {
            var p1 = new SqlParameter("tarih", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            var p2 = new SqlParameter("id", id);
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE GecenSure != 0  AND BittiMi='False' AND BaslamaTarihi <=@tarih AND @tarih<=BitisTarihi AND DeveloperID=@id ", p1, p2);
            return dt;
        }
        public static DataTable Reddedilenler()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Proje WHERE GecenSure = 0  AND BittiMi='True' AND BaslamaTarihi='1753-2-1' AND BitisTarihi='1753-2-1' AND DeveloperID =0");
            return dt;
        }

        public static Proje ProjeGetir(int id)
        {
            var p1 = new SqlParameter("id", id);
            DataTable dt = Veri.GetDataTable("SELECT TOP 1 * FROM tbl_Proje WHERE ProjeID=@id",p1);
            Proje p = new Proje();
            foreach (DataRow item in dt.Rows)
            {
                p.ProjeAdi = item["ProjeAdi"].ToString();
                p.IsinTanimi = item["IsinTanimi"].ToString();
                p.BaslamaTarihi = (DateTime)item["BaslamaTarihi"];
                p.BitisTarihi = (DateTime)item["BitisTarihi"];
                p.GecenSure = (int)item["GecenSure"];
                p.Aciklama = item["Aciklama"].ToString();
                p.DeveloperID = (int)item["DeveloperID"];
                p.IstekMi = (bool)item["IstekMi"];
                p.BittiMi = (bool)item["BittiMi"];
                p.ProjeID = id;
            }
            return p;
           
        }
        public static List<Kullanici> DeveloperGetir(string ad)
        {
            List<Kullanici> liste = new List<Kullanici>();
            var p1 = new SqlParameter("ad", ad);
            DataTable dt = Veri.GetDataTable("SELECT k.AdSoyad FROM tbl_Proje p INNER JOIN tbl_Kullanici k ON k.KullaniciID = p.DeveloperID WHERE ProjeAdi =@ad GROUP BY k.AdSoyad",p1);
            foreach (DataRow item in dt.Rows)
            {
                Kullanici k = new Kullanici();
                k.AdSoyad = item["AdSoyad"].ToString();
                liste.Add(k);
            }
            return liste;
        }
      
    }
}
