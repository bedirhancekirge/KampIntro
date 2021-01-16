using System;

namespace DegerVeReferansTıpler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            //sayyı1 ?? 30


            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 10, 20, 30 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            //sayılar1[0] 999


        }
    }
}
