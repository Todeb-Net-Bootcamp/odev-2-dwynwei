using Patika.Dev_Abstract_Class_Hw.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Dev_Abstract_Class_Hw.Concrete
{
    public class CreditCard : TODEBCard
    {
        public string CardType { get; set; } // TÖDEBCard Abstract sınıfına ek olarak gelen Kart Tipi Property alanı. (VISA, MAESTRO, MASTERCARD vb.)

        // Base Class'ın constructor alanını miras alarak oluşturulmuş ek constructor -> CreditCard
        public CreditCard(string accountType, string cardType, string cardNumber, string cardHolder) : base(accountType, cardNumber, cardHolder)
        {
            CardType = cardType;
        }

        // Base Class'tan overwrite edilmiş writeLogToConsole Metodu
        public override void writeLogToConsole()
        {
            Console.WriteLine($"Sn {CardHolder}. {CardNumber} No'lu {CardType} Kredi Kartınız İçin, {AccountType} Olarak Giriş Yaptınız.");
        }
    }
}
