using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{
    internal static class ConvertorValutar
    {
        private static double rataEurRon = 4.94;

        public static double ConvertEurToRon(double sumaEur)
        {
            return sumaEur * rataEurRon;
        }

        public static int ceva;
    }
}
