using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac();
            a1.SatınAl(5000, 200, "Mavi");
            a1.Yazdır();

            Arac a2 = new Arac();
            a2.SatınAl(4000, 300, "Siyah");
            a2.Yazdır();

            Arac a3 = new Arac();
            a3.SatınAl(3000, 100, "Turkuaz");
            a3.Yazdır();
        }
    }
    class Arac
    {
        private int Ağırlık { get; set; }
        private int SilindirHacim { get; set; }
        private static int AracNO { get; set; }
        private string Renk { get; set; }
        private string Açıklama { get; set; }

        public Arac()
        {
            AracNO++;
            Açıklama = AracNO + ". Araç";
            Console.WriteLine(Açıklama);
            Renk = "Kırmızı";
            SilindirHacim = 1600;
            Ağırlık = 1000;
        }
        public Arac(string renk)
        {
            AracNO++;
            Açıklama = AracNO + ". Araç";
            Console.WriteLine(Açıklama);
            Renk = renk;
        }
        public void SatınAl(int Ağırlık, int SilindirHacim, string Renk)
        {
            this.Renk = Renk;
            this.SilindirHacim = SilindirHacim;
            this.Ağırlık = Ağırlık;
        }
        public void Yazdır()
        {
            Console.WriteLine("Ağırlık: " + Ağırlık + "\nSilindir Hacmi: " + SilindirHacim + "\nRenk: " + Renk);
        }
    }
}
