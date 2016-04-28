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
        public List<String[]> list_value;
        private string path_Id;

        public DrawCSV(List<String[]> List_value, string Path_Id)
        {
            this.path_Id = Path_Id;
            this.list_value = List_value;
        }


  
        public List<String[]> ReadCSV()
        {
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(this.path_Id);
            List<String> list_str = new List<String>();


            while ((line = file.ReadLine()) != null)
            {
                list_str.Add(line);
            }

            foreach (string obj in list_str)
            {
                char[] delimiterChars = { ';' };
                string[] element = obj.Split(delimiterChars);

                list_value.Add(element);
            }

            foreach (string[] ok in list_value)
            {
                Console.Write("Objet :");
                for (int i = 0; i < ok.Length; i++)
                {
                    Console.WriteLine(ok[i]);
                }
            }
            return list_value;
        }
        


        public List<DrawCSV> Convert_ListStr()
        {
            List<DrawCSV> list_Obj = new List<DrawCSV>();

            foreach (string[] tab in this.list_value)
            { 
                for (int i = 0; i < tab.Length; i++)
                {
                    switch(tab[0])
                    {
                        case "Cercle":
                            CircleCSV circle = new CircleCSV(tab[1], tab[2], tab[3], tab[4], tab[5],
                                                             tab[6], tab[7], tab[8]);
                            list_Obj.Add(circle);
                            break;

                        case "Rectangle":
                            RectangleCSV rectangle = new RectangleCSV(tab[1], tab[2], tab[3], tab[4], tab[5],
                                                                      tab[6], tab[7], tab[8], tab[9], tab[10], tab[11]);
                            list_Obj.Add(rectangle);
                            break;

                        case "Ellipse":
                            EllipseCSV ellipse = new EllipseCSV(tab[1], tab[2], tab[3], tab[4], tab[5],
                                                                tab[6], tab[7], tab[8], tab[9], tab[10], tab[11]);
                            list_Obj.Add(ellipse);
                            break;

                        case "Path":
                            PathCSV path = new PathCSV(tab[1], tab[2], tab[3], tab[4], tab[5],
                                                       tab[6], tab[7]);
                            list_Obj.Add(path);
                            break;

                        case "Polygon":
                            PolygonCSV polygon = new PolygonCSV(tab[1], tab[2], tab[3], tab[4], tab[5],
                                                                tab[6], tab[7], tab[8]);
                            list_Obj.Add(polygon);
                            break;

                        case "Text":
                            TextCSV text = new TextCSV(tab[1], tab[2], tab[3], tab[4], tab[5],
                                                                tab[6], tab[7], tab[8], tab[9]);
                            list_Obj.Add(text);
                            break;

                        default:
                            break;
                    }
                }
            }

            return list_Obj;
        }
    }
}
