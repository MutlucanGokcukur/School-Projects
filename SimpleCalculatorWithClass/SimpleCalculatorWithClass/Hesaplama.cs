using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorWithClass
{
    class Hesaplama
    {//topla
        //Bir Değer Döndüreceği için void yerine decimal
        public decimal toplama(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 + sayı2;
            return sonuc;
        }

        //Çıkartma
        public decimal çıkarma(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 - sayı2;
            return sonuc;
        }

        //Çarpma
        public decimal carpma(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 * sayı2;
            return sonuc;
        }

        //Bölme
        public decimal bolme(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 / sayı2;
            return sonuc;
        }

        //Menü
        public void menü()
        {
            Console.Clear();
            Console.WriteLine("****İşlem Numaraları****\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme");
            Console.Write("İşlem Numarasını Seçiniz: ");
        }
        public void islem_sonuc(decimal s1, decimal s2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", s1, operators, s2, sonuc);
        }
    }
}
