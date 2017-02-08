using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _description;
    private string _duration;
    private int _id;
    private static List<Place> _instances = new List<Place>{};

    public Place (string description, string duration)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
      _duration = duration;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetDuration()
    {
      return _duration;
    }
    public void SetDuration(string newDuration)
    {
      _duration = newDuration;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
