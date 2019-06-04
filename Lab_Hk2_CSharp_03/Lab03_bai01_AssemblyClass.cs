using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyClassNamespace1
{

    public class Point
    {
        private double x, y; // field
        public Point() // constructer
        {
            x = 0;
            y = 0;
        }
        public Point(double _x, double _y)
        {
            X = _x;
            y = _y;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }
        public double X // property
        {
            get { return x; }
            set { if (value != 0) x = value; }
        }
        public double Y
        {
            get { return y; }
            set { if (value != 0) y = value; }
        }
        public void input()
        {
            Console.WriteLine("Nhap vao x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao y");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("({0} ; {1})", x, y);
        }
        public double distance(Point p)//khoảng cách giữa this và điểm B
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }
    }
}
