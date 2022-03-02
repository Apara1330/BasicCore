using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Leap_Year
    {
        public static void Year()
        {
            Console.WriteLine("Enter the year");//taking year from user
            int Yearis = int.Parse(Console.ReadLine());

            if (Yearis.ToString().Length != 4)
            {
                Console.WriteLine("Please enter valid year");//if entered year is invalid
            }
            else if (((Yearis % 4 == 0) && (Yearis % 100 != 0)) || (Yearis % 400 == 0))
            {
                Console.WriteLine(" " + Yearis + " Year is Leap Year");
            }
            else
            {
                Console.WriteLine(" " + Yearis + " Year is not Leap Year");
            }
        }
    }
}

