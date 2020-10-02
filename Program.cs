using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++){
                string result = i + " ";

                if (i % 3 == 0) {
                    result += "Fizz";
                }

                if (i % 5 == 0) {
                    result += "Buzz";
                }
                Console.WriteLine(result);
            }
        }
    }
}
