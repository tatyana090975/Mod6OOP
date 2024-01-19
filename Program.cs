using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6OOP
{
    class Rectangle
    {
        public int a; public int b;
        public Rectangle(int c, int d)
        {
            a = c; b = d;
        }
        public Rectangle(int c)
        {
            a = b = c;
        }
        public Rectangle()
        {
            a = 6; b = 4;
        }
        public int Square(int a, int b)
        {
            return a* b;
            
        }
    }

    internal class Program
    {
        struct Animal
        {
            public string type;
            public string name;
            public int age;
            
            public Animal(string tt, string nn, int aa)
            {
                type = tt;
                name = nn;
                age = aa;
            }
        }

        struct Time
        {
            private int hours;
            public Time(int hh)
            {
                hours = hh;
                //minutes = 20;
                //seconds = ss;
            }
            public int Hours()
            {
                return hours;
            }
            
        }
        class Pen
        {
            public string color;
            public int cost;

            public Pen()
            {
                color = "черный";
                cost = 100;
            }
            public Pen(string penColor, int costColor)
            {
                color = penColor;
                cost = costColor;
            }
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal {type = "Собака", name = "Вольт", age = 4 };


            //Time time = new Time(6);
            Console.ReadKey();

        }
        static void AddTen(ref int num)
        {
            num = num + 10;
        }
    }
}
