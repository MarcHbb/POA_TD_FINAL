using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class PathCSV : DrawCSV
    {
        private string idElement;
        private string path_CSV;
        private string red;
        private string green;
        private string blue;
        private string ranking;

        public PathCSV(string IdElement, string Path_CSV, string Red, string Green, string Blue, string Ranking, string Path_Id)
            : base (null, Path_Id)
        {
            this.idElement = IdElement;
            this.path_CSV = Path_CSV;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.ranking = Ranking;
        }

        public override string ToString()
        {
            return "<path d=" + this.path_CSV + " style=\"fill:rgb(" + this.red + "," + this.green + "," + this.blue + ")\" />";
        }
    }
}
