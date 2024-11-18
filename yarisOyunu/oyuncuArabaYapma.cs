using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yarisOyunu
{
    public class oyuncuArabaYapma
    {
        public static OyuncuAraba oyuncuSecim()
        {
            Console.Write("Arabanın maksimum hızını girin: ");
            int maxHizOyuncu = int.Parse(Console.ReadLine());

            Console.Write("Arabanın hızlanmasını giriniz(2-10): ");
            int hizlanmaOyuncu = int.Parse(Console.ReadLine());

            Console.Write("Arabanın yol tutuşunu giriniz(0-100): ");
            int yolTutusuOyuncu = int.Parse(Console.ReadLine());

            Console.Write("Arabanın dayanıklılığını giriniz(0-100): ");
            int dayaniklikOyuncu = int.Parse(Console.ReadLine());

            return new OyuncuAraba(maxHizOyuncu, hizlanmaOyuncu, yolTutusuOyuncu, dayaniklikOyuncu);

            {

            }
        }
    }
}
