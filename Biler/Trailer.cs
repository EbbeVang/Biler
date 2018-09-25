using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Trailer
    {
        private String load = "";
        private bool full;
        private int antalDimser = 0;

        // denne metode tager det oprindelige load og tilføjer
        // et komma efterfulgt at hvad man bruger som load parameter
        public void fillTrailer(String load)
        {
            antalDimser++; // increment by one
            if (antalDimser >= 4)
            {
                full = true;
            }

            if (full == false)
            {
                if (this.load != "") this.load = this.load + ", " + load;
                else this.load = load;
            }
        }

        public override string ToString()
        {
            return "Traileren indeholder " + load;
        }
    }
}
