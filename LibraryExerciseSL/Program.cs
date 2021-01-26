using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExerciseSL
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here


            //iterate through the Dictionary with foreach loop
            //multiply each item by the discount
            /*
            foreach (KeyValuePair<string, int> entry in coffee)
                coffee.Keys.ToArray();
            
            string[,] myArray = coffee.Keys.ToArray();

            foreach (string name in myArray)
            {
                foreach (string price in myArray)
                {
                    price *= (discount * 0.01);
                }
                Console.WriteLine($"{name}: {price}");
            }
            */
            /*
            double discountFactor = discount * .01;
            foreach (string name in coffee.Keys)
                Console.WriteLine(name + ": " + (coffee[name] - (coffee[name] * discountFactor)));
            */

            //Main try
            
            double discountFactor = discount * .01;
            //Console.WriteLine(discountFactor);
            foreach (string name in coffee.Keys)
            {
                var priceDouble = coffee[name];
                //Console.WriteLine(priceDouble);
                double removed = (priceDouble * discountFactor);
                //removed = Math.Round(removed, MidpointRounding.AwayFromZero);
                //Console.WriteLine(removed);
                double newPrice = (priceDouble - removed);
                newPrice = Math.Round(newPrice, MidpointRounding.AwayFromZero);
                

                Console.WriteLine(name + ": " + newPrice);
            }
            


        }
    }
}
