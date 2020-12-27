using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeWalking
{
    class Point
    {
        private double x;
        private double y;
        public Point (double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX() => x;
        public double GetY() => y;
        public bool Equals(Point p) => p.x == x && p.y == y;
        public double GetDistance (Point p)
        {
            double len = Math.Abs(x - p.x);
            double width = Math.Abs(y - p.y);
            return Math.Sqrt(len * len + width * width);
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
