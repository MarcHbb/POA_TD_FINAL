using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class PolygonSVG : DrawSVG
    {
        private string points;

        public PolygonSVG (string Points, string Style)
            : base (Style)
        {
            this.points = Points;
        }
    }
}
