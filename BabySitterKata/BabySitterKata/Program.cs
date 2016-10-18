using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BabySitterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            CompensationCalculator Compensation = new CompensationCalculator();
            string x = "";

            while (x != "x")
            {
                Console.WriteLine("Calculate Baby sitter's Compensation");
                Console.WriteLine("Please insert Start hour, only the hour value: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert end hour, only the hour value: ");
                int end = Convert.ToInt32(Console.ReadLine());
                decimal comp = Compensation.calc(start, end);
                Console.WriteLine("The Baby sitter is due $ " + comp);
                Console.WriteLine();
                Console.WriteLine("insert 'x' to close any other key to continue");
                x = Console.ReadLine();
            }
            
        }
    }
}
