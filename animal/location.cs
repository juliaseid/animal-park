using System;

namespace AnimalPark.Locations
{
  public class Exhibit
  {
    private string _location;

    public Exhibit (string location, List<Critter> tenants)
    {
      _location = location;
      List<Critter> _tenants = new List<Critter>();
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

