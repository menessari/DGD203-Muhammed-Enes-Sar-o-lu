using System;
using yarisOyunu;

namespace yarisOyunu
{
    public class Yaris
    {
        public void YaristaOyna(yapayZekaAraba car1, OyuncuAraba car2)
        {
            Console.Write("Yarışmak istediğiniz tur sayısını giriniz: ");
            int tur = int.Parse(Console.ReadLine());

            double toplamPerformans1 = 0;
            double toplamPerformans2 = 0;

            Random rand = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            Random rand4 = new Random();


            int ekranGenisligi = 50;

            for (int i = 0; i < tur; i++)
            {
                var performans1 = (car1.MaxHiz * 0.3) + (100 / car1.Hizlanma) + (car1.YolTutusu * 0.2) + (car1.Dayaniklik * 0.1);
                var performans2 = (car2.MaxHizOyuncu * 0.3) + (100 / car2.HizlanmaOyuncu) + (car2.YolTutusuOyuncu * 0.2) + (car2.DayaniklikOyuncu * 0.1);

                if (rand.NextDouble() < 0.15)
                {
                    car1.Hizlanma += 1;
                    car2.HizlanmaOyuncu += 1;
                    car1.YolTutusu -= 5;
                    car2.YolTutusuOyuncu -= 5;
                    Console.WriteLine("Yağmur yağdı! Hızlanma ve yol tutuşu etkileniyor.");
                }

                if (rand2.NextDouble() < 0.10)
                {
                    car1.MaxHiz -= 10;
                    car1.Dayaniklik -= 5;
                    car2.MaxHizOyuncu -= 10;
                    car2.DayaniklikOyuncu -= 5;
                    Console.WriteLine("Kaza oldu! Hız ve dayanıklılık azaldı.");
                }

                double surucuEtkisi1 = rand3.NextDouble() * 0.4 + 0.8;
                double surucuEtkisi2 = rand4.NextDouble() * 0.4 + 0.8;

                performans1 *= surucuEtkisi1;
                performans2 *= surucuEtkisi2;

                toplamPerformans1 += performans1;
                toplamPerformans2 += performans2;


                int karePozisyon1 = (int)(toplamPerformans1 / 100);
                int karePozisyon2 = (int)(toplamPerformans2 / 100);

                Console.Clear();


                Console.WriteLine("Yarış başlıyor...");
                for (int j = 0; j < ekranGenisligi; j++)
                {
                    if (j == karePozisyon1)
                    {
                        Console.Write("Y "); 
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }

                Console.WriteLine();

                for (int j = 0; j < ekranGenisligi; j++)
                {
                    if (j == karePozisyon2)
                    {
                        Console.Write("O "); 
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }

                Console.WriteLine();

                Console.WriteLine($"{i + 1}. Tur bitti.");
                Console.WriteLine($"Yapay Zeka Araba Performansı: {performans1}");
                Console.WriteLine($"Oyuncu Araba Performansı: {performans2}");
                Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
                Console.ReadKey(true);
            }

            Console.WriteLine($"Yarış sonunda Yapay Zeka Araba'nın toplam performansı: {toplamPerformans1}");
            Console.WriteLine($"Yarış sonunda Oyuncu Araba'nın toplam performansı: {toplamPerformans2}");

            if (toplamPerformans1 > toplamPerformans2)
            {
                Console.WriteLine("Yarışı Yapay Zeka kazandı!");
            }
            else if (toplamPerformans1 < toplamPerformans2)
            {
                Console.WriteLine("Yarışı Oyuncu kazandı!");
            }
            else
            {
                Console.WriteLine("Yarış berabere sonuçlandı!");
            }
        }
    }
}
