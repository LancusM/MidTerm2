using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompts user for the amount of units consumed by their electricity
            double price = 0;
            Console.WriteLine("Enter the number of units consumed: ");
            double unitsUsed = Convert.ToDouble(Console.ReadLine());
            //if statement sorts the prices into each set amount of units
            if (unitsUsed <= 100)
            {
                price = unitsUsed * 0.5;
            }
            else if (unitsUsed <= 300)
            {
                //for every set of units above 100, it will ad the previous max amount, then the new amount for the next set of unit prices
                unitsUsed = unitsUsed - 100;
                price = unitsUsed * 0.75;
                price = price + 50;
            }
            else if (unitsUsed <= 500)
            {
                unitsUsed = unitsUsed - 300;
                price = unitsUsed * 1.2;
                price = price + 150 + 50;
            }
            else if (unitsUsed > 500)
            {
                //units continue adding their respecitve prices together until maxxing at 500, where it simply continues with 1.5
                unitsUsed = unitsUsed - 500;
                price = unitsUsed * 1.5;
                price = price + 240 + 150 + 50;
            }
            //adds the $50 surcharge and displays result for user
            price = price + 50;
            Console.WriteLine("Your bill amount is " + price);
            Console.ReadLine();

        }
    }
}
