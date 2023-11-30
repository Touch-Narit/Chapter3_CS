using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class TestSwithch
    {
        static void Mainx()
        {
            int a = 3;
            // can use switch case in the condition equal only 
            switch (a)
            {
                case 1:
                    Console.WriteLine("statement 1");
                    break;
                case 2:
                    Console.WriteLine("statement 2");
                    break;
                case 3:
                    Console.WriteLine("statement 3");
                    break;
                default:
                    Console.WriteLine("Other statement");
                    break;
            }

            //    if (a == 1)
            //    {
            //        Console.WriteLine("statement 1");
            //    }
            //    else if (a == 2)
            //    {
            //        Console.WriteLine("statement 2");
            //    }
            //    else if (a == 3)
            //    {
            //        Console.WriteLine("statement 3");
            //    }else if (a == 4)
            //    {
            //        Console.WriteLine("statement 4");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Other statement");
            //    }

            //    Console.ReadKey();
            //}
            Console.ReadKey();
        }
    }
}
