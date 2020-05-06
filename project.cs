using System;
using System.Collections.Generic;
using AnimalPark.Animals;

namespace AnimalPark
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How many Animals do You have in the Park");
      int animalCnt = int.Parse(Console.ReadLine());
      List<Critter> Animals = new List<Critter>(){};

      for(int i = 0; i < animalCnt; i ++)
      {      
        Console.WriteLine("What species?");
        string species = Console.ReadLine();
        Console.WriteLine("Enter its name");
        string name = Console.ReadLine();
        Console.WriteLine("How old is it?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("What does it eat?");
        string food = Console.ReadLine();
        Console.WriteLine("How dangerous is it?");
        int danger = int.Parse(Console.ReadLine());
        Critter myCritter = new Critter(species,  name,  age,  food,  danger);
        Animals.Add(myCritter);
      }

      int num = 1;
      foreach(Critter animal in Animals)
        {
          Console.WriteLine("Animal " + num + ": Name: " + animal.GetName() + " the " + animal.GetSpecies());
          Console.WriteLine("Age: " + animal.GetAge());
          Console.WriteLine(animal.GetName() + "Eats: " + animal.GetFood());
        
          if (animal.GetDanger() >= 7) {
            Console.WriteLine("Watch out!!! " + animal.GetName() + " is very dangerous!");
          } else if(animal.GetDanger() <= 6 && animal.GetDanger() >= 4){
            Console.WriteLine(animal.GetName() + " is somewhat dangerous, so be careful!");
          } else if(animal.GetDanger() <=3 && animal.GetDanger() >= 2){
            Console.WriteLine(animal.GetName() + " is only dangerous when provoked, please be nice to " + animal.GetName());
          } else {
            Console.WriteLine(animal.GetName() + "is harmless!");
          }
          num ++;
        }
    }
  }
}

/*
List<Critter> Animals = new List<Critter>();

public void AddAnimal(myCritter){
  Animals.Add(myCritter);
}
 */