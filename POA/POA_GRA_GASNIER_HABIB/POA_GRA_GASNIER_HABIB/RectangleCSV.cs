using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class RectangleCSV : DrawCSV
    {
        private string idElement;
        private string x;
        private string y;
        private string height;
        private string width;
        private string red;
        private string green;
        private string blue;
        private string ranking;

        public RectangleCSV (string IdElement, string X, string Y, string Height, string Width, string Radius, string Red, 
            string Green, string Blue, string Ranking, string Path_Id)
            : base(null, Path_Id)
        {
            this.idElement = IdElement;
            this.x = X;
            this.y = Y;
            this.height = Height;
            this.width = Width;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
            this.ranking = Ranking;
        }

        public override string ToString()
        {
            return "<rect x=" + this.x + " y=" + this.y + " width=" + this.width + " height=" + this.height + 
                " style=\"fill:rgb(" + this.red + "," + this.green + "," + this.blue + ")\" />";
        }
    }
}


 
