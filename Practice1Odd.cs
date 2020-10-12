using System;

namespace MyFirstProject
{
    class TicketPricingExtended
    {
       public static void extended()
        {
           
           Console.WriteLine("Please enter number:");
           string userInput = Console.ReadLine();
           int i = Convert.ToInt32 (userInput);
           int x=0;
           for(int j=1; j<=i; j++) {
                x=x+((2*j)-1); 
           }
              Console.WriteLine(x);  
        }
    }
}
