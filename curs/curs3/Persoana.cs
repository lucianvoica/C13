using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{
    public class Persoana
    {
        private bool esteBarbat;
        public string adresa;

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        protected string CNP { get; set; }

        public static int ProprietateStatica { get; set; }

        public Persoana()
        {
            this.Nume = "Popescu";
            this.Prenume = "Ion";
        }
        public Persoana(string prenume)
        {
            this.Prenume = prenume;
        }
        public Persoana(int varsta)
        {
            this.Varsta = varsta;
        }
        public Persoana(string nume, string prenume) : this(prenume)
        {
            this.Nume = nume;
            Console.WriteLine("Constructor persoana");
        }
        public Persoana(string prenume, int varsta)
        {
            this.Prenume = prenume;
            this.Varsta = varsta;
        }
        public Persoana(string nume, string prenume, int varsta) : this(nume, prenume)
        {
            this.Varsta = varsta;
        }

        public void AfiseazaPrenume()
        {
            Console.WriteLine("Prenumele este " + Prenume);
        }

        public void SetNumeSiPrenume(string nume, string prenume)
        {
            this.Nume = nume;
            this.Prenume = prenume;
        }

        public void PrintNumeComplet()
        {
            string numeComplet = this.GetNumeComplet();
            Console.WriteLine(numeComplet);

            //Console.WriteLine($"{prenume} {nume}");
            //Console.WriteLine(string.Format("{0} {1}", prenume, nume));
        }

        public string GetNumeComplet()
        {
            string mesaj = Prenume + " " + Nume;
            return mesaj;
        }

        public void SchimbaPrenumele(string noulPrenume)
        {
            Prenume = noulPrenume;
        }

        public void SchimbaNumeSiPrenume(string nume, string prenume = "prenume nou")
        {
            this.Nume = nume;
            this.Prenume = prenume;
        }

        public void SchimbaNumePrenumeCNP(string nume, string prenume = "PRENUME", string cnp = "CNP")
        {
            this.Nume = nume;
            this.Prenume = prenume;
        }

    }
}
