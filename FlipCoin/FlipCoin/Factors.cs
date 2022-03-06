using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    class Factors
    {
        public static void toFindFact()
        {
            int i, number, fact;//variables
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = 1;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();

        }
    }
}
