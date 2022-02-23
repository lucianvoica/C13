using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{

    public class Program
    {
        static void Main(string[] args)
        {
            double rezultat = ConvertorValutar.ConvertEurToRon(100);

            double rezultat2 = ConvertorValutar.ConvertEurToRon(345);

            double rezultat3 = ConvertorValutar.ConvertEurToRon(345);

            Console.WriteLine("convertor:" + rezultat2 + " convertor2: " + rezultat3);


            //30C -> F

            double tempF = ConvertorTemperatura.ConvertCtoF(30);

            Console.WriteLine("30C = " + tempF + "F");

            Student s = new Student();
            s.PrinteazaInformatiiComplete();

        }
    }
}