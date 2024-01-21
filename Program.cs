using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mod6OOP
{
    class TrafficLight
    {
        public string color;

        private void ChangeColor(string color)
        {

        }
        public string GetColor ()
        {
            return color;
        }
    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load != null && Load > 0)
            {
                Console.WriteLine("В автобусе {0} пассажиров", Load ?? 0);
            }
            else
            {
                Console.WriteLine("В автобусе нет пассажиров");
            }
        }
    }

    class Triangle
    {
        double Side1;
        double Side2;
        double Side3;

        public double TrianglePerimeter()
        {
            double TrianglePerimeter = Side1 + Side2 + Side3;
            return TrianglePerimeter;
        }
        
        public double TriangleArea()
        {
            double MaxSide1 = Math.Max(Side1, Side2);
            double MaxSide2 = Math.Max(MaxSide1, Side3);
            double p = (Side1 + Side2 + Side3) / 2;
            double H = (2 / MaxSide2) * Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            double TriangleArea = (MaxSide2 * H) / 2;
            return TriangleArea;
        }
    }

    class Square
    {
        double Side;

        public double SquareArea()
        {
            double SquareArea = Side * Side;
            return SquareArea;
        }
        public double SquarePerimeter()
        {
            double SquarePerimeter = Side * 4.0;
            return SquarePerimeter;
        }
    }

    class Circle
    {
        double Radius;

        public double Circumference()
        {
            double Circumference = 2 * Math.PI * Radius;
            return Circumference;
        }

        public double AreaCircle()
        {
            double AreaCircle = Math.PI * Math.Sqrt(Radius);
            return AreaCircle;
        }
    }


    internal class Program
    {        
        static void Main(string[] args)
        {
            Bus bus = new Bus { Load = -3};
            bus.PrintStatus();


            Console.ReadKey();
        }
        

    }
}
