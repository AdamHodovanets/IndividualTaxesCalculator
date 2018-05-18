using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tax;
            decimal result = 0;
            Console.WriteLine("Basic Salary: ");
            decimal.TryParse(Console.ReadLine()?.Replace(",","."),out decimal basicSalary);
            Console.WriteLine("Current Salary: ");
            decimal.TryParse(Console.ReadLine()?.Replace(",", "."), out decimal currentSalary);
            Console.WriteLine($"BS: {basicSalary} | CS: {currentSalary}");

            if (currentSalary <= basicSalary)
            {
                result = currentSalary;
            }
            else if (currentSalary > basicSalary && currentSalary <= 5 * basicSalary)
            {
                result = currentSalary - (currentSalary * (decimal)0.15);
            }
            else if (currentSalary > 5 * basicSalary && currentSalary <= 10 * basicSalary)
            {
                result = OverProfit(basicSalary, currentSalary, 5, (decimal) 0.17);
            }
            else if (currentSalary > 10 * basicSalary)
            {
                result = OverProfit(basicSalary, currentSalary, 10, (decimal) 0.2);
            }
            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }

        static decimal OverProfit(decimal basicSalary,decimal currentSalary, decimal multiplier, decimal tax)
        {
            decimal salary = currentSalary - (currentSalary - 5 * basicSalary);
            decimal overTen = (currentSalary - 5 * basicSalary);
            return (salary - salary * (decimal)0.15) + (overTen - overTen * tax);
        }
    }
}
