namespace HAYVANLARALEMİ_INTERFACE__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KEDİ k1=new KEDİ();
            k1.avlanma = "avlanır";
            k1.dortayaklı = "dörtayaklıdır";
            k1.yas = 4;
            k1.üreme = "üreyerek çoğalırlar";
            ///k1.hareketedebilir();
            ///k1.sescıkardım();
            
            KUS k2=new KUS();
            k2.kanatlıhayvan = "kanatlı hayvandır.";
            k2.avlanma = "havadan avlanır";
            k2.yırtıcı = "yırtıcıdır.";
            k2.yas = 23;
            ///k2.hareketedebilir();
            ///k2.sescıkardım();
            
            YILAN y1=new YILAN();
            y1.surungendır = "sürüngendir";
            y1.üreme = "yumurtlayarak ürerler";
            y1.büyüme = "büyür gelişir";
            y1.yas= 24; 
            ///y1.hareketedebilir();
            ///y1.sescıkardım();



        }
    }
}