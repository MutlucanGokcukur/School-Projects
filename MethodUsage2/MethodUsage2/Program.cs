using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolap d1 = new Dolap(3, 4, 5);
            d1.Hesap();
            d1.Yaz();
        }
    }
    class Dolap
    {
        public decimal en;
        public decimal boy;
        public decimal derinlik;
        public decimal hacim;

        public Dolap(decimal _en, decimal _boy, decimal _derinlik)
        {
            en = _en;
            boy = _boy;
            derinlik = _derinlik;
        }
        public decimal Hesap()
        {
            hacim = en * boy * derinlik;
            return hacim;
        }
        public void Yaz()
        {
            Console.WriteLine("En: " + en);
            Console.WriteLine("Boy: " + boy);
            Console.WriteLine("Derinlik: " + derinlik);
            Console.WriteLine("Hacim: " + hacim);
        }

    }
}
