using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class CircleCSV : DrawCSV
    {
        private double coordX;
        private double coordY;
        private double radius;

        public CircleCSV (double CoordX, double CoordY, double Radius, int IdElement, double ValueRed, double ValueGreen,
            double ValueBlue, int Ranking) 
            : base (IdElement, ValueRed, ValueGreen, ValueBlue, Ranking)
        {
            this.coordX = CoordX;
            this.coordY = CoordY;
            this.radius = Radius;

        }

    }
}
