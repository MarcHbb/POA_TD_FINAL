using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class TextCSV : DrawCSV
    {
        private double x;
        private double y;
        private string contents;

        public TextCSV (double X, double Y, string Contents, int IdElement, double ValueRed, double ValueGreen,
            double ValueBlue, int Ranking)
            : base(IdElement, ValueRed, ValueGreen, ValueBlue, Ranking)
        {
            this.x = X;
            this.y = Y;
            this.contents = Contents;
        }

    }
}
