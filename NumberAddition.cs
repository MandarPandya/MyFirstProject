using System;

namespace MyFirstProject
{
    class NumberAddition
    {
       public static void getAddition()
        {
           Console.WriteLine("Enter first number:");
           string FirstNumber = Console.ReadLine();
           int i = Convert.ToInt32 (FirstNumber);
           Console.WriteLine("-------------------");
           Console.WriteLine(i);
           
           Console.WriteLine("Enter second number:");
           string SecondNumber = Console.ReadLine();
           int j = Convert.ToInt32 (SecondNumber);
           Console.WriteLine("-------------------");
           Console.WriteLine(j);
           int x;
           int Sum=0;
           for (x=i; x<=j; x++){
               Sum=Sum+x;
           }
           Console.WriteLine("-------------------");
           Console.WriteLine("The sum is:"+Sum);
        }
    }
}
