using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class RectangleSVG : DrawSVG
    {
        private string x, y, height, width;
       
        public RectangleSVG (string X, string Y, string Height, string Width, string Style)
            : base (Style)
        {
            this.x = X;
            this.y = Y;
            this.height = Height;
            this.width = Width;
        }
    }
}
