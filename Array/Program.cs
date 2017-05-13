using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // single array
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            // multidimensiol array
            int[,] ma1 = new int[3, 3];
            ma1[0, 0] = 10;

            // fixed position array
            int[] a2 = new int[] { 1, 2, 3, 4 };
            bool[] a3 = new bool[] { true, false, true, false };
            string[] a4 = { "one", "two", "three" };
            //a4.Length;

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("teste");
            al.Add(true);
            //al[0]

            Console.WriteLine(a4.Length);
            Console.ReadKey();
        }
    }
}
