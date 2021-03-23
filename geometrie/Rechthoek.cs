using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    class Rechthoek : GeometricFigure
    {
       
        public Rechthoek(int breedte, int hoogte)
        {
            Hoogte = hoogte;
            Breedte = breedte;
        }

       
        public override double Oppervlak()
        {
            vlak = Breedte * Hoogte;
            return vlak;
        }

       
    }
}
