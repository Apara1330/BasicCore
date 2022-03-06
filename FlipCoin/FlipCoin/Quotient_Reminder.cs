using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
     class Quotient_Reminder
    {
        public static void number()
        {
            Console.WriteLine("Enter a Divindend Number");
            int Dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Diviser Number");
            int Diviser = int.Parse(Console.ReadLine());

            int Quotient = Dividend / Diviser;
            int Reminder = Dividend % Diviser;

            Console.WriteLine("Quotient is :" + Quotient);
            Console.WriteLine("Reminder is :" + Reminder);

        }
    }
}
