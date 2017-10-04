using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Proje
    {
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public string IsinTanimi { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int GecenSure { get; set; }
        public bool IstekMi { get; set; }
        public string Aciklama { get; set; }
        public int DeveloperID { get; set; }
        public bool BittiMi { get; set; }
    }
}
