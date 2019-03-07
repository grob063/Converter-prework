using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number.");
            double currency = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            Console.WriteLine("Enter your second number.");
            double currency1 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            Console.WriteLine("Enter your third number.");
            double currency2 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            double maxium;
            double min;
            double average = (currency + currency1 + currency2) / 3;
            double total = (currency + currency1 + currency2);

            if (currency > currency2 && currency > currency1)
            {
                maxium = currency;
            }
            else if (currency1 > currency && currency1 > currency2)
            {
                maxium = currency1;
            }
            else
            {
                maxium = currency2;
            }


            if (currency < currency2 && currency < currency1)
            {
                min = currency;
            }
            else if (currency1 < currency && currency1 < currency2)
            {
                min = currency1;
            }
            else
            {
                min = currency2;
            }


            Console.WriteLine("The maxium of currency " + maxium + ".");
            Console.WriteLine("The min of currency " + min + ".");
            Console.WriteLine("The average of currecny " + average + ".");



            Console.WriteLine("US " + total + "$");
            Console.WriteLine("Swedish " + total * 10);
            Console.WriteLine("Japanese " + Math.Round(total));
            Console.WriteLine("Thai " + total);
            Console.ReadKey();
        }
    }
}
