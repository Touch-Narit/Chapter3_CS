using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program
    {
        static void Mainx(string[] args)
        {
            //chapter is use the control statement
            int a = -10;
            int b = -10;
            int c = 10;

            if(a > 0 && b > 0)
            {
                Console.WriteLine("Statement 1");
            }
            else if (a > 0)
            {
                Console.WriteLine("Statement 2");
            }
            else if (c > 0)
            {
                Console.WriteLine("Statement 3");
            }
            else
            {
                Console.WriteLine("Statement 4");
            }

            //if (a > 0)
            //{
            //    if (b > 0)
            //    {
            //        Console.WriteLine("Statement 1");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Statement 2");
            //    }
            //}
            //else
            //{
            //    if(c > 0)
            //    {
            //        Console.WriteLine("Statement 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Statement 4");
            //    }
            //}

            Console.ReadKey();
        }
    }
}
