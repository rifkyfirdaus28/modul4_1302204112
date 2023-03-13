using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204112
{
    internal class KodeBuah
    {
        public enum Buah
        {
           Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, dan 
        }
        public static string GetKodeBuah(Buah namabuah)
        {
            string[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00"};

            return KodeBuah[0] ;
        }

    }
}
