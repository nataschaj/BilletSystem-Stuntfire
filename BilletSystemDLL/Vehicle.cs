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
        public bool HarBrobizz { get; set; }
        public int BrobizzRabat { get; set; }
            
        public Vehicle(string nummerplade, DateTime dato, bool harBrobizz)
        {
            this.Dato = dato;
            this.HarBrobizz = harBrobizz;

            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("En nummerplade må max bestå af 7 tegn");
            }
            else
            {
                this.Nummerplade = nummerplade;
            }
        }

        public Vehicle(string nummerplade)
        {
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("En nummerplade må max bestå af 7 tegn");
            }
            else
            {
                this.Nummerplade = nummerplade;
            }
        }

        public Vehicle(bool harBrobizz)
        {
            this.HarBrobizz = harBrobizz;
        }

        public Vehicle(DateTime dato)
        {
            Dato = dato;
        }

        public abstract int Pris();

        public abstract string Køretøj();

        //public string TjekNummerplade(string nummerplade)
        //{
        //    if (nummerplade.Length > 7)
        //    {
        //        throw new ArgumentException("En nummerplade må max bestå af 7 tegn");
        //    }
        //    else return nummerplade;
        //}

        //public int HarDuBrobizz(bool harBrobizz)
        //{
        //    int nyPris = Pris();

        //    if (harBrobizz == true)
        //    {
        //        nyPris = Pris() * (95/100);
        //    }
        //    return nyPris;
        //}
    }
}
