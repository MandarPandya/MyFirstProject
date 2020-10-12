using System;
using System.Collections.Generic;
namespace MyFirstProject
{
    class CityName
    {
       public static void getCityName()
        {
            List<string> cities = new List<string>();
           
           for(int i=0; i<5; i++){
               Console.WriteLine("Please enter city name");
               string userInput = Console.ReadLine();
            
            }

           for (int i=0; i<cities.Count; i++) {
               Console.WriteLine ();
           }
        }
    }
}
