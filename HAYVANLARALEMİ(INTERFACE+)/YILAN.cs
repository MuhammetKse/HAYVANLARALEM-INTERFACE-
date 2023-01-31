using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYVANLARALEMİ_INTERFACE__
{
    public class YILAN : HAYVANLAR, INT_hareketetme, INT_sescıkarma
    {
        public string kötügözlerivar { get; set; }
        public string surungendır { get; set; }
        public void hareketedebilir()
        {
            Console.WriteLine("süzülerek hareket ederler");
        }

        public void sescıkardım()
        {
            Console.WriteLine("ses çıkararak titreşimlerle iletişim kurarlar");
        }
    }
}
