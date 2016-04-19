using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class TextSVG : DrawSVG
    {
        private string x, y, contents;
       
        public TextSVG (string X, string Y, string Contents, string Style)
            : base (Style)
        {
            this.x = X;
            this.y = Y;
            this.contents = Contents;
        }
    }
}
