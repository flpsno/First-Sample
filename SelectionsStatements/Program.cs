using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if
            int a = 10;

            if (a == 5)
                Console.WriteLine("a = 10");
            else
                Console.WriteLine("a <> 5");


            //Console.ReadKey();

            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 0:
                    Console.WriteLine("c==0");
                    break;
                case 1:
                    Console.WriteLine("c==1");
                    break;

                default:
                    Console.WriteLine("c default");
                    break;
            }

            Console.ReadKey();


        }
    }
}
