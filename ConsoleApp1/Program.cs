using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int a = int.Parse(Console.ReadLine());
            
            int x = 20, y = 20;
            switch(a)
            {
                case 1:
                    Console.WriteLine("sum is :" +(x+y));
                    break;
                case 2:
                    Console.WriteLine("difference is "+( x - y));
                    break;
                case 3:
                    Console.WriteLine("product is :"+ (x * y));
                    break;
                default:
                                        Console.WriteLine("invalid input");
                    break;
            }
            //here break will helps come out of the loop which mean it doesnot execute above brace

        }
    }
}
