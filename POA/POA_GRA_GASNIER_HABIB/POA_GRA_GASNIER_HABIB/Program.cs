using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawCSV npm1 = new DrawCSV(1, 255, 20, 155, 1);
            npm1.ReadCSV();

            DrawSVG npm2 = new DrawSVG("djkdnf");
            npm2.WriteSVG();
        }
    }
}
