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
            Console.WriteLine("0-100 arası benzersiz sayı üreticisi...\n");
            Console.Write("Kaç tane 'Benzersiz Sayı' üretilecek?:");

            int adet;
            adet = int.Parse(Console.ReadLine());

            int[] sayilar = new int[adet];


            Random rnd = new Random();
            int i = 0;
            while (adet != i)
            {
                sayilar[i] = rnd.Next(0, 100);
                int z = 0;
                while (z < i)
                {
                    if (sayilar[i] == sayilar[z])
                    {
                        i--;
                        break;
                    }
                    z++;
                }
                i++;
            }

            Array.Sort(sayilar);
            Console.WriteLine(" ");
            for (int j = 0; j < sayilar.Length; j++)
            {
                Console.WriteLine($"{j + 1}. Benzersiz sayınız: {sayilar[j]}");
            }
            Console.ReadKey();
        }
    }
}
