using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public abstract class Vehicle
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string nummerplade, DateTime dato)
        {
            this.Nummerplade = nummerplade;
            this.Dato = dato;
        }

        public abstract int Pris();

        public abstract string Køretøj();

        public string TjekNummerplade(string nummerplade)
        {
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("En nummerplade må max bestå af 7 tegn");
            }
            else return nummerplade;
        }
    }
}
