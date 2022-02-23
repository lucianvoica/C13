using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{
    internal class ConvertorTemperatura
    {
        const double constantaKelvin = 273;
        
        const double constantaFar1 = 18 / 10;
        const double constantaFar2 = 32;

        public static double ConvertCelsiusToKelvin(double temperaturaC)
        {
            return temperaturaC + constantaKelvin;
        }
        public static double ConvertCtoF(double temperaturaC)
        {
            return temperaturaC * constantaFar1 + constantaFar2;
        }
        public static double ConvertKtoC(double temperaturaK)
        {
            return temperaturaK - constantaKelvin;
        }

    }
}
