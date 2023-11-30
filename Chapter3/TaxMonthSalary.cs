using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class TaxMonthSalary
    {
        public static void Mainf(double salary)
        {
            double bonus;
            int spouse, children;

            Console.WriteLine($"Salary in Riel = {salary} ");

            //salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Bonus = ");
            bonus = double.Parse(Console.ReadLine());
            Console.Write("Enter Spouse = ");
            spouse = int.Parse(Console.ReadLine());
            Console.Write("Enter Children = ");
            children = int.Parse(Console.ReadLine());

            if (salary >= 0 && bonus >= 0)
            {
                if (spouse >= 1)
                {
                    spouse = 1;
                }
                else
                {
                    spouse =0;
                }

                if(children >= 9)
                {
                    children = 9;
                }
                else if(children <= 0)
                {
                    children = 0;
                }
                double family = 150000 * (spouse + children);
                double tax, lastsalary;

                salary = salary - family;
                if(salary <= 1200000)
                {
                    tax = 0;
                }
                else if(salary <= 2000000)
                {
                    tax = salary * 0.05 - 60000;
                }
                else if(salary <= 85000000)
                {
                    tax = salary * 0.1 - 160000;
                }
                else if(salary <= 1200000)
                {
                    tax = salary * 0.15 - 585000;
                }
                else
                {
                    tax = salary * 0.2 - 1210000;
                }

                tax += bonus * 0.2; //+= add thaem

                lastsalary = (salary + family + bonus) - tax;

                Console.WriteLine("=======================");
                Console.WriteLine($"Tax    ={tax:#,##0.## R}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Last Salary ={lastsalary:#,##0.## R}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Invalided Input");
            }

            Console.ReadKey();
        }
    }
}
