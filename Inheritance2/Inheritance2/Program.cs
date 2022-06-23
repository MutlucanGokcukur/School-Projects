using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            Console.WriteLine("----------------Personel----------------");
            p1.ADSOYAD = "Arda Ünsalan";
            p1.YAS = 20;
            p1.OrtakYazdır();

            Ogretmen o1 = new Ogretmen();
            Console.WriteLine("----------------Öğretmen----------------");
            o1.ADSOYAD = "Mahmut Satici";
            o1.YAS = 19;
            o1.DERSSAATI = 15;
            o1.maasHesabi();
            o1.OrtakYazdır();

            Ogretmen o2 = new Ogretmen();
            Console.WriteLine("----------------Öğretmen----------------");
            o1.ADSOYAD = "Yusuf Üzeyir Kaya";
            o1.YAS = 20;
            o1.DERSSAATI = 15;
            o1.maasHesabi();
            o1.OrtakYazdır();

            Mudur m1 = new Mudur();
            Console.WriteLine("----------------Müdür----------------");
            m1.UNVAN = "Müdür";
            m1.ADSOYAD = "Mutlucan Gökçukur";
            m1.DERSSAATI = 10;
            m1.maasHesabi();
            m1.OrtakYazdır();
        }
    }
    public class Personel
    {
        protected static string adsoyad { get; set; }
        protected static int yas { get; set; }
        protected static int personelno { get; set; }

        public string ADSOYAD { get { return adsoyad; } set { adsoyad = value; } }
        public int YAS { get { return yas; } set { yas = value; } }
        public Personel()
        {
            Console.WriteLine("Personel Kurucusu Çalıştı.");
            personelno++;
        }
        public virtual void OrtakYazdır()
        {
            Console.WriteLine("Adı Soyadı: " + adsoyad);
            Console.WriteLine("Personel Numarası: " + personelno);
            Console.WriteLine("Yaş: " + yas);
        }
    }
    public class Ogretmen : Personel
    {
        protected static string bolum { get; set; }
        protected static int derssaati { get; set; }
        protected static int maas { get; set; }

        public string BOLUM { get { return bolum; } set { bolum = value; } }
        public int DERSSAATI { get { return derssaati; } set { derssaati = value; } }
        public Ogretmen()
        {
            Console.WriteLine("Ogretmen Kurucu Çalıştı");
        }
        public virtual int maasHesabi()
        {
            maas = derssaati * 960;
            return maas;
        }
        public override void OrtakYazdır()
        {
            base.OrtakYazdır();
            Console.WriteLine("Ders Saati: " + derssaati);
            Console.WriteLine("Maaş: " + maas);
        }
    }
    public class Mudur : Ogretmen
    {
        protected string unvan;
        public string UNVAN { get { return unvan; } set { unvan = value; } }
        public Mudur()
        {
            Console.WriteLine("Müdür Kurucusu Çalıştı");
        }
        public override int maasHesabi()
        {
            maas = derssaati * 2000;
            return maas;
        }
        public override void OrtakYazdır()
        {
            base.OrtakYazdır();
            Console.WriteLine("Ünvan: " + unvan);
        }
    }
}