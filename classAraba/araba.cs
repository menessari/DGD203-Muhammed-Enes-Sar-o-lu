using System;

namespace DGD203
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public float MotorGucu { get; set; }
        public float YakitTuketimi { get; set; }

        public Araba(string markaKullanici, string modelKullanici, int yilKullanici, float motorGucuKullanici, float yakitTuketimiKullanici)
        {
            Marka = markaKullanici;
            Model = modelKullanici;
            Yil = yilKullanici;
            MotorGucu = motorGucuKullanici;
            YakitTuketimi = yakitTuketimiKullanici;


        }

        public void ArabaBilgisiGoster()
        {
            Console.WriteLine("Marka: " + Marka + Environment.NewLine);
            Console.WriteLine("Model: " + Model + Environment.NewLine);


            Console.WriteLine("Yıl: " + Yil + Environment.NewLine);
            if (Yil < 2012)
            {
                Console.WriteLine("Araban çok eski." + Environment.NewLine);

            }
            else if (Yil > 2018 && Yil < 2024) 
            {
                Console.WriteLine("Araban yeni gibi." + Environment.NewLine);
            }
            else if (Yil > 2024)
            {
                Console.WriteLine("Araban galiba gelecekten geliyor." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Bi' süre seni götürür." + Environment.NewLine);
            }


            Console.WriteLine("Motor Gücü: " + MotorGucu + Environment.NewLine);
            if (MotorGucu < 1.2)
            {
                Console.WriteLine("Araban yokuş çıkarken zorlanıyordur." + Environment.NewLine);

            }
            else if (MotorGucu > 2.0)
            {
                Console.WriteLine("Füze gibi araban var." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Bastın mı gaza gider, gerisi önemli değil." + Environment.NewLine);
            }


            Console.WriteLine("100km'de Yaktığı Benzin: " + YakitTuketimi + "L" + Environment.NewLine);
            if (YakitTuketimi < 5.0)
            {
                Console.WriteLine("Neredeyse yakmıyor." + Environment.NewLine);

            }
            else if (YakitTuketimi > 8.0)
            {
                Console.WriteLine("Ocağına incir ağacı diker." + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Normal araba yakışı." + Environment.NewLine);
            }
        }

    }
}
