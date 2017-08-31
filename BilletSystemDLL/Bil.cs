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

        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public override int Pris()
        {
            return 240;
        }
    }
}
