using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    class Driehoek : GeometricFigure
    {
        public Driehoek(int breedte, int hoogte)
        {
            Hoogte = hoogte;
            Breedte = breedte;
        }
        public override double Oppervlak()
        {
            return Hoogte * Breedte / 2;
        }
    }
}
