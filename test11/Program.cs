using System;

namespace test11
{
    class Program
    {
        static void Main(string[] args)
        {
            string urun1 = "Ekren kartı";
            string urun2 = "Ana kart";
            string urun3 = "Islemcı";
            string urun4 = "Rem";
            string urun5 = "Guc kaynagı";
            string urun6 = "Cevresel bırımler";


            string[] urunler = new string[] { "Ekren kartı", "Ana kart", "Islemcı", "Rem", "Guc kaynagı", "Cevresel bırımler" };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }


            Console.WriteLine("----Burası bitti----");


            foreach (string urun in urunler)
            {
                Console.WriteLine(urun);
            }
            Console.WriteLine("----Bursaı bitti 2 ----");

            int a = 1;

            while (a < 25)
            {
                Console.WriteLine(a.ToString());
                a = a + 3;
            }
        }
    }
}
