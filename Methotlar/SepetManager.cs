using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi ; " + urun.Adı);

        }

        public void Ekle2(string urunAdı, string acıklama, double fıyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi ; " + urunAdı);
        }

    }

}
