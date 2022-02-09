using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 103456;
            //int z = 0;
            //int p = 1;
            //int c;
            //while(n > 0)
            //{
            //    c = n % 10;
            //    n = n / 10;
            //    if(c % 3 == 0)
            //    {
            //        z = z + p * (9 - c);
            //        p = p * 10;
            //    }
            //}
            //Console.WriteLine(z);

            int x = int.Parse(Console.ReadLine());
            int y;
            while(x > 0)
            {
                y = int.Parse(Console.ReadLine());
                if(x > y)
                {
                    Console.WriteLine("nr:" + x % 10);
                } else
                {
                    Console.WriteLine("nr:" + y % 10);
                }
                x = y;
            }
        }
    }
}
