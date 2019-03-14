using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab_14_num_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comm = new string[3];
            //Исключения
            string error = "<h2> Ошибка: Некорректный формат </h2>,";
            string error1 = "<h2> Последнее корректное состояние: </h2>,";
            int e1 = 0;
            int e2 = 0;
            int e3 = 0;
            int e4 = 0;
            int e5 = 0;

            int x = 100;
            int y = 100;
            int w = 100;
            int h = 100;
            int x11 = 100;
            int y1 = 100;
            int w1 = 100;
            int h1 = 100;
            int k = 0;
            int resx = 0;
            string line = "";
            string x1 = Console.ReadLine();
            string ch = "task5032/test" + x1 + ".csv";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); }
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                comm = line.Split(';');
                if (comm.Length == 1||comm.Length>=3)
                {
                    error = "<h2> Некорректный формат </h2>,";
                    e5 = 1;
                    goto brr;
                }
                else if (comm[0] != "stretchX" && comm[0] != "stretchY" & comm[0] != "shiftX" & comm[0] != "shiftY")
                {
                    error = "<h2> Некорректное действие: " + comm[0] + " </h2>,";
                    e5 = 1;
                    goto brr;
                }
                if (comm[0] == "shiftX")
                {
                    resx = int.Parse(comm[1]);
                    if(x<0)
                    {
                        error = "<h2> Ошибка: Координата X должна быть неотрицательной </h2>,";
                        e1 = 1;
                    }
                    x = x + resx;
                    k++;
                    if (x <= 0 || y <= 0 || w <= 0 || h <= 0)
                    {
                        x = x - resx;
                        goto brr;
                    }
                }
                else if (comm[0] == "shiftY")
                {
                    resx = int.Parse(comm[1]);
                    if (y < 0)
                    {
                        error = "<h2> Ошибка: Координата Y должна быть неотрицательной </h2>,";
                        e2 = 1;
                    }
                    y = y + resx;
                    k++;
                    if (x <= 0 || y <= 0 || w <= 0 || h <= 0)
                    {
                        y = y - resx;
                        goto brr;
                    }
                }
                else if (comm[0] == "stretchX")
                {
                    resx = int.Parse(comm[1]);
                    if (w < 0)
                    {
                        error = "<h2> Ошибка: Ширина должна быть положительной </h2>,";
                        e3 = 1;
                    }
                    w = w + resx;
                    k++;
                    if (x <= 0 || y <= 0 || w <= 0 || h <= 0)
                    {
                        w = w - resx;
                        goto brr;
                    }
                }
                else if (comm[0] == "stretchY")
                {
                    resx = int.Parse(comm[1]);
                    if (h < 0)
                    {
                        error = "<h2> Ошибка: Высота должна быть положительной </h2>,";
                        e4 = 1;
                    }
                    h = h + resx;
                    k++;
                    if(x <= 0 || y <= 0 || w <= 0 || h <= 0)
                    {
                        h = h - resx;
                        goto brr;
                    }
                }
            }
            brr:
            if (e1 == 0 && e2 == 0 && e3 == 0 && e4 == 0 && e5 == 0)
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
<h2> Результат: </h2>,

<svg width = ""800"" height = ""600"" >

    <rect x = ""{0}"" y=""{1}"" width = ""{2}"" height = ""{3}"" stroke=""black"" stroke-width=""4"" fill = ""white""opacity=""0.7"" />
    <rect x = ""{4}"" y=""{5}"" width = ""{6}"" height = ""{7}"" stroke=""red"" stroke-width=""4"" fill = ""white""opacity=""0.5"" />
</svg >
</body >
</html >", x, y, w, h, x11, y1, w1, h1, k);
                write.Close();
                System.Diagnostics.Process.Start(name);
            }
            else if (e1 == 1 || e2 == 1 || e3 == 1 || e4 == 1 || e5 == 1)
            {
                string name1 = "out1.html";
                StreamWriter write1 = new StreamWriter(name1);
                write1.WriteLine(@"<!DOCTYPE html>
<html >
<head >
<meta charset = ""utf-8""/>
<head />
<body >
<h1 > Действий  ""{8}"" </ h1 >
""{9}""
""{10}""

<svg width = ""800"" height = ""600"" >

    <rect x = ""{0}"" y=""{1}"" width = ""{2}"" height = ""{3}"" stroke=""black"" stroke-width=""4"" fill = ""white""opacity=""0.7"" />
    <rect x = ""{4}"" y=""{5}"" width = ""{6}"" height = ""{7}"" stroke=""red"" stroke-width=""4"" fill = ""white""opacity=""0.5"" />
</svg >
</body >
</html >", x, y, w, h, x11, y1, w1, h1, k, error, error1);
                write1.Close();
                System.Diagnostics.Process.Start(name1);
            }
            sr.Close();
        }
    }
}
