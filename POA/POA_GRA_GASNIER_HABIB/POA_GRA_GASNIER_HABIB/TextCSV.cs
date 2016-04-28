using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class TextCSV : DrawCSV
    {
        private string idElement;
        private string x;
        private string y;
        private string contents;
        private string red;
        private string green;
        private string blue;
        private string ranking;

        public TextCSV (string IdElement, string X, string Y, string Contents, string Red, string Green, string Blue,
            string Ranking, string Path_Id)
            : base(null, Path_Id)
        {
            this.idElement = IdElement;
            this.x = X;
            this.y = Y;
            this.contents = Contents;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.ranking = Ranking;
        }

        public override string ToString()
        {
            return "<text x=" + this.x + " y=" + this.y + 
                " style=\"fill:rgb(" + this.red + "," + this.green + "," + this.blue + ")\" />";
        }
    }
}
