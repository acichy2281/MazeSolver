using System;

namespace cis237_inclass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factorial or 2 for Tower of Hanoi");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Factorial factorial = new Factorial();

                Console.WriteLine("Solve 5");
                Console.WriteLine("The answer is:");
                Console.WriteLine(factorial.Solve(5));
            }
            else
            {
                // Do tower of Hanoi
                TowerOfHanoi hanoi = new TowerOfHanoi();
                hanoi.Solve();
            }    
        }
    }
}
