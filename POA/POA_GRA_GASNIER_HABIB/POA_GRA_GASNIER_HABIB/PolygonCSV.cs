using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class PolygonCSV : DrawCSV
    {
        private string idElement;
        private string points;
        private string red;
        private string green;
        private string blue;
        private string ranking;

        public PolygonCSV (string IdElement, string Points, string Radius, string Red, string Green, string Blue, 
            string Ranking, string Path_Id)
            : base(null, Path_Id)
        {
            this.idElement = IdElement;
            this.points = Points;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.ranking = Ranking;
        }

        public override string ToString()
        {
            return "<polygon points="+ this.points +
                " style=\"fill: rgb("+ this.red +","+ this.green +","+ this.blue +")\"/>";
        }
    }
}
