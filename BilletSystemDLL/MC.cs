using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC : Vehicle
    {
        public MC(string nummerplade, DateTime dato, bool harBrobizz, string hvilkenBro)
            : base(nummerplade, dato, harBrobizz, hvilkenBro)
        {
        }

        public override string Køretøj()
        {
            if (base.HvilkenBro == "Øresund")
            {
                return "MC Øresund";
            }
            return "MC";
        }

        public override int Pris()
        {
            if (base.HvilkenBro == "Storebælt")
            {
                int BroPris = 125;

                if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
                {
                    BroPris = 125 * 80 / 100; //Weekend giver 20%
                }
                if (base.HarBrobizz == true)
                {
                    BroPris = +BroPris * 95 / 100; //Brobizz giver yderligere 5%
                }

                return BroPris;
            }
            else  //Hvis vi kører over Øresundsbroen
            {
                if (base.HvilkenBro == "Øresund" && base.HarBrobizz == true)
                {
                    return 73;
                }

                return 210;
            }
        }
    }
}
