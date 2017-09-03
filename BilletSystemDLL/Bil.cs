using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil : Vehicle
    {
        public Bil(string nummerplade, DateTime dato, bool harBrobizz):base(nummerplade, dato, harBrobizz)
        {
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public override int Pris()
        {
            int BroPris = 240;

            if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                BroPris = 240 * 80 / 100; //Weekend giver 20%
            }
            if (base.HarBrobizz == true)
            {
                BroPris =+ BroPris * 95 / 100; //Brobizz giver yderligere 5%
            }

            return BroPris;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
