using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //afisam pe ecran textul "Hello, World!"
            Console.WriteLine("Numele meu este 'Lucian' ");

            /* Comentariu 
             pe mai multe
            linii */

            int a; //declarare
            a = 5; //initializare
            Console.WriteLine(a);
            int b = 10; //declare + initializare 
            Console.WriteLine(b);

            bool adevar = false; // true <- 0 = false, 1 = true

            byte numereMici = 49;  // numere intregi intre 0 si 255
            sbyte numereMiciNegative = -49; // numere intregi negative

            short numereAsaSiAsa = 32000; // numere < 32000
            ushort numereAsaSiAsaFaraSemn = 65000; // 0 < numar < 65000

            int numarIntreg = 334839434;
            uint numarIntregPozitiv = 239238; // >0 

            long numarFoarteMare = 2089347832947823;
            ulong numarFoarteMarePozitiv = 3892748328347234;

            // texte
            string text = "aici este un text";
            string unSingurCaracter = "a";

            char unSingurCaracter2 = 'a';

            // numere cu virgula
            float nr1 = 343;
            float nr2 = 343.00f;

            double nr3 = 3.5;
            double nr4 = 4d;

            decimal nr5 = 3.5M;
            decimal nr6 = 3.5m;


            // Vreau sa citesc un numar intreg si sa afisez dublul. Ex: citest 7 -> 14
            string mesajCitit = Console.ReadLine();
            //conversie !!! foarte des === Parse

            int nr7 = int.Parse(mesajCitit);

            //3 + 4; //adunare
            //3 - 4; //scadere
            //3 * 4; //inmultire
            //3 / 4; //impartire CU NUMERE INTREGI
            //3 % 4; //modulo

            // -15/4  si -15%4
            int x = -15;
            int y = 4;
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            //int z1 = ++y;  // y <- y+1, z <- y

            int z2 = y++;  // z <- y, y <- y + 1 

            Console.WriteLine(45.4 + 333.3);

            string t1 = "primul";
            string t2 = "cuvant";
            int t3 = 3; // "3"
            int t4 = 4;
            string t5 = "5";

            Console.WriteLine(t1 + t2); // primulcuvant
            Console.WriteLine(t1 + t3); // primul3

            Console.WriteLine(t3 + t4); //7

            Console.WriteLine(t3 + t4 + t1); //7primul

            Console.WriteLine(t3 + t1 + t4 + "asd" + 433 + "asopdia"); //3primul4

            Console.WriteLine(t3 + t5); //35

            bool adev = t3 < t4;
            Console.WriteLine(adev);
        }
    }
}
