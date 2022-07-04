using Patika.Dev_Abstract_Class_Hw.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Dev_Abstract_Class_Hw.Concrete
{
    public class DebitCard : TODEBCard
    {
        public string CardType { get; set; } // TÖDEBCard Abstract sınıfına ek olarak gelen Kart Tipi Property alanı. (VISA, MAESTRO, MASTERCARD vb.)

        // Base Class'ın constructor alanını miras alarak oluşturulmuş ek constructor -> DebitCard
        public DebitCard(string accountType, string cardType, string cardNumber, string cardHolder) : base(accountType, cardNumber, cardHolder)
        {
            cardType = CardType;
        }

        //Property Alanlarından gelen verilere göre Console'a veri yazan metottur.
        public override void writeLogToConsole()
        {
            Console.WriteLine($"Sn {CardHolder}. {CardNumber} No'lu {CardType} ve {ExpireDate} Bitiş Tarihli Hesap Kartınız İçin, {AccountType} Olarak Giriş Yaptınız.");
        }

    }
}
