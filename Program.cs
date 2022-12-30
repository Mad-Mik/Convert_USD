using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double UsdToRub = 66.11;
                double UsdToAmd = 390;
                double USD;

                try
                {
                    Console.WriteLine("Write Value in USD");
                    USD = double.Parse(Console.ReadLine());

                    Console.WriteLine(USD + " USD in RUB = " + USD * UsdToRub);
                    Console.WriteLine(USD + " USD in AMD = " + USD * UsdToAmd);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unknown Value");
                    Console.ReadLine();
                    continue;
                }
                Console.ReadLine();
            }
        }
    }
}
