using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
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

    <circle cx = ""{0}"" cy = ""{1}"" r = ""{2}"" stroke = ""green"" stroke-width = ""{3}"" fill = ""yellow"" />
</svg >
</body >
</html >",cx,cy,r,w);
            write.Close();
            System.Diagnostics.Process.Start(name);
        }
    }
}
