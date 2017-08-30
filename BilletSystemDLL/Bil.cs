using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil
    {
        public string Nummerplade;
        public DateTime Dato;

        public Bil()
        {

        }
        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }

    }
}
