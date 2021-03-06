﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
    public class Range
    {
        private int from;
        private int to;
        public override bool Equals(object Object)
        {
            if (Object == null) return false;
            if (GetType() != Object.GetType()) return false;
            Range r = (Range)Object;
            if (from == r.from && to == r.to) return true;
            if (this == Object) return true;
            return false;
        }

        public override string ToString()
        {
            return "["+this.from+";"+this.to+"]";
        }
        //13
        public  void shift(int a)
        {
            this.from = this.from + a;
            this.to = this.to + a;
        }

        public  void squeeze(int a)
        {
            if (a > this.to)
            {
                throw new ArgumentException("Error");
            }
            this.to = this.to - a;
        }
        public bool Intersects(int ar, int br)
        {
            int i = 0;
            int kx;
            int min;
            if (this.from > this.to )
            {
                throw new ArgumentException("Error");
            }
            else  if (ar>br)
            {
                throw new InvalidOperationException("Error");
            }
            if (this.from < ar)
            {
                min = this.to - this.from;
                kx = this.from;
                while (i <= min)
                {
                    if (kx == ar) { return true; }
                    kx++;
                    i++;
                }
            }
            else if (ar < this.from)
            {
                min = br - ar;
                kx = ar;
                while (i <= min)
                {
                    if (kx == this.from) { return true; }
                    kx++;
                    i++;
                }
            }
            return false;
        }
        public static bool HasIntersection(Range a, Range b)
        {
            int i = 0;
            int kx;
            int min;
            if (a.from>a.to||b.from>b.to)
            {
                throw new ArgumentException("Подкоренное выражение должно быть неотрицательно");
            }
            if (a.from < b.from)
            {
                min = a.to - a.from;
                kx = a.from;
                while (i <= min)
                {
                    if (kx == b.from) { return true; }
                    kx++;
                    i++;
                }
            }
            else if (b.from < a.from)
            {
                min = b.to - b.from;
                kx = b.from;
                while (i <= min)
                {
                    if (kx == a.from) { return true; }
                    kx++;
                    i++;
                }
            }
            return false;
        }
        public  void Init(int f, int t)
        {
            if (f>=t)
            {
                throw new ArgumentException("Error");
            }
            this.from = f;
            this.to = t;
        }
    }
}
