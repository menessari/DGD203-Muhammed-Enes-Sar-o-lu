using System;

namespace DGD203
{
    class Kontrol
    {
        public void Sonuclar()
        {
            Console.Write("Arabanın markasını girin: ");
            string markaKullanici = Console.ReadLine();

            Console.Write("Arabanın modelini girin: ");
            string modelKullanici = Console.ReadLine();


            int yilKullanici;
            while (true)
            {

                Console.Write("Arabanın yılını girin: ");
                string yilgiris = Console.ReadLine();

                if (int.TryParse(yilgiris, out yilKullanici))
                {
                    break;
                }
                else
                {
                    Console.Write("Lütfen sadece sayı giriniz." + Environment.NewLine);
                }

            }

            float motorGucuKullanici;
            while (true)
            {
                Console.Write("Arabanın motor gücünü girin (Örnek: 1.6): ");
                string motorGucuGiris= Console.ReadLine();

                if (float.TryParse(motorGucuGiris, out motorGucuKullanici))
                {
                    break;
                }
                else
                {
                    Console.Write("Lütfen sadece ondalık ya da tam sayı giriniz." + Environment.NewLine);
                }
            }

            float yakitTuketimiKullanici;
            while (true)
            {
                Console.Write("100 km'de yaktığı benzini litre cinsinden girin (Örnek: 5.0): ");
                string yakitTuketimiGiris = Console.ReadLine();

                if (float.TryParse(yakitTuketimiGiris, out yakitTuketimiKullanici))
                {
                    break;
                }
                else
                {
                    Console.Write("Lütfen sadece ondalık ya da tam sayı giriniz." + Environment.NewLine);
                }
            }

            Araba araba1 = new Araba(markaKullanici, modelKullanici, yilKullanici, motorGucuKullanici, yakitTuketimiKullanici);

            Console.WriteLine("Girdiğiniz arabanın bilgileri:");
            araba1.ArabaBilgisiGoster();


        }
    }
}
