using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYVANLARALEMİ_INTERFACE__
{
    public class KUS:HAYVANLAR,INT_sescıkarma,INT_hareketetme
    {
        public string yırtıcı { get; set; }
        public string kanatlıhayvan { get; set; }

        public void hareketedebilir()
        {
            Console.WriteLine("havada süzülerek avlanıp saklanabilirler");
        }

        public void sescıkardım()
        {
            Console.WriteLine("iletişim için ses kullanırlar");
        }
    }
}
