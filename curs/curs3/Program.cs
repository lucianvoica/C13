using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persoana Ana;
            //Ana = new Persoana();
            //Persoana Bia = new Persoana();

            //Student s1;
            //Student s2 = new Student();
            //s1 = new Student();

            //Elev e1 = new Elev();
            //Persoana p3 = new Persoana();

            //p3.SetNumeSiPrenume("popescu", "ion");

            //p3.AfiseazaPrenume(); //ion

            //p3.SchimbaPrenumele("vasile");

            //p3.AfiseazaPrenume(); //vasile

            //p3.PrintNumeComplet(); //vasile popescu

            //p3.SchimbaPrenumele("Marcel");

            //p3.PrintNumeComplet(); //Marcel popescu


            Persoana p4 = new Persoana();
            p4.SchimbaNumeSiPrenume("Ionescu", "Ciprian");
            p4.PrintNumeComplet();
            p4.SchimbaNumeSiPrenume(prenume: "Ciprian", nume: "Ionescu");

            Persoana p5 = new Persoana();
            p5.SchimbaNumePrenumeCNP("NUME", "PRENUME", "1000");
            p5.PrintNumeComplet();

            string numeCompletP5 = p5.GetNumeComplet();
            Console.WriteLine(numeCompletP5);

            Persoana p6 = new Persoana();
            //p6.SetPrenume("Marcel");
            //Console.WriteLine(p6.GetPrenume());

            Persoana pers1 = new Persoana();
            //pers1.SetNume("DO_IT_ACADEMY");
            pers1.Nume = "DO_IT_ACADEMY";
            pers1.Prenume = "Cursant";
            pers1.Varsta = 20;
            pers1.Cnp = "12345678234";
            pers1.EsteBarbat = true;

            Console.WriteLine(
                pers1.Prenume + " " +
                pers1.Nume + ", " +
                pers1.Varsta + " ani"
            );

            pers1.Nume = "Popescu";
            Console.WriteLine(pers1.Nume);
        }
    }
}