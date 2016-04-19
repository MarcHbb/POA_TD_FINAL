using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class PathCSV : DrawCSV
    {
        private string[] path; 

        public PathCSV (string[] Path, int IdElement, double ValueRed, double ValueGreen,double ValueBlue, int Ranking)
            : base(IdElement, ValueRed, ValueGreen, ValueBlue, Ranking)
        {
            this.path = Path;
        }
    }
}
