using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    internal class Program
    {
        enum ZileSaptamana
        {
            Luni = 1,
            Marti,
            Miercuri,
            Joi,
            Vineri,
            Sambata,
            Duminica
        };

        static void Main(string[] args)
        {
            string mesaj = Console.ReadLine();
            int nr = int.Parse(mesaj);

            if(nr <= 10)
            {
                Console.WriteLine("Numarul are o cifra");
            } 
            else if (nr > 100)
            {
                Console.WriteLine("numarul are 3 cifre");
            }
            else
            {
                Console.WriteLine("numarul are 2 cifre");
            }

            // if - exercitiul 2
            string Ana = Console.ReadLine();
            string Maria = Console.ReadLine();

            int varstaAna = int.Parse(Ana);
            int varstaMaria = int.Parse(Maria);

            if (varstaAna > 18 && varstaMaria > 18)
            {
                Console.WriteLine("ambele fete sunt majore");
            }
            else if (varstaAna > 18 || varstaMaria > 18) 
            {
                Console.WriteLine("cel putin una este majora");
            }
            else
            {
                Console.WriteLine("ambele fete sunt minore");
            }

            //if(varstaAna > 18)
            //{
            //    if(varstaMaria > 18)
            //    {
            //        Console.WriteLine("ambele sunt majore");
            //    }
            //    else
            //    {
            //        Console.WriteLine("cel putin una este majora");
            //    }
            //}
            //else
            //{
            //    if(varstaMaria < 18)
            //    {
            //        Console.WriteLine("ambele sunt minore");
            //    }
            //    else
            //    {
            //        Console.WriteLine("cel putin una este majora");
            //    }
            //}

            //Vreau sa afisez toate numere de la 0 la 5
            int a = 0;
            Console.WriteLine(a); //0
            a++;
            Console.WriteLine(a); //1
            a++;
            Console.WriteLine(a); //2
            a++;
            Console.WriteLine(a); //3
            a++;
            Console.WriteLine(a); //4
            a++;
            Console.WriteLine(a); //5

            //SAU
            //for(int i = 0; i <= 5; i = i + 2)
            //{
            //    Console.WriteLine(i); 
            //}

            //Console.WriteLine("3 5 7 9");

            //for - exercitiu
            for(int i = 3; i < 10; i += 2)
            {
                Console.Write(i + " ");
            }

            //while - exercitiu
            int j = 3;
            while (j < 10)
            {
                Console.Write(j + " ");
                j = j + 2; //j += 2;
            }

            //do..while - exercitiu
            int k = 3;
            do
            {
                Console.Write(k + " ");
                k += 2;
            } while (k < 10);



            for (int i = 0; i <= 5; i = i + 2)
            {
                Console.WriteLine(i);
            }

            j = 0;
            while(j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }

            k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while(k <= 5);

            //Afisati "3 5 7 9" cu while si do while

            //-----------------------------//
            Console.WriteLine("Va rugam introduceti un numar");
            string mesaj2 = Console.ReadLine();
            int numar = int.Parse(mesaj2);

            const double PI = 3.1415;

            if(numar == (int)ZileSaptamana.Luni)
            {
                Console.WriteLine("Mga buwan");
            }
            else if (numar == (int)ZileSaptamana.Joi)
            {
                Console.WriteLine("Huwebes");
            }
            else if (numar == (int)ZileSaptamana.Duminica)
            {
                Console.WriteLine("Linggo");
            }
            else if (numar == (int)ZileSaptamana.Miercuri)
            {
                Console.WriteLine("Miyerkules");
            }
            else if (numar == (int)ZileSaptamana.Vineri)
            {
                Console.WriteLine("Biyernes");
            }
            else if (numar == (int)ZileSaptamana.Marti)
            {
                Console.WriteLine("Martes");
            }
            else if (numar == (int)ZileSaptamana.Sambata)
            {
                Console.WriteLine("Sabado");
            }
            else
            {
                Console.WriteLine("Nu este o zi a saptamanii");
            }

            switch(numar)
            {
                case (int)ZileSaptamana.Luni:
                    Console.WriteLine("Luni");
                    break;
                case (int)ZileSaptamana.Marti:
                    Console.WriteLine("Marti");
                    break;
                case (int)ZileSaptamana.Miercuri:
                    Console.WriteLine("Miercuri");
                    break;
                case (int)ZileSaptamana.Joi:
                    Console.WriteLine("Joi");
                    break;
                case (int)ZileSaptamana.Vineri:
                    Console.WriteLine("Vineri");
                    break;
                case (int)ZileSaptamana.Sambata:
                case (int)ZileSaptamana.Duminica:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Nu este o zi a saptamanii");
                    break;
            }
            const int numarMaxim = 10;


            for(int i = 0; i < numarMaxim; i++)
            {
                if(i == 5)
                {
                    break;
                }
                Console.Write(i + " ");
            }

            Console.Write("am ajuns la final");   //0 1 2 3 4 am ajuns la final

            //afisati toate numerele de la 0 la 9 FARA 5
            for (int i = 0; i < numarMaxim; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.Write("am ajuns la final");

        }
    }
}
