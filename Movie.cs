using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    /*
    Challenge:
    - 1. Add a data member for a unique Id to the Movie class
    - 2. Add a data member for a collection of numerical ratings
    - 3. Add a constructor that initializes all the data members of a movie
    - 4. Add a method that allows you to add a rating between 1 and 5 (inclusive) to the movie
    - 5. Add a mechanism that allows you to get the average rating of a movie
    */
    public class Movie {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int UniqueId { get; set;}
        List<int> Ratings = new List<int>();

        public Movie(int p_uid, string p_title, string p_director, int p_year) {
            UniqueId=p_uid;
            Title=p_title;
            Director=p_director;
            Year=p_year;


        }

       public void addRatings(){

              

                while(true){
                
                Console.WriteLine($"Add rating for movie {Title} OR enter 'quit' to exit?");
                string s1=Console.ReadLine();
               
                if(s1=="quit")
                {
               
                break;  
                }

               int r1=Convert.ToInt32(s1); 
                   if (r1>=1 && r1<=5){
                       Ratings.Add(r1);
                   }
                   else {
                       Console.WriteLine("Invalid Input");
               } 

            }  

        }

        

        public void PrintDetails() {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Year: {Year}\n");
        }


       public void printRatings(){

            for(int i=0;i<Ratings.Count;i++){
                  Console.WriteLine($"rating on position {i} is: {Ratings[i]}");  
            }
        }
        public void AverageRatings(){
            int x=0;
            double y=0.0;
            

             if(Ratings.Count>0)   
             {
                    for(int j=0;j<Ratings.Count;j++){
                        x=x+Ratings[j];           
                    }

                    y=(Double)x/Ratings.Count;
                    y=Math.Round(y,2);
             }   
             
            Console.WriteLine($"Avrage rating for {Title} : {y}");
        } 
    }


class MovieRating{

public static void runProgram(){
        Movie m1=new Movie(1001,"ABCDE","KLMN",2001);

        
        
        m1.addRatings();
        

        
        Console.WriteLine("");
        Movie m2=new Movie(1002,"FGHIJ","OPQRS",2005);
        m2.addRatings();
        Console.WriteLine("");
        m1.PrintDetails();
        m1.AverageRatings();
        Console.WriteLine("");
        m2.PrintDetails();
        m2.AverageRatings();
    }

}





}
