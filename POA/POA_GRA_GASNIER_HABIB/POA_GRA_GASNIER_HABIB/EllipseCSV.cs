using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class EllipseCSV : DrawCSV
    {
        private double coordX;
        private double coordY;
        private double radiusX;
        private double radiusY;

        public EllipseCSV (double CoordX, double CoordY, double RadiusX, double RadiusY, int IdElement, double ValueRed,
            double ValueGreen,double ValueBlue, int Ranking)
            : base(IdElement, ValueRed, ValueGreen, ValueBlue, Ranking)
        {
            this.coordX = CoordX;
            this.coordY = CoordY;
            this.radiusX = RadiusX;
            this.radiusY = RadiusY;
        }
    }
}
