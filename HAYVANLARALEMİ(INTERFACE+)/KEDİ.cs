using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYVANLARALEMİ_INTERFACE__
{
    public class KEDİ:HAYVANLAR,INT_hareketetme,INT_sescıkarma
    {

        public string dortayaklı { get; set; }
        

        public void hareketedebilir()
        {
            Console.WriteLine("hareket ederek avlanır");
        }

        public void sescıkardım()
        {
            Console.WriteLine("ses çıkararak iletişim kurar");
        }
    }
}
