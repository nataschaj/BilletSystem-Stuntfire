using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC
    {
        public string Nummerplade;
        public DateTime Dato;

        public MC()
        {

        }
        public int Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
