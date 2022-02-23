using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{
    internal class Student : Persoana
    {
        public string Facultate { get; set; }
        public float Medie { get; set; }

        public Student() : base("Popescu", "Vasile")
        {
            Console.WriteLine("Constructor strudent");
            Medie = 10;
            Facultate = "Unibuc";
        }

        public Student(string nume, string prenume) : base(nume, prenume)
        {
            CNP = "39843";
            Medie = 10;
            Facultate = "Unibuc";
        }

        public void PrinteazaInformatiiComplete()
        {
            Console.WriteLine("studentul" + 
                Nume + " " + Prenume + ", CNP " + CNP +
                ", cu varsta de " + Varsta + " avand media " 
                + Medie);
        }

    }
}
