using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class PathSVG : DrawSVG
    {
        private string path;
        
        public PathSVG (string Path, string Style)
            : base(Style)
        {
            this.path = Path;
        }
    }
}
