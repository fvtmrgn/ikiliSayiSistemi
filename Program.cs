using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İkiliSayiSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Onlu sayı sistemine çevrilecek ikili sayı sisteminde sayı giriniz;");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int  ikiliDeger, onluDeger = 0, tabanDeger = 1, basamakDeger;
                ikiliDeger = sayi;

                while (sayi > 0)
                {
                    basamakDeger = sayi % 10;
                    onluDeger = onluDeger + basamakDeger * tabanDeger;
                    sayi = sayi / 10;

                    tabanDeger = tabanDeger * 2;
                }
                Console.Write("İkili (Binary) Sayı: " + ikiliDeger);
                Console.Write("\nOnlu (Decimal) Sayı: " + onluDeger);
                Console.ReadLine();

            }
        }
    }
}
