using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adı = "Engin";
            musteri1.Soyadı = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id= "2"
            musteri2.MusteriNo = "1233577899951";
            musteri2.SirketAdı = "kodlama.io";
            musteri2.VergiNo = "1593574565";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri2);


        }
    }
}
