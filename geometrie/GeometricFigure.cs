using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    abstract class GeometricFigure
    {

        protected double vlak;

        public double Vlak
        {
            get { return vlak; }
        
        }

       public int Breedte { get; set; }
        public int Hoogte { get; set; }

       


        public abstract double Oppervlak();
 
    }
}

