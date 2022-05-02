using System;

namespace Addition_CICD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready to perform an int addition ?");
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = input_1 + input_2;
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
    }
}