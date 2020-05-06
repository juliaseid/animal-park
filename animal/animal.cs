using System;

namespace AnimalPark.Animals 
{
  public class Critter
  {
    private string _species;
    private string _name;
    private int _age;
    private string _food;
    private int _danger;

    public Critter(string species, string name, int age, string food, int danger, string location)
    {
      _species = species;
      _name = name;
      _age = age;
      _food = food;
      _danger = danger;
      _location = none;
    }
    public string GetSpecies()
    {
      return _species;
    }
    public string GetName(){
      return _name;
    }
    public int GetAge()
    {
      return _age;
    }
    public string GetFood()
    {
      return _food;
    }
    public int GetDanger()
    {
      return _danger;
    }
    public string SetLocation(string location) 
    {
       _location=newLocation;
    }
    public string GetLocation()
    {
      return _location;
    }
  }
}



