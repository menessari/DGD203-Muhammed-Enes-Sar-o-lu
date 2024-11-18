using System;
using yarisOyunu;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace yarisOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = yapayZekaSecim.RastgeleAraba();

            OyuncuAraba car2 = null;

            Console.WriteLine("Kendi arabanızı oluşturmak için '1', rastgele bir araba edinmek için '2' yazınız.");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                car2 = oyuncuArabaYapma.oyuncuSecim();
            }
            else if (secim == 2)
            {
                car2 = OyuncuSecim.RastgeleArabaOyuncu();
            }
            else
            {
                Console.WriteLine("Lütfen sadece '1' veya '2' değerlerini giriniz.");
                return;
            }

            Console.WriteLine($"Yapay Zeka: Max Speed: {car1.MaxHiz} km/s, Acceleration: {car1.Hizlanma}s, Road Grip: {car1.YolTutusu}, Durability: {car1.Dayaniklik}");
            Console.WriteLine($"Oyuncu: Max Speed: {car2.MaxHizOyuncu} km/s, Acceleration: {car2.HizlanmaOyuncu}s, Road Grip: {car2.YolTutusuOyuncu}, Durability: {car2.DayaniklikOyuncu}");
            Yaris yaris = new Yaris();
            yaris.YaristaOyna(car1,car2);
        }
    }
}

