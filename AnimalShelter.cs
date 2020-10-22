using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    class Animal
    {
       int uniqueId { get; set; } 
        string animalName { get; set; }
        string animalBreed { get; set; }
        string animalType { get; set; }
        int animalAge { get; set;}

        bool isAdopted {get; set;}

        static List<Animal> animals_list=new List<Animal>();

        public Animal(){

        }
        public Animal(int p_uid, string p_animalName, string p_animalBreed, string p_animalType, int p_animalAge,bool p_isadopted=false) {
                    uniqueId=p_uid;
                    animalName=p_animalName;
                    animalBreed=p_animalBreed;
                    animalType=p_animalType;
                    animalAge=p_animalAge;
                    isAdopted=p_isadopted;
        }
        public static void registerNewAnimal(Animal a) {
                animals_list.Add(a);

        }

        public static void printAnimalList(){
            for(int i=0;i<animals_list.Count;i++)
            {
                Animal an=animals_list[i];
                Console.WriteLine($"Name:{an.animalName}, Type:{an.animalType}, Breed: {an.animalBreed}, Is Adopted {an.isAdopted}");
            }
        }

        public static void adoptAnimal(int id)
        {
            bool animal_adopted=false;
            for(int i=0;i<animals_list.Count;i++)
            {
                Animal an=animals_list[i];
                if (an.uniqueId==id && !an.isAdopted)
                {
                    animals_list[i].isAdopted=true;
                        
                    Console.WriteLine($"Animal id:{id} Adopted Successfully");
                    animal_adopted=true;
                }
            }

            if(!animal_adopted)
            {
                Console.WriteLine($"Animal id:{id} can not be adopted");
            }
                

        }


        
        
        
    }



    class AnimalShelterProgram{

        public static void run(){
            Animal a1=new Animal(1,"Tomy","German Shephered", "Dog",1);
                    Animal a2=new Animal(2,"Mini","Pushy cat", "Cat",2);
                    Animal a3=new Animal(3,"Tumtum","Golden cat", "Cat",3);
                    
                    Animal.registerNewAnimal(a1);
                    Animal.registerNewAnimal(a2);
                    Animal.registerNewAnimal(a3);
                    Animal.printAnimalList();

                    Animal.adoptAnimal(1);

                    Animal.printAnimalList();
                    Animal.adoptAnimal(1);
        }


    }

}