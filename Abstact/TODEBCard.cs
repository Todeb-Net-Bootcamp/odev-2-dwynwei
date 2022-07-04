using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Patika.Dev_Abstract_Class_Hw.Abstact
{
    public abstract class TODEBCard
    {
        private DateTime expirationDate;
        public string AccountType { get; set; } // Kullanıcı Hesabı Tipi Property Alanı
        public string CardNumber { get; set; } // Kullanıcı Kart Numarası
        public string ExpireDate // Kullanıcı Kart Son Kullanma Tarihi
        {
            get
            {
                expirationDate = DateTime.Now;
                return expirationDate.AddMonths(6).AddYears(6).ToString("MM'/'yy");
            }
        }
        public string CardHolder { get; set; }

        public TODEBCard(string accountType, string cardNumber, string cardHolder) // Bu Sınıf Constructor İçerir.
        {
            AccountType = accountType;
            CardNumber = cardNumber;
            CardHolder = cardHolder;
        }

        //Property Alanlarından gelen verilere göre Console'a veri yazan metottur.
        public virtual void writeLogToConsole() 
        {
            Console.WriteLine($"Merhabalar {CardHolder}. Kartınızın. {CardNumber} numaralı Kartınız ile işlem yapmaya hazırsınız!");
        }
    }
}
