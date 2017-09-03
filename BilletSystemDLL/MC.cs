using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC : Vehicle
    {
        public MC()
        {
        }

        public MC(string nummerplade, DateTime dato, bool harBrobizz) : base(nummerplade, dato, harBrobizz)
        {
        }

        public override string Køretøj()
        {
            return "MC";
        }

        public override int Pris(bool harBrobizz)
        {
            return 125;
        }
    }
}
