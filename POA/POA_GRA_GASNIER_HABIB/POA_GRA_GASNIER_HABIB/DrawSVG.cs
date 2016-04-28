using System;
using System.IO;
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

        public void IfCons_Save()
        {
            // Compose a string that consists of three lines.
            string lines = "First line.\r\nSecond line.\r\nThird line.";

            // Write the string to a file.
            StreamWriter file = new StreamWriter(@"C:\Users\Marc\Desktop\3eme année\S6\POA\svg\test.txt");
            file.WriteLine(lines);

            file.Close();
        }

    }
}
