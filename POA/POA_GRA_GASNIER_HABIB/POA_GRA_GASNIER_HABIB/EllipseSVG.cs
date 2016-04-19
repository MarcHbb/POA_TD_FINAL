using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class EllipseSVG : DrawSVG
    {
        private string coordX, coordY, radiusX, radiusY;

        public EllipseSVG (string CoordX, string CoordY, string RadiusX, string RadiusY, string Style)
            : base(Style)
        {
            this.coordY = CoordX;
            this.coordY = CoordY;
            this.radiusX = RadiusX;
            this.radiusY = RadiusY;
        }
    }
}
