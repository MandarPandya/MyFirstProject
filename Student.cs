using System;

namespace MyFirstProject
{
    class Student
    {
        
    string name {set;get;}
    int age;
    int m1,m2,m3;
    

    // public void setName(String newname){
    //     name=newname;
    // }


    public void readStudentInfo(){


      Console.WriteLine("Name:");
      name=Console.ReadLine(); 

      Console.WriteLine("Age:");
      string temp=Console.ReadLine(); 
      age=Convert.ToInt32(temp);  

    }

    public void getmarksinfo()
    {

        Console.WriteLine("Enter Marks m1 for Maths");
        m1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Marks m2 for Science");
        m2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Marks m3 for SS");
        m3=Convert.ToInt32(Console.ReadLine());


    }
    
    public void printstudentinfo(){
           Console.WriteLine($"Name={name}");
            Console.WriteLine($"Age={age}");
    }


    public int calculateTotalMarks(){
        int total=m1+m2+m3;
        

            Console.WriteLine($"m1={m1}, m2={m2}, m3={m3}");


            
            Console.WriteLine($"Total={total}");
            

            return total;

    } 




        
    }
}
