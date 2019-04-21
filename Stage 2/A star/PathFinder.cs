using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star
{
    public class PathFinder
    {
        public static List<Pstar> FindPath(Pstar[,] mass, Pstar start, Pstar end)
        {
            Pstar start1 = new Pstar();
            List<Pstar> Open = new List<Pstar>(); // множество вершин, которые требуется рассмотреть
            List<Pstar> Close = new List<Pstar>(); // множество рассмотренных вершин
            Dictionary<Pstar, double> fucku = new Dictionary<Pstar, double>();
            start1.x = start.x;
            start1.y = start.y;
            start1.g = 0;
            start1.h = Program.H(start, end);
            start1.f = start.g + start.h;
            start.CameFrom = null;
            Open.Add(start1); // начало является просмотренной точкой 
            while (Open.Count!=0)
            {
                var current = Open.OrderBy(node =>
                node.f).First();
                if (current.x==end.x&&current.y==end.y)
                {
                    return GetPath(current);
                }
                Open.Remove(current);
                Close.Add(current);
                foreach (var neig in neighbour(current,start,end,mass))
                {
                    if (Close.Count(node => node.x == neig.x) > 0&& Close.Count(node => node.y == neig.y) > 0)
                    {
                        continue;
                    }
                    var openNode = Open.FirstOrDefault(node =>
                    node.x == neig.x);
                    if (openNode == null)
                    {
                        Open.Add(neig);
                    }
                    else if (openNode.g > neig.g)
                    {
                        // Шаг 9.
                        openNode.CameFrom = current;
                        openNode.g = neig.g;
                    }
                }
            }
            return null;
        }
        // Коллекция точек до данной точки (Сам путь по точкам)
        public static List<Pstar> GetPath(Pstar node)
        {
            List<Pstar> res = new List<Pstar>();
            Pstar Node = node;
            while (Node != null)
            {
                res.Add(Node);
                Node = Node.CameFrom;
            }
            res.Reverse();
            return res;
        }

        // Коллекция соседних точек 
        public static List<Pstar> neighbour(Pstar node,Pstar start, Pstar End, Pstar[,] Arr)
        {
            List<Pstar> res = new List<Pstar>();
            Pstar[] Points = new Pstar[4];
            Pstar ki = new Pstar();
            ki.x = node.x;
            ki.y = node.y;
            ki.x = ki.x + 1;
            Points[0] = ki;
            Pstar ki1 = new Pstar();
            ki1.x = node.x;
            ki1.y = node.y;
            ki1.x = ki1.x - 1;
            Points[1] = ki1;
            Pstar ki2 = new Pstar();
            ki2.x = node.x;
            ki2.y = node.y;
            ki2.y = ki2.y + 1;
            Points[2] = ki2;
            Pstar ki3 = new Pstar();
            ki3.x = node.x;
            ki3.y = node.y;
            ki3.y = ki3.y - 1;
            Points[3] = ki3;
            foreach (var point in Points)
            {
                // Проверяем, что не вышли за границы карты.
                if (point.x < 0 || point.x >= Arr.GetLength(0)) // строки
                {
                    continue;
                }
                if (point.y < 0 || point.y >= Arr.GetLength(1)) // столбцы
                {
                    continue;
                }
                Pstar neig = new Pstar();
                {
                    neig.x = point.x;
                    neig.y = point.y;
                    neig.CameFrom = node;
                    neig.g = Program.G(node, start) + 1;  // 1 - расстояние между клетками
                    neig.h = Program.H(node, End);
                    neig.f = Program.G(node, start) + 1 + Program.H(node, End);
                };
                res.Add(neig);
            }
            return res;
        }
    }
}
