using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale
{
    public class Animal
    {
        public bool Traieste { get; set; }
        public string CuloareOchi { get; set; }
    }

    public class Pisica : Animal
    {
        public void Miauna()
        {
            Console.WriteLine("Miau!!!");
        }
    }

    public class Caine : Animal
    {
        public void Latra()
        {
            Console.WriteLine("Ham!");
        }
    }

    public class Persana : Pisica
    {

    }
    public class Birmaneza : Pisica
    {

    }
    public class Maidanez : Caine
    {

    }
    public class Pitbull : Caine
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pisica pisica = new Pisica();
            pisica.CuloareOchi = "verzi";
            pisica.Traieste = true;
            pisica.Miauna();

            Animal animal = new Animal();

            Pisica p1 = new Pisica();



           // p1 = (Pisica) animal; // eroare daca nu reuseste!!! 

            p1 = animal as Pisica; // nu mai da eroare si p1 = null;
            if (p1 != null)
            {
                //continua sa faci ce trebuie facut

            } else
            {
                //termina programul linistit
            }

            p1.Miauna();

            int a = 4;// <100
            short b = (short) a;


            Pisica p2 = new Pisica();



            p2 = new Birmaneza();



        }
    }
}
