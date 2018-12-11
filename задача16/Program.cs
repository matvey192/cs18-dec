using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача16
{
    class Program
    {
        static void Main(string[] args)
        { string start = "Самуил Маршак.Дом, который построил Джек.\n\nВот дом,\nКоторый построил Джек.\n\n";
            string j = "Которая в тёмном чулане хранится\nВ доме,\nКоторый построил Джек.\n\n";
            string v = "Которая часто ворует пшеницу,\n" + j, c = "Который пугает и ловит синицу,\n" + v;
            string d = "Который за шиворот треплет кота,\n" + c;
            string cow = "А это корова безрогая,\nЛягнувшая старого пса без хвоста,\n";
            string cow1 = "Которая доит корову безрогую,\nЛягнувшую старого пса без хвоста,\n"+d;
            string pas = "Который бранится с коровницей строгою,\n"+cow1, p = "Которые будят того пастуха,\n" + pas;
     Console.WriteLine(@start+"А это пшеница,\n"+j+"А это весёлая птица - синица,\n"+v+ "Вот кот,\n"+c+
     "Вот пёс без хвоста,\n"+d+cow+d+ "А это старушка, седая и строгая,\n"+cow1+"А это ленивый и толстый пастух,\n"+
     pas+"Вот два петуха,\n"+p);
        }
    }
}
