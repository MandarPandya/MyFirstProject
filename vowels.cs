using System;


namespace MyFirstProject
{
    class StringOperations
    {
       public static void performStringOperations()
        {
           Console.WriteLine("Enter string:");
           string input1 = Console.ReadLine();
            string processedstr= removeVowel(input1);
            


            
            string abc = Console.ReadLine();
            removeVowel(abc);

           Console.WriteLine("-------------------");


           
           Console.WriteLine(processedstr);
        }


       public static string removeVowel(String userInput)
        {

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

            return newString;
        }
    }
}
