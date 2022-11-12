using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP03
{
    public class Point
    {
        private double x;
        private double y;
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double ClaculateDistance(Point point)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
            return distance;
        }
        public bool EqaulsTo(ref Point point)
        {
            return (this.x == point.x) && (this.y == point.y);
        }
        public Point Translation(double x = 0, double y = 0)
        {
            this.x += x;
            this.y += y;
            return this;
        }
        public bool Linearity(Point a, Point b)
        {
            //double determinant = (b.GetX() - this.GetX() * (c.GetY() - this.GetY()) - (c.GetY() - this.GetX()) * (b.GetY() - this.GetY()));
            //return determinant == 0;
            double area = x * (a.y - b.y) + a.x * (b.y - y) + b.x * (y - a.y);
            return (area == 0);
        }

    }
    class Exercise_1
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(2, 5);
            Point p2 = new Point(3, 8);
            Point p3 = new Point(1, 2);
            Console.WriteLine("p1({0},{1}) ",p1.GetX(),p1.GetY());
            Console.WriteLine("p2({0},{1}) ",p2.GetX(), p2.GetY());
            Console.WriteLine("the distance between p1 and p2 : " + p1.ClaculateDistance(p2));
            Console.Write("Linearity between p1({0},{1}) and p2({2},{3}) and p3({4},{5}) : ", p1.GetX(), p1.GetY(), p2.GetX(), p2.GetY(), p3.GetX(), p3.GetY());
            if (p1.Linearity(p2,p3))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}
