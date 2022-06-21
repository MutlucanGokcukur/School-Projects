using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.telefonno = "1235456879";
            m1.idno = "1235";
        }
    }
    class Musteri
    {
        public string isim { get; set; }
        private string TelefonNO;
        private string IDNO;

        public string telefonno
        {
            get
            {
                return TelefonNO;
            }
            set
            {
                if (value.ToString().Length == 10)
                {
                    TelefonNO = value;
                    Console.WriteLine("Telefon Numarası: " + TelefonNO);
                }
                else
                {
                    Console.WriteLine("Telefon Numarası 10 Haneli Olmalıdır");
                }
            }
        }
        public string idno
        {
            get
            {
                return IDNO;
            }
            set
            {
                if (value.ToString().Length == 5)
                {
                    IDNO = value;
                    Console.WriteLine("İD Numarası: " + IDNO);
                }
                else
                {
                    Console.WriteLine("İd Numarası 5 Haneli Olmalıdır");
                }
            }
        }
    }
}
