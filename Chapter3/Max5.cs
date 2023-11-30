using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Max5
    {
        static void Mainx()
        {
            double a, b, c, d, e;

            Console.Write("Enter a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter c=");
            c = double.Parse(Console.ReadLine());
            Console.Write("Enter d=");
            d = double.Parse(Console.ReadLine());
            Console.Write("Enter e=");
            e = double.Parse(Console.ReadLine());

            double max = a;
            if (max<b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }
            if (max < e)
            {
                max = e;
            }
            else
                Console.WriteLine($"is {max}");


            Console.ReadKey();
        }
    }
}
