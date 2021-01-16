using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorıEtıketı = "Kategorı";
            int ogrencıSayısı = 32000;
            double faızOranı = 1.45;
            bool sıstemeGırısYapmısMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.75;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sıstemeGırısYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategorıEtıketı);


        }




    }
}
