using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            string name = "out.html";
            StreamWriter write = new StreamWriter(name);
            write.WriteLine(@"<!DOCTYPE html>
<html >
<head >
<meta charset = ""utf-8""/>
<head />
<body >
<h1 > Мой первый векторный рисунок </ h1 >

<svg width = ""800"" height = ""600"" >

    <rect x = ""{2}"" y=""{3}"" width = ""{0}"" height = ""{1}"" fill = ""red"" />
</svg >
</body >
</html >", x,y,w,h);
            write.Close();
            System.Diagnostics.Process.Start(name);
        }
    }
}
