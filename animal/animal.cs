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


    public Critter(string species, string name, int age, string food, int danger)
    {
      _species = species;
      _name = name;
      _age = age;
      _food = food;
      _danger = danger;
    }
    public string getSpecies()
    {
      return _species;
    }
    public string getName(){
      return _name;
    }
    public int getAge()
    {
      return _age;
    }
    public string getFood()
    {
      return _food;
    }
    public int getDanger()
    {
      return _danger;
    }



  }
}


/*
List<Critter> critters = new List<Critter>();

public void AddAnimal(myCritter){
  critters.Add(myCritter);
}
 */
