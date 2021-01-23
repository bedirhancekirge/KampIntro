using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> urun = new Dictionary<int, string>();

            urun1.Add(134, "Tolga Demirer");
            urun2.Add(158, "Ümit Özkan");
            urun3.Add(115, "Kadir Aydemir");
            urun4.Add(174, "Cemal Çiftçi");

            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }
    }
}
