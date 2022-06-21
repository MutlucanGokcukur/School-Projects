using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac(2000, 2010);
            a1.VitesArttir(5);
            a1.VergiHesapla();
            a1.Yazdır();
        }
    }
    class Arac
    {
        private int MotorHacim { get; set; }
        private int ModelYılı { get; set; }
        public int Hız { get; set; }
        public int Vites { get; set; }
        public int Vergi { get; set; }

        public int motorhacim
        {
            get
            {
                return MotorHacim;
            }
            set { }
        }
        public int modelyıl
        {
            get
            {
                return ModelYılı;
            }
            set { }
        }
        public Arac(int motorhacim, int modelyıl)
        {
            this.MotorHacim = motorhacim;
            this.ModelYılı = modelyıl;
        }
        public int VergiHesapla()
        {
            if (MotorHacim == 1600)
            {
                Vergi = MotorHacim * 10;
            }
            else if (MotorHacim == 2000)
            {
                Vergi = MotorHacim * 20;
            }
            else if (MotorHacim == 2500)
            {
                Vergi = MotorHacim * 2500;
            }
            return Vergi;
        }
        public int VitesArttir(int vites)
        {
            this.Vites = vites;
            Hız = Vites * 20;
            return Vites;
        }
        public void Yazdır()
        {
            Console.WriteLine("Motor Hacim: " + MotorHacim + "\nModel Yılı: " + ModelYılı + "\nHız: " + Hız + "\nVites: " + Vites + "\nVergi: " + Vergi);
        }
    }
}
