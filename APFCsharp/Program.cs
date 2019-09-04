using System;
using System.Collections.Generic;


namespace APFCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //example

            List<String> names = new List<String>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            names.ForEach(Print);

            names.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });
            

            //solution 1 

            DisplayMessage messageTarget;
            messageTarget = Console.WriteLine;
            messageTarget("Hello, World!");

            //instead of define name delegate, solution 2

            Action<string> messageAction;
            messageAction = Console.WriteLine;
            messageAction("Hello, Joey");

            //praticing

            Action<string, string> printFullName;
            printFullName = PrintFullName;
            printFullName("Joey", "Tribbiani");

            Console.ReadKey();
        }

        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        private static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName);
        }
    }

    delegate void DisplayMessage(string message);
}
