using System;
using System.Collections.Generic;
using AnimalPark.Animals;
using AnimalPark.Locations;

namespace AnimalPark
{
  public class Program
  {
    public static void Main()
    {
      Exhibit barn = new Exhibit ("barn");
      Exhibit aquarium = new Exhibit ("aquarium");
      Exhibit serengeti = new Exhibit ("serengeti");
      Exhibit northWoods = new Exhibit ("north woods");

      List<Exhibit> Locations = new List<Exhibit>() {barn, aquarium, serengeti, northWoods};

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
            Console.WriteLine(animal.GetName() + " is only dangerous when provoked. Please be nice to " + animal.GetName());
          } else {
            Console.WriteLine(animal.GetName() + "is harmless!");
          }
          num ++;
        };

      Console.WriteLine("Now you need to decide where your animals where live. For each animal, please determine which exhibit it will live in.");
      foreach(Critter animal in Animals) 
      {
        Console.WriteLine("Where would you like " + animal.GetName() + " to live?");
        string input = Console.ReadLine();
        animal.SetLocation(input);
      }

    foreach (Critter animal in Animals) {
      foreach (Exhibit spot in Locations) {
        if (animal.GetLocation == spot.GetLocation()) {
          spot.SetTenants(animal);
        }
      }
    }

//MISSING LINK - Animals get assigned a location, but each location doesn't know what animals are in it. //foreach animal, foreach spot, if

      foreach (Exhibit spot in Locations)
      {
        Console.WriteLine("The animals in the " + spot.GetLocation() + " are: " );
      }
    }
  }
}

//What do you need to do?  Order food; clean cages; find out who's going to die next; 

//create class locations, allow park manager to select which animals live in which locations 

//