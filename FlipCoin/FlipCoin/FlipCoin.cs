using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
     class FlipCoin
    {
        public static void flipCoinPercentage()
        {
            int tailCount = 0;//initial value assigned 0
            int headCount = 0;
            Console.WriteLine("Enter your number of times ");
            int numOfTimes = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();//taking random


            for (int i = 1; i <= numOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5)//to check the condition
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Number of tails is " + tailCount + " out of " + numOfTimes);//tail count
            Console.WriteLine("Number of heads is " + headCount + " out of " + numOfTimes);//head count
            double tailPercentage = Convert.ToDouble(tailCount * 100) / numOfTimes;//formula to calculate tail percentage
            Console.WriteLine("Tail Percentage is : "+tailPercentage);
            double headPercentage = Convert.ToDouble(headCount * 100) / numOfTimes;//formula to calculate head percentage
            Console.WriteLine("Head Percentage is : "+headPercentage);
        }
        
        }
}
