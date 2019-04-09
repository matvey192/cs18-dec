using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lub_15_num_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string ch = "task7657/test" + x + ".csv";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); }
            int res = 0;
            int err = 0;
            Dictionary<Node, int> row = new Dictionary<Node, int>();
            while (!sr.EndOfStream)
            {
                Node pts = new Node();
                string line = sr.ReadLine();
                string[] line1 = line.Split(';');
                try
                {
                    if (line1[0] == null||line1[1]==null||line[2]==null)
                    {
                        throw new FormatException();
                    }
                    pts.Set1(int.Parse(line1[0]), int.Parse(line1[1]), line1[2]);
                }
                if (row.ContainsKey(pts))
                {
                    res = row[pts];
                    res += 1;
                    row.Remove(pts);
                    row.Add(pts, res);
                }
                else
                {
                    row.Add(pts, 1);
                }
                  catch (FormatException e)
                {
                    err++;
                }
                catch(ArgumentException e1)
                {
                    err++;
                }
            }
            sr.Close();

        }
    }
}
