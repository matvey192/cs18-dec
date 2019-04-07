using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace A_star
{
    class Program
    {
        public static double F(Pstar point, Pstar start, Pstar end)
        {
            return Program.G(point,start) + Program.H(point,end);
        }
        public static double G(Pstar point , Pstar start)
        {
            return Math.Sqrt(Math.Pow(point.x - start.x, 2) + Math.Pow(point.y - start.y, 2));
        }
        public static double H(Pstar point, Pstar end)
        {
            return Math.Sqrt(Math.Pow(end.x - point.x, 2) + Math.Pow(end.y - point.y, 2));
        }
        public static bool Astar(Pstar start, Pstar end)
        {
            List<Pstar> Q = new List<Pstar>(); // множество вершин, которые требуется рассмотреть
            List<Pstar> U = new List<Pstar>(); // множество рассмотренных вершин
            Q.Add(start); // начало является просмотренной точкой 
            int G = 0; // Стоимость пути от начальной вершины равна нулю тк мы находимся в начале 
            while (Q.Count != 0)
            {
                Pstar current = new Pstar(); // вершина из Q с минимальным значением f
                current.x = start.x;
                current.y = start.y;
                if (current == end)
                {
                    return true;
                }
                Q.Remove(current);
                U.Add(current);
                for ()
            }

        }
        // G - Дистанция от старта до текущей точки
        // Н - Дистанция от точки END до текущей точки
        static void Main(string[] args)
        {
         
            /*
             * bool A*(start, goal):
    U = ∅
    Q = ∅
    Q.push(start)
    g[start] = 0
    f[start] = g[start] + h(start)
    while Q.size() != 0
        current = вершина из Q с минимальным значением f
        if current == goal
            return true                                           // нашли путь до нужной вершины
        Q.remove(current)
        U.push(current)
        for v : смежные с current вершины
            tentativeScore = g[current] + d(current, v)           // d(current, v) — стоимость пути между current и v 
            if v∈U and tentativeScore >= g[v]
                continue
            if v∉U or tentativeScore < g[v]
                parent[v] = current
                g[v] = tentativeScore
                f[v] = g[v] + h(v)
                if v∉Q
                    Q.push(v)
    return false
    */
        }
    }
}
