using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek = new Rechthoek(3,9);
            Console.WriteLine("rechthoek  " + rechthoek.Oppervlak());
            Vierkant vierkant = new Vierkant(5);
            Console.WriteLine("vierkant  " + vierkant.Oppervlak());
            Driehoek driehoek = new Driehoek(9,5);
            Console.WriteLine("driehoek  " + driehoek.Oppervlak());
            Console.ReadLine();



        }

        
    }
}
