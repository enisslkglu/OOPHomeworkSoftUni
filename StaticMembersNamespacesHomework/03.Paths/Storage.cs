using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mime;
using System.Text.RegularExpressions;
using _01.Point3D;

namespace _03.Paths
{
    class Storage
    {
        public static void SavePath(string file, string path)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLineAsync(path);
            }
        }

        public static Path3D LoadPath(string file)
        {
            Path3D load = new Path3D();

            using (StreamReader reader = new StreamReader(file))
            {
                string textLine = reader.ReadLine();
                const string pattern = @"[xyz=:\-\s](\d(?:(?:\.|\,)\d+)*)";
                while (textLine != null)
                {
                    MatchCollection matchPattern = Regex.Matches(textLine, pattern);
                    if (matchPattern.Count == 3)
                    {
                        double x = double.Parse(matchPattern[0].Groups[1].Value);
                        double y = double.Parse(matchPattern[1].Groups[1].Value);
                        double z = double.Parse(matchPattern[2].Groups[1].Value);
                        Point3D point = new Point3D(x, y, z);
                        load.AddCoord(point);
                    }

                    textLine = reader.ReadLine();
                }

                
            }
            return load;
            
        }

    }
}
