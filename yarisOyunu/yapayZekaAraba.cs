using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yarisOyunu
{
    public class yapayZekaAraba
    {
        public int MaxHiz { get; set; }
        public int Hizlanma { get; set; }
        public int YolTutusu { get; set; }
        public int Dayaniklik { get; set; }

        public yapayZekaAraba(int maxHiz, int hizlanma, int yolTutusu, int dayaniklik)
        {
            MaxHiz = maxHiz;
            Hizlanma = hizlanma;
            YolTutusu = yolTutusu;
            Dayaniklik = dayaniklik;
        }
    }
}
