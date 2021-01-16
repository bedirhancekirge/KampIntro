using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egıtmen = "Engın Demırog";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egıtmen = "Kerem";
            kurs2.IzlenmeOranı = 48;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egıtmen = "Bedırhan";
            kurs3.IzlenmeOranı = 88;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "Vu";
            kurs4.Egıtmen = "Tugba";
            kurs4.IzlenmeOranı = 1001;

            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egıtmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egıtmen);
            }

            //Console.WriteLine("Hello World!");
        }

        class Kurs
        {


            public string KursAdı { get; set; }
            public string Egıtmen { get; set; }
            public int IzlenmeOranı { get; set; }


        }
    }
}
