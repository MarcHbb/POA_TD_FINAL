using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class CircleSVG : DrawSVG
    {
        private string coordX, coordY, radius;

        public CircleSVG (string CoordX, string CoordY, string Radius, string Style)
            : base (Style)
        {
            this.coordX = CoordX;
            this.coordY = CoordY;
            this.radius = Radius;
        }
    }
}
