using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class SalaryWorker
    {
        static void Main()
        {
            BACK:
            Console.Clear();
            long totalTime;
            Console.Write("Enter Total Time =");
            totalTime = long.Parse(Console.ReadLine());

            if(totalTime >= 0)
            {
                double basicSalary = 50, totalSalary;
                if (totalTime >= 100)
                {
                    //report 1
                    long extraT1, extraT2;
                    double bRate1 = 1.25, bRate2 = 1.5;
                    double bSalary;
                    long extraTotal = totalTime - 100;
                    if (extraTotal <= 20)
                    {
                        extraT1 = extraTotal;
                        extraT2 = 0;
                    }
                    else
                    {
                        extraT1 = 20;
                        extraT2 = extraTotal - 20;
                    }
                    bSalary = (extraT1 * bRate1) + (extraT2 * bRate2);
                    totalSalary = basicSalary + bSalary;

                    Console.WriteLine("==============================");
                    Console.WriteLine($"Basic Salary = {basicSalary:c2}");
                    Console.WriteLine($"Extra Time1 = {extraT1} h");
                    Console.WriteLine($"Extra Time2 = {extraT2} h");
                    Console.WriteLine($"Bonus Rate 1 = {bRate1:c2}/h");
                    Console.WriteLine($"Bonus Rate 2 = {bRate2:c2}/h");
                    Console.WriteLine($"Bonus Salary = {bSalary:c2}");
                    Console.WriteLine("================================");
                    Console.WriteLine($"Total Salary ={totalSalary:c2}");
                }
                else
                {
                    //report 2
                    double lRate = 0.5;
                    double lostSalary = (100 - totalTime) * lRate;

                    totalSalary = basicSalary- lostSalary;
                    Console.WriteLine($"Basic Salary = {basicSalary:c2}");
                    Console.WriteLine($"Lost Rate = {lRate:c2}/h");
                    Console.WriteLine($"Lost Salary = {lostSalary:c2}");
                    Console.WriteLine("=================================");
                    Console.WriteLine($"Total Salary ={totalSalary:c2}");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ReadKey();

                double rate;
                Console.Write("Enter Rate of R = ");
                rate = double.Parse( Console.ReadLine() );

                TaxMonthSalary.Mainf(totalSalary * rate);
            }
            else
            {
                Console.WriteLine("Invalided Input");
            }
            //invalided input
            //Console.ReadKey();

            //repeat program user easy to use
            CONFI:
            char ch;
            Console.Write("Do you want to continue [Y/N]=");
            ch= char.Parse( Console.ReadLine().ToUpper());

            switch( ch )
            {
                case 'Y':
                    goto BACK;
                case 'N':
                    goto END;
                default:
                    goto CONFI;
            }
        END:;
        }
    }
}
