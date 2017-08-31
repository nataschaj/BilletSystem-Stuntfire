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

        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        public override string Køretøj()
        {
            return "MC";
        }

        public override int Pris()
        {
            return 125;
        }
    }
}
