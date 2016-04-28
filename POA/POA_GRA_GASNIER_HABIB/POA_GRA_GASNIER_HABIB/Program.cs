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
            List<String[]> npm = new List<String[]>();
            DrawCSV npm1 = new DrawCSV(npm,@"C:\Users\Marc\Desktop\3eme année\S6\POA\svg\exemple4.csv");
            npm1.ReadCSV();
            List<DrawCSV> liste = npm1.Convert_ListStr();

            foreach (DrawCSV k in liste)
            {
                if (k is CircleCSV)
                {
                    Console.WriteLine("circle");
                }
            }


            Console.ReadKey();

            //DrawSVG npm2 = new DrawSVG("djkdnf");
        }
    }
}
