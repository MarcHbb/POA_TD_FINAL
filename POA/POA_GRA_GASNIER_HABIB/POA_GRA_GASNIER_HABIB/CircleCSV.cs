using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class CircleCSV : DrawCSV
    {
        private string idElement;
        private string coordX;
        private string coordY;
        private string radius;
        private string red;
        private string green;
        private string blue;
        private string ranking;

        public CircleCSV (string IdElement, string CoordX, string CoordY, string Radius, string Red, string Green, string Blue,
            string Ranking): base(null, null)
        {
            this.coordX = CoordX;
            this.coordY = CoordY;
            this.radius = Radius;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.ranking = Ranking;
 
        }

        public string SVG_String()
        {
            return "<circle cx=" + this.coordX + " cy=" + this.coordY + " r=" + this.radius + 
                " style=\"fill:rgb(" + this.red + "," + this.green + "," + this.blue + ")\" />";
        }
    }
}
