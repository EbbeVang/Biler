using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Trailer
    {
        private String load;
        private bool full;

        // denne metode tager det oprindelige load og tilføjer
        // et komma efterfulgt at hvad man bruger som load parameter
        public void fillTrailer(String load)
        {
            this.load = load;
        }

        public override string ToString()
        {
            return "Traileren indeholder " + load;
        }
    }
}
