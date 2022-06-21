using System;

namespace SimpleCalculatorWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesaplama = new Hesaplama();
        yeniden_islem:
            hesaplama.menü();
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Write("İlk Sayıyı Giriniz: ");
            decimal s1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            decimal s2 = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = 0;
            switch (secim)
            {
                case 1://Toplama
                    sonuc = hesaplama.toplama(s1, s2);
                    hesaplama.islem_sonuc(s1, s2, sonuc, "+");
                    break;
                case 2://Çıkarma
                    sonuc = hesaplama.çıkarma(s1, s2);
                    hesaplama.islem_sonuc(s1, s2, sonuc, "-");
                    break;
                case 3://Çarpma
                    sonuc = hesaplama.carpma(s1, s2);
                    hesaplama.islem_sonuc(s1, s2, sonuc, "*");
                    break;
                case 4://Bölme
                    sonuc = hesaplama.bolme(s1, s2);
                    hesaplama.islem_sonuc(s1, s2, sonuc, "/");
                    break;

                default:
                    Console.WriteLine("Geçersiz İşlem....\nYeniden Giriş Yapınız....");
                    System.Threading.Thread.Sleep(2000);
                    goto yeniden_islem;
            }
            Console.Write("Yeni İşlem Yapmak İstiyor Musunuz?(E/H)");
            string geri_donus = Console.ReadLine();
            geri_donus = geri_donus.ToUpper();
            if (geri_donus == "E")
            {
                goto yeniden_islem;
            }
            else
            {
                Console.WriteLine("Program Sonlanıyor...");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
