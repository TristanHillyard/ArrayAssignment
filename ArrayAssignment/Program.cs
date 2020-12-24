using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an Index from 0-3");
            string[] nameArray = { "John", "Tim", "Chloe", "Kim K" };
            int result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nameArray[result]);

            string inputNum = Console.ReadLine();

            Console.WriteLine("Select an index from 0-4");
            int[] intArray = { 2, 10, 20, 30, 50 };

            Console.WriteLine("Select an Index of 0-2");
            List<string> strgList = new List<string>();
            strgList.Add("Hello");
            strgList.Add("Crazy");
            strgList.Add("Mello");
        }
    }
}
