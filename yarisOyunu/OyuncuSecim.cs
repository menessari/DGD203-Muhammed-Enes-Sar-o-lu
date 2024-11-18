using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yarisOyunu
{
    public class OyuncuSecim
    {
        private static readonly int[] MaxHizListOyuncu = { 250, 300, 350, 400 };

        private static readonly int[] HizlanmaListOyuncu = { 4, 5, 6, 7 };

        private static readonly int[] YolTutusuListOyuncu = { 60, 70, 80, 90 };

        private static readonly int[] DayaniklikListOyuncu = { 60, 70, 80, 90 };


        public static OyuncuAraba RastgeleArabaOyuncu()
        {
            Random randOyuncu = new Random();
            int maxHizOyuncu = MaxHizListOyuncu[randOyuncu.Next(MaxHizListOyuncu.Length)];
            int hizlanmaOyuncu = HizlanmaListOyuncu[randOyuncu.Next(HizlanmaListOyuncu.Length)];
            int yolTutusuOyuncu = YolTutusuListOyuncu[randOyuncu.Next(YolTutusuListOyuncu.Length)];
            int dayaniklikOyuncu = DayaniklikListOyuncu[randOyuncu.Next(DayaniklikListOyuncu.Length)];

            return new OyuncuAraba(maxHizOyuncu, hizlanmaOyuncu, yolTutusuOyuncu, dayaniklikOyuncu);
        }
    }
}
