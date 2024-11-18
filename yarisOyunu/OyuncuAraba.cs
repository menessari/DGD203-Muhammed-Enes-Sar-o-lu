using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yarisOyunu;

namespace yarisOyunu
{
    public class OyuncuAraba
    {   public int MaxHizOyuncu { get; set; }
        public int HizlanmaOyuncu { get; set; }
        public int YolTutusuOyuncu { get; set; }
        public int DayaniklikOyuncu { get; set; }

        public OyuncuAraba(int maxHizOyuncu, int hizlanmaOyuncu, int yolTutusuOyuncu, int dayaniklikOyuncu)
        {
            MaxHizOyuncu = maxHizOyuncu;
            HizlanmaOyuncu = hizlanmaOyuncu;
            YolTutusuOyuncu = yolTutusuOyuncu;
            DayaniklikOyuncu = dayaniklikOyuncu;
        }
    }
}
