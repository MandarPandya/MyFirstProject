using System;

namespace MyFirstProject
{
    class TicketPricing
    {
       public static void getPrice()
        {
           
           Console.WriteLine("Please enter age:");
           string userInput = Console.ReadLine();
           int i = Convert.ToInt32 (userInput);
           if (i<=0 || i>130) {
               Console.WriteLine ("Invalid Input");
           }
           else if (i>=0 && i<=5) {
               Console.WriteLine ("Price is: Free");
           }
           else if (i>5 && i<=14) {
               Console.WriteLine ("Price is: $7.99");
           }
           else if (i>14 && i<=65) {
               Console.WriteLine ("Price is: $11.99");
           }
           else if (i>65) {
               Console.WriteLine ("Price is: $ 9.99");
           }
            
        }
    }
}
