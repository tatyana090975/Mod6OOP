using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6OOP
{
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
