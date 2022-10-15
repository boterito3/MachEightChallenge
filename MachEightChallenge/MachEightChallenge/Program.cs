using System;
using System.Collections.Generic;
using System.Linq;

namespace MachEightChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            List<int> listOfNumbers;
            int sumObjective;
            if (args.Length == 2)
            {
                listOfNumbers = args[0].Split(',').Select(int.Parse).ToList();
                sumObjective = Convert.ToInt32(args[1]);
            }
            else 
            {
                sumObjective = 12;
                listOfNumbers = new List<int>() { 1, 9, 5, 0, 20, -4, 12, 16, 7 };
            }

            List<int> numbersToSum = new List<int>(listOfNumbers);
            foreach (int number in listOfNumbers) 
            {
                numbersToSum.Remove(number);
                foreach (int number2 in numbersToSum)
                {
                    if ((number + number2) == sumObjective) 
                    {
                        result = result + $"...{number},{number2}";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
