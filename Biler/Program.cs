using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Program
    {
        static void Main(string[] args)
        {
            // lav et bil-objekt
            Car citroenCar = new Car("Citröen", "Cactus", 2015);

            Car audiCar = new Car("Audi", "R8", 2008, "Sort", "AB12345", true);

            Console.WriteLine(audiCar);

            Console.WriteLine("Trailer Test:");
            Trailer trailer = new Trailer();

            trailer.fillTrailer("Hækkeaffald");
            Console.WriteLine(trailer);
           
            trailer.fillTrailer("Gl. cykel");
            Console.WriteLine(trailer);

        }
    }
}
