using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Harmonic
    {
        public static void ToPrintHarmonicNumber()
        {
            Console.WriteLine("Enter a number to print the Harmonic Number");
            int number = Convert.ToInt32(Console.ReadLine());

            double harmonicSum = 0.0;//variable
            for (int count = 0; count <= number; count++)
            {
                if (count == 0)
                    Console.WriteLine("please enter positive number");//if entered number is equal to zero then it will enter if block
                else
                    harmonicSum += 1 / (float)count;
            }
            Console.WriteLine("harmonic Number is: " + harmonicSum);
        }
    }
}