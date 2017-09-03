using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil : Vehicle
    {
        public Bil()
        {
        }

        public Bil(bool harBrobizz):base(harBrobizz)
        {

        }

        public Bil(string nummerplade, DateTime dato, bool harBrobizz):base(nummerplade, dato, harBrobizz)
        {
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public override int Pris(bool harBrobizz)
        {
            int BroPris = 240;

            if (harBrobizz == true)
            {
                BroPris = 240 * 95 / 100;
            }
            //else if (harBrobizz == false)
            //{
            //    BroPris = 240;
            //}
            return BroPris;
        }
    }
}
