using System;
using System.Collections.Generic;
using AnimalPark.Animals;

namespace AnimalPark.Locations
{
  public class Exhibit
  {
    private string _location;
    private List<Critter> _tenants;

    public Exhibit (string location)
    {
      _location = location;
      List<Critter> _tenants = new List<Critter>() {};
    }

    public string GetLocation ()
    {
      return _location;
    }

    public void SetTenants (Critter newCritter)
     {
       _tenants.Add(newCritter);
     }
    
    public List<Critter> GetTenants ()
    {
      return _tenants;
    }
  }
}

