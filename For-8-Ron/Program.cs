using System;

namespace For_8_Ron
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0, i = 0;
            long factorial = 1;

            // receiving input for factorial end
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            // calculating factorial sequentially
            for (i=1; i <= input; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial for {input} (!{input}) is {factorial}");
            Console.ReadLine();
        }
    }
}
