using System;

namespace MyFirstProject
{
    class TicketPricing
    {
       public static void getPrice()
        {
           Console.WriteLine("Welcome to movie theatre");
           Console.WriteLine("--------------------------");
           Console.WriteLine("Please enter age:");
           string userInput = Console.ReadLine();
           int i = Convert.ToInt32 (userInput);
           double price=0.0;
           if (i<=0 || i>130) {
               Console.WriteLine ("Invalid Input");
           }
           else if (i>=0 && i<=5) {
               price=0.0;
           }
           else if (i>5 && i<=14) {
               price=7.99;
           }
           else if (i>14 && i<=65) {
               price=11.99;
           }
           else if (i>65) {
               price=9.99;
           }
           DateTime currentDay = DateTime.Now;
           if (currentDay.DayOfWeek == DayOfWeek.Sunday){
               price /= 2;
           }
           Console.WriteLine("Are you a student?:");
           string studentInput = Console.ReadLine();
           if (studentInput == "Yes" || studentInput == "yes" ){
               price = price-1;
           }
           Console.WriteLine("Ticket Price is:"+price); 
        }
    }
}
