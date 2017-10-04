using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public  class Kullanici
    { 
        public int KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public string EPosta { get; set; }
        public string Sifre { get; set; }
        public Yetki Yetki { get; set; }
        public int Yogunluk { get; set; }
    }
    [Flags]
      public enum Yetki
    {
        ProjeYoneticisi=1,
        Developer=2,
        Musteri=3
    }
}
