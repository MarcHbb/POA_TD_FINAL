using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class DrawSVG
    {
        private string style;

        public DrawSVG (string Style)
        {
            this.style = Style;
        }

        public void WriteSVG()
        {

            // Compose a string that consists of three lines.
            string lines = "First line.\r\nSecond line.\r\nThird line.";

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Marc\Desktop\3eme année\S6\POA\svg\test.txt");
            file.WriteLine(lines);

        }

    }
}
