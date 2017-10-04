using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
        }
        public static void EkranGuncelle()
        {
            foreach (var item in Application.OpenForms)
                if (item is IGuncelleyebilme)
                    ((IGuncelleyebilme)item).Guncelleme();
        }
        public static void EkranGuncelle(string FormAdi)
        {
            try
            {
                IGuncelleyebilme f = (IGuncelleyebilme)Application.OpenForms[FormAdi];
                if (f != null & f is IGuncelleyebilme)
                    f.Guncelleme();
            }
            catch { }

        }
    }
}
