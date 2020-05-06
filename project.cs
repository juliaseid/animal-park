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
        
      }
    }
  }
}