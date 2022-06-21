using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.tckimlik = "32345354354";
            o1.ogrencino = "32343543";

        }
    }
    class Ogrenci
    {
        public string adsoyad { get; set; }
        private string TCKimlik;
        private string OgrenciNO;

        public string tckimlik
        {
            get
            {
                return TCKimlik;
            }
            set
            {
                if (value.ToString().Length == 11)
                {
                    TCKimlik = value;
                    Console.WriteLine("TC Kimlik Numarası: " + value);
                }
                else
                {
                    Console.WriteLine("TC Kimlik 11 Haneden Oluşmalıdır.");
                }
            }
        }
        public string ogrencino
        {
            get
            {
                return OgrenciNO;
            }
            set
            {
                if (value.ToString().Length == 9)
                {
                    OgrenciNO = value;
                    Console.WriteLine("Ogrenci NO: " + value);
                }
                else
                {
                    Console.WriteLine("Ogrenci Numarası 9 Haneden Oluşmalıdır");
                }
            }
        }

    }
}
