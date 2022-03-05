using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
     class PowerOfTwo
    {
        public static void ToGetPowerOfTwo()
        {
            Console.WriteLine("Enter number to get power of two ");
            int number = Convert.ToInt32(Console.ReadLine());

            int pft = 0;
            for(int i = 0; i < number; i++)
            {
                pft=(int)Math.Pow(2,i);
            }
            Console.WriteLine("The power of entered number is : " + pft);
        }
    }
}
