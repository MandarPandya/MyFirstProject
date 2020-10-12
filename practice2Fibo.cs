using System;

namespace MyFirstProject
{
    class practice2Fibo
    {
       public static void practice2()
        {
           
           Console.WriteLine("Please enter number:");
           string userInput = Console.ReadLine();
           int i = Convert.ToInt32 (userInput);
           int x=0, y=1, z=0;
           for(int j=3; j<=i; j++) {
                z=x+y;
                 x=y;
                 y=z;

              Console.WriteLine("X="+x+";y="+y+";z="+z);   
           }
              Console.WriteLine(z);  
        }
    }
}
