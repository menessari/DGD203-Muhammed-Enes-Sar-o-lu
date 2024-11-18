using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yarisOyunu
{
    public class yapayZekaSecim
    {
        private static Random rand = new Random();
        private static readonly int[] MaxHizList = { 250, 300, 350, 400 };

        private static readonly int[] HizlanmaList = { 5, 6, 7, 8 };

        private static readonly int[] YolTutusuList = { 60, 70, 80, 90 };

        private static readonly int[] DayaniklikList = { 60, 70, 80, 90 };


        public static yapayZekaAraba RastgeleAraba()
        {
            int maxHiz = MaxHizList[rand.Next(MaxHizList.Length)];
            int hizlanma = HizlanmaList[rand.Next(HizlanmaList.Length)];
            int yolTutusu = YolTutusuList[rand.Next(YolTutusuList.Length)];
            int dayaniklik = DayaniklikList[rand.Next(DayaniklikList.Length)];

            return new yapayZekaAraba(maxHiz, hizlanma, yolTutusu, dayaniklik);
        }
    }
}