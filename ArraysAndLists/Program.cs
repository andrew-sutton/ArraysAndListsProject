using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numberOneToTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            // SEE METHODS BELOW
            evens = PutInEvens(numberOneToTen);
            odds = PutInOdds(numberOneToTen);

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("All of you even numbers are:");
            foreach(var number in evens)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("All of you odd numbers are:");
            foreach (var number in odds)
            {
                Console.Write(number + " ");
            }
        }
        public static List<int> PutInEvens(int[] input)
        {
            var listOfEvens = new List<int>();
            foreach (var item in input)
            {
                if (item % 2 == 0)
                {
                    listOfEvens.Add(item);
                }
            }
            return listOfEvens;
        }
        public static List<int> PutInOdds(int[] input)
        {
            var listOfOdds = new List<int>();
            foreach (var item in input)
            {
                if (item % 2 != 0)
                {
                    listOfOdds.Add(item);
                }
            }
            return listOfOdds;
        }
    }
   
}
