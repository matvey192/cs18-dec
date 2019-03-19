using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CodeProject;
namespace Lab_14_num_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string er = "";
            string[] comm = new string[3];
            Rect14 x = new Rect14();
            int x1 = 100;
            int y = 100;
            int w = 100;
            int h = 100;
            int k = 0;
            string line = "";
            string x2 = Console.ReadLine();
            string ch = "task5032/test" + x2 + ".csv";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); }
            while (!sr.EndOfStream)
            {
                try
                {
                    line = sr.ReadLine();
                    comm = line.Split(';');
                    if (comm.Length < 3) { throw new ArgumentException("Некорректный формат"); }
                    else if (comm[0] == "shiftX")
                    {
                        x.ShiftX(comm[1]);
                        k++;
                    }
                    else if (comm[0] == "shiftY")
                    {
                        x.ShiftY(comm[1]);
                        k++;
                    }
                    else if (comm[0] == "stretchX")
                    {
                        x.stretchX(comm[1]);
                        k++;
                    }
                    else if (comm[0] == "stretchY")
                    {
                        x.stretchY(comm[1]);
                        k++;
                    }
                    else { throw new ArgumentException("Некорректное действие " + comm[1]); }
                }
                catch (ArgumentException e)
                {
                    er = e.Message;
                    Console.WriteLine(e.Message);
                }
            }
            {
                string name = "out.html";
                StreamWriter write = new StreamWriter(name);
                write.WriteLine(@"<!DOCTYPE html>
<html >
<head >
<meta charset = ""utf-8""/>
<head />
<body >
<h1 > Действий  ""{8}"" </ h1 >
<h1 >""{9}"" </h1>
<svg width = ""800"" height = ""600"" >

    <rect x = ""{0}"" y=""{1}"" width = ""{2}"" height = ""{3}"" stroke=""black"" stroke-width=""4"" fill = ""white""opacity=""0.7"" />
    <rect x = ""{4}"" y=""{5}"" width = ""{6}"" height = ""{7}"" stroke=""red"" stroke-width=""4"" fill = ""white""opacity=""0.5"" />
</svg >
</body >
</html >", x1, y, w, h ,x.x ,x.y ,x.w ,x.h,k,er);
                write.Close();
                System.Diagnostics.Process.Start(name);
            }
            sr.Close();
        }
    }
}
