using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs3
{
    public class Persoana
    {
        //string prenume;
        //private int varsta;
        private string cnp;
        private bool esteBarbat;
        public string adresa;

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }

        public string Cnp
        {
            get
            {
                return cnp;
            }
            set
            {
                cnp = value;
            }
        }
        public bool EsteBarbat
        {
            get
            {
                return esteBarbat;
            }
            set
            {
                this.esteBarbat = value;
            }
        }



        //public string GetNume()
        //{
        //    return nume;
        //}
        //public void SetNume(string nume)
        //{
        //    this.nume = nume;
        //}
        //public string GetPrenume()
        //{
        //    this.nume;
        //    return prenume;
        //} 
        //public void SetPrenume(string prenume)
        //{
        //    this.prenume = prenume;
        //}
        //public int GetVarsta()
        //{
        //    return varsta;
        //}
        //public void SetVarsta(int varsta)
        //{
        //    this.varsta = varsta;
        //}
        public string GetCnp()
        {
            return cnp;
        }
        public void SetCnp(string cnp)
        {
            this.cnp = cnp;
        }
        public bool GetEsteBarbat()
        {
            return esteBarbat;
        }
        public void SetEsteBarbat(bool esteBarbat)
        {
            this.esteBarbat = esteBarbat;
        }
       

        public void AfiseazaPrenume()
        {
            Console.WriteLine("prenumele este " + Prenume);
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
            this.cnp = cnp;
        }

    }
}
