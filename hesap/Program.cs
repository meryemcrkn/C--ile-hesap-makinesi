using System;

namespace hesap
{
    class Program
    {
        static float Hesapla(int s1_par, int s2_par, string islem_par)
        {
            float sonuc = 0;
            switch (islem_par)
            {
                case "+":
                    sonuc = s1_par + s2_par;
                    break;
                case "-":
                    sonuc = s1_par - s2_par;
                    break;
                case "/":
                    sonuc = (float)s1_par / s2_par;
                    break;
                case "*":
                    sonuc = s1_par * s2_par;
                    break;
                default:
                    Console.WriteLine("Hatalı işlem girdiniz");
                    break;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            int s1, s2;
            float cevap;
            string islem;
            Console.WriteLine("Sayıları giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem giriniz : ");
            islem = Console.ReadLine();
            Console.WriteLine("İşlem sonucu = {0}", Hesapla(s1, s2, islem));
            Console.ReadLine();
        }
    }
}
