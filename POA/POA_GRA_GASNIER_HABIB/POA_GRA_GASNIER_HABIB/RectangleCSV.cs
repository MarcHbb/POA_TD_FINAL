using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class RectangleCSV : DrawCSV
    {
        private double x;
        private double y;
        private double height;
        private double width;

        public RectangleCSV (double X, double Y, double Height, double Width, int IdElement, double ValueRed, double ValueGreen,
            double ValueBlue, int Ranking)
            : base(IdElement, ValueRed, ValueGreen, ValueBlue, Ranking)
        {
            this.x = X;
            this.y = Y;
            this.height = Height;
            this.width = Width;
        }
    }
}
