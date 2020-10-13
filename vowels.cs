using System;


namespace MyFirstProject
{
    class vowels
    {
       public static void removeVowels()
        {
           Console.WriteLine("Enter string:");
           string userInput = Console.ReadLine();
           Console.WriteLine("-------------------");
           string lowerString= userInput.ToLower();
           string newString="";
            int i;
           for (i=0; i< userInput.Length; i++){
               
               if(lowerString[i]=='a' || lowerString[i]=='e' || lowerString[i]=='i' || lowerString[i]=='o' || lowerString[i]=='u'){
                      continue;
               }
               else{
                    newString= newString+userInput[i];
               }
              
           }
           Console.WriteLine(newString);
        }
    }
}
