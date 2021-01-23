using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databasaLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, smsLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtıyacKrediManager, tasıtKrediManager };

           // basvuruManager.KrediOnBilgilemdirmesiYap(krediler);

        }
    }
}
