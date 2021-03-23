using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    class Vierkant : GeometricFigure
    {

        public Vierkant( int breedte, int hoogte)
        { 
            if (breedte != hoogte)
            {
                Breedte = breedte;
                Hoogte = breedte;
            }
            else
            {
                Breedte = breedte;
                Hoogte = hoogte;
            }

            
            
        }
         
        public Vierkant( int zijde)
        {
            Breedte = zijde;
            Hoogte = zijde;
        }
        public override double Oppervlak()
        {
           
            return Breedte * Hoogte;
        }

    }
}
