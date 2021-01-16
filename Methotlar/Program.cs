using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "Elma";
            double fıyat = 15;
            string acıklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fıyat = 15;
            urun1.Acıklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fıyat = 85;
            urun2.Acıklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fıyat);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("----------------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
