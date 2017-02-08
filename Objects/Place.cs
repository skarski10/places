using System.Collections.Generic;

namespace PlacesVisited.Objects
{
  public class Place
  {
    // private string _country;
    private string _city;
    private int _id;
    private static List<Place> _entry = new List<Place> {};

    public Place (string city)
    {
      // _country = country;
      _city = city;
      _entry.Add(this);
      _id = _entry.Count;
    }

    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _entry;
    }

    public static Place Find(int searchId)
    {
      return _entry[searchId-1];
    }
  }
}
