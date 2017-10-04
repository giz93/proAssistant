using DataAccessLayer;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer
{
    public class KullaniciController
    {
        public static Kullanici girisYapan;

        public static string GirisYap(string eposta, string sifre)
        {
            var p1 = new SqlParameter("eposta", eposta);
            var p2 = new SqlParameter("sifre", sifre);
            var dt = Veri.GetDataTable("SELECT * FROM tbl_Kullanici WHERE Eposta=@eposta AND Sifre=@sifre", p1, p2);
            if (dt.Rows.Count == 0)
                return "Hatalı giriş yaptınız";
            else
            {
                girisYapan = new Kullanici();
                girisYapan.AdSoyad = dt.Rows[0]["AdSoyad"].ToString();
                girisYapan.EPosta = dt.Rows[0]["Eposta"].ToString();
                girisYapan.KullaniciID = (int)dt.Rows[0]["KullaniciID"];
                girisYapan.Yetki = (Yetki)dt.Rows[0]["Yetki"];
                girisYapan.Yogunluk = (int)dt.Rows[0]["Yogunluk"];
                return "Giriş başarılı";
            }
        }
        public static string KayitOl(Kullanici k)
        {
            try
            {
                var p1 = new SqlParameter("adsoyad", k.AdSoyad);
                var p2 = new SqlParameter("eposta", k.EPosta);
                var p3 = new SqlParameter("sifre", k.Sifre);
                Veri.Execute("INSERT INTO tbl_Kullanici (AdSoyad,Eposta,Sifre,Yetki,Yogunluk) VALUES (@adsoyad, @eposta, @sifre,1,0)", p1, p2, p3);
                return "Başarıyla kaydedildi.";
            }
            catch(Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message;
            }
            
        }
        public static string UyeEkle(Kullanici k)
        {
            try
            {
                var p1 = new SqlParameter("adsoyad", k.AdSoyad);
                var p2 = new SqlParameter("eposta", k.EPosta);
                var p3 = new SqlParameter("sifre", k.Sifre);
                var p4 = new SqlParameter("yetki", k.Yetki);
                Veri.Execute("INSERT INTO tbl_Kullanici (AdSoyad,Eposta,Sifre,Yetki,Yogunluk) VALUES (@adsoyad, @eposta, @sifre,@yetki,0)", p1, p2, p3, p4);
                return "Başarıyla kaydedildi.";
            }
            catch(Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message; 
            }
           
        }
        public static string Duzenle(Kullanici k)
        {
            try
            {
                var p1 = new SqlParameter("adsoyad", k.AdSoyad);
                var p2 = new SqlParameter("eposta", k.EPosta);
                var p3 = new SqlParameter("sifre", k.Sifre);
                var p4 = new SqlParameter("yetki", k.Yetki);
                var p5 = new SqlParameter("yog", k.Yogunluk);
                var p6 = new SqlParameter("id", k.KullaniciID);
                Veri.Execute("UPDATE tbl_Kullanici SET AdSoyad=@adsoyad,Eposta= @eposta,Sifre=@sifre, Yetki=@yetki, Yogunluk=@yog WHERE KullaniciID=@id", p1, p2, p3,p4,p5,p6);
                return "Başarıyla güncellendi";
            }
            catch(Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message;
            }
        }
        public static string Sil(Kullanici k)
        {
            try
            {
                var p1 = new SqlParameter("id", k.KullaniciID);
                Veri.Execute("DELETE FROM tbl_Kullanici WHERE KullaniciID= @id",p1);
                return "Başarıyla silindi";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu. " + ex.Message;
            }
        }
        public static DataTable TumDeveloper()
        {
            DataTable dt = Veri.GetDataTable("SELECT AdSoyad, Yogunluk, KullaniciID FROM tbl_Kullanici WHERE Yetki=2 ORDER BY Yogunluk");
            return dt;
        }
        public static DataTable MusteriGetir()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Kullanici WHERE Yetki=3");
            return dt;
        }
        public static DataTable DeveloperGetir()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Kullanici WHERE Yetki=2");
            return dt;
        }
        public static DataTable TumKullanicilar()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Kullanici WHERE Yetki=2 OR Yetki=3");
            return dt;
        }
        public static Kullanici KullaniciGetir(int id)
        {
            var p1 = new SqlParameter("id", id);
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Kullanici WHERE KullaniciID=@id",p1);
            Kullanici k = new Kullanici();
            foreach (DataRow item in dt.Rows)
            {
                k.AdSoyad= item["AdSoyad"].ToString();
                k.EPosta = item["EPosta"].ToString();
                k.KullaniciID =(int) item["KullaniciID"];
                k.Sifre = item["Sifre"].ToString();
                k.Yetki = (Yetki)item["Yetki"];
                k.Yogunluk = (int)item["Yogunluk"];
            }
            return k;
        }
        public static int yoneticiSayisi()
        {
            DataTable dt = Veri.GetDataTable("SELECT * FROM tbl_Kullanici WHERE Yetki=1");
            return dt.Rows.Count;
        }

    }
}
