using System;
using System.Collections;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac();
            a1.AracTür = "Audi";
            a1.YapımYIL = 2022;
            Console.WriteLine("--------------Araç--------------");
            a1.OrtakYazdır();

            otomobil o1 = new otomobil();
            Console.WriteLine("--------------Otomobil--------------");
            o1.ARACTUR = "Toyota";
            o1.TEKERSAYI = 4;
            o1.AGIRLIK = 2000;
            o1.YapımYIL = 2021;
            o1.OrtakYazdır();

            otomobil o2 = new otomobil();
            Console.WriteLine("--------------Otomobil--------------");
            o1.ARACTUR = "Mercedes";
            o1.YapımYIL = 2020;
            o1.AGIRLIK = 1500;
            o1.TEKERSAYI = 4;
            o1.OrtakYazdır();

            BMW b1 = new BMW();
            Console.WriteLine("--------------BMW--------------");
            b1.MODEL = "BMW X5";
            b1.renk = "Kırmızı";
            b1.OrtakYazdır();
        }
    }
    public class Arac
    {
        protected static string arac_türü { get; set; }
        protected static int yapimyili { get; set; }
        protected static int id { get; set; }

        public string AracTür { get { return arac_türü; } set { value=this.AracTür; } }
        public int YapımYIL { get { return yapimyili; } set { yapimyili=value; } }
        public int ID { get { return id; } set { ID = value; } }

        public Arac()
        {
            Console.WriteLine("Araç Kurucu Çalıştı");
            id++;
        }
        public virtual void OrtakYazdır()
        {
            Console.WriteLine("Araç Türü: " + arac_türü);
            Console.WriteLine("id: " + id);
            Console.WriteLine("Yapım Yılı: " + yapimyili);
        }
    }
    class otomobil : Arac
    {
        protected static string marka { get; set; }
        protected static int agirlik { get; set; }
        protected static int tekerleksayisi { get; set; }

        public string ARACTUR { get { return arac_türü; } set { arac_türü = value; } }

        public int AGIRLIK
        { get { return agirlik; } set { agirlik = value; } }
        public int TEKERSAYI
        { get { return tekerleksayisi; } set { tekerleksayisi = value; } }
        public otomobil()
        {
            Console.WriteLine("Otomobil Kurucu Çalıştı");
        }
        public override void OrtakYazdır()
        {
            base.OrtakYazdır();
            Console.WriteLine("Ağırlık: " + agirlik);
            Console.WriteLine("Tekerlek Sayısı: " + tekerleksayisi);
        }
    }
    class BMW : otomobil
    {
        protected string Model { get; set; }
        protected string Renk { get; set; }

        public string MODEL { get { return Model; } set { this.Model = value; } }
        
        public string renk { get { return Renk; } set { this.Renk = value; } }

        public BMW()
        {
            Console.WriteLine("BMW Kurucu Çalıştı");
        }
        public override void OrtakYazdır()
        {
            base.OrtakYazdır();
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Renk: " + Renk);
        }
    }
}
