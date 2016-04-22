using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class DrawCSV
    {
        private int idElement;
        private double valueRed;
        private double valueGreen;
        private double valueBlue;
        private int ranking;

        public DrawCSV(int IdElement, double ValueRed, double ValueGreen, double ValueBlue, int Ranking)
        {
            this.idElement = IdElement;
            this.valueRed = ValueRed;
            this.valueGreen = ValueGreen;
            this.valueBlue = ValueBlue;
        }


        public int IdElement
        { get { return idElement; } }

        public double ValueRed
        { get { return ValueRed; } }

        public double ValueGreen
        { get { return ValueRed; } }

        public double ValueBlue
        { get { return ValueRed; } }

        public int Ranking
        { get { return Ranking; } }



        public void ReadCSV()
        {
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(@"C:\Users\Marc\Desktop\3eme année\S6\POA\svg\ExempleTout.csv");
            List<String> list_str = new List<String>();
            while ((line = file.ReadLine()) != null)
            {
                list_str.Add(line);
            }

            foreach (string obj in list_str)
            {

                char[] delimiterChars = { ';' };

                string text = obj;

                string[] words = text.Split(delimiterChars);

                switch(words[0])
                {
                    case "Rectangle":
                        Console.WriteLine("Rectangle");
                        break;

                    case "Cercle":
                        Console.WriteLine("Cercle");
                        break;

                    case "Ellipse":
                        Console.WriteLine("Ellipse");
                        break;

                    case "Polygone":
                        Console.WriteLine("Polygone");
                        break;

                    case "Chemin":
                        Console.WriteLine("Chemin");
                        break;

                    case "Texte":
                        Console.WriteLine("Texte");
                        break;

                    case "Rotation":
                        Console.WriteLine("Rotation");
                        break;

                    case "Translation":
                        Console.WriteLine("Translation");
                        break;

                    default: Console.WriteLine("Error, failed to recognize caracter");
                        break;
                }

          

            }

            Console.ReadKey();

        }


        
         
      

        public void StoreData()
        {
            

            
        }

    }
}
