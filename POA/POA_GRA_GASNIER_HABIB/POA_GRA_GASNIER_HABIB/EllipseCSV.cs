using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class EllipseCSV : DrawCSV
    {
        private string idElement;
        private string coordX;
        private string coordY;
        private string radiusX;
        private string radiusY;
        private string red;
        private string green;
        private string blue;
        private string ranking;

        public EllipseCSV (string IdElement, string CoordX, string CoordY, string RadiusX, string RadiusY, string Radius,
            string Red, string Green, string Blue, string Ranking, string Path_Id)
            : base(null, Path_Id)
        {
            this.idElement = IdElement;
            this.coordX = CoordX;
            this.coordY = CoordY;
            this.radiusX = RadiusX;
            this.radiusY = RadiusY;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.ranking = Ranking;
        }

        public override string ToString()
        {
            return "<ellipse cx=" + this.coordX + " cy=" + this.coordY + " rx=" + this.radiusX + " ry=" + this.radiusY +
                " style=\"fill:rgb(" + this.red + "," + this.green + "," + this.blue + ")\" />";
        }
    }
}
