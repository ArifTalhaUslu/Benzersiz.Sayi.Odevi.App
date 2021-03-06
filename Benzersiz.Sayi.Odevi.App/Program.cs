using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzersiz.Sayi.Odevi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane 'Benzersiz Sayı' üretilecek?:");
            int adet;
            adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];

            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 1000);
            }
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Benzersiz sayınız: {sayilar[i]}");
            }
        }
    }
}
