using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"я загадал число....а ты угадай ");
            Random r = new Random();
            int x = r.Next(1, 101);
            int y=0;

            for (int i = 0; y != x; i++)
            {
                y = Convert.ToInt32(Console.ReadLine());

                if (y == x)
                {
                    Console.WriteLine($"УГАДААААЛ! {y}");
                    Console.WriteLine($"количество попыток {i}");
                    break;
                }
                else if (y > x)
                {
                    Console.WriteLine($"НЕ УГАДАААЛ, МЕНЬШЕ");
                }
                else
                {
                    Console.WriteLine($"НЕ УГАДАААЛ, БОЛЬШЕ");

                }
            }



            Console.ReadKey();

        }
    }
}
