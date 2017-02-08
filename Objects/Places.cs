using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _description;
    private string _duration;
    private string _picture;
    private int _id;
    private static List<Place> _instances = new List<Place>{};

    public Place (string description, string duration, string picture)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
      _duration = duration;
      _picture = picture;
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
    public string GetPicture()
    {
      return _picture;
    }
    public void SetPicture(string newPicture)
    {
      _picture = newPicture;
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
