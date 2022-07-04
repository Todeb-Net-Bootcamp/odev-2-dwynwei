using Patika.Dev_Abstract_Class_Hw.Abstact;
using Patika.Dev_Abstract_Class_Hw.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Patika.Dev_Abstract_Class_Hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid digitalWalletId = Guid.NewGuid();

            // TODEBCard Abstact sınıfından inherit edilen CreditCard sınıfına ait obje oluşturma bölümü
            TODEBCard creditCard = new CreditCard("PLATINUM", "VISA", "1111-2222-3333-4444", "Çağatay Şahin");

            // TODEBCard Abstact sınıfından inherit edilen DigitalCard sınıfına ait obje oluşturma bölümü
            TODEBCard digitalCard = new DigitalCard("GOLD", "MasterCard", "1111-2222-3333-4444", "Çağatay Şahin");

            // TODEBCard Abstact sınıfından inherit edilen Debit(Hesap) Kartı sınıfına ait obje oluşturma bölümü
            TODEBCard debitCard = new DebitCard("BRONZE", "MasterCard", "1111-2222-3333-4444", "Çağatay Şahin");

            // Ekrana bilgilerin yazıldığı fonksiyonlardır !
            creditCard.writeLogToConsole();
            Console.WriteLine("---------------------------------------------------");
            digitalCard.writeLogToConsole();
            Console.WriteLine("---------------------------------------------------");
            debitCard.writeLogToConsole();

        }
    }
}
