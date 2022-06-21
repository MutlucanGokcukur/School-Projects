using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Kart k1 = new Kart();
            k1.musteriAdi = "Mutlucan";
            k1.KartNo = 123456789;
            k1.bakiye = 1000;
            k1.Yazdır();
            k1.ParaCek(500);
        }
    }
    class Kart
    {
        public int KartNo;
        public string musteriAdi;
        public int bakiye;

        public Kart() { }

        public int ParaCek(int miktar)
        {
            if (bakiye - miktar < 0)
            {
                Console.WriteLine("Çekilemez");
            }
            else
            {
                bakiye = bakiye - miktar;
                Console.WriteLine("Yeni Bakiye: " + bakiye);
            }
            return bakiye;
        }
        public void Yazdır()
        {
            Console.WriteLine("Bakiye: " + bakiye);
            Console.WriteLine("Kart No: " + KartNo);
            Console.WriteLine("Müşteri Adı: " + musteriAdi);
        }

    }
}
