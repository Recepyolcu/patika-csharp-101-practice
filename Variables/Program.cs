using System;

namespace Variables
{
    class Program 
    {
        static void Main(string[] args)
        {
            var localTime = DateTime.Now;
            int localYear = localTime.Year;

            Console.Write("Enter your birth year: ");
            int birthYear = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Your age is: {0}", (localYear - birthYear));

            Console.ReadKey();
            
        }
    }
}