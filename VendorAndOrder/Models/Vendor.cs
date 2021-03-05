using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Vendor 
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set;}
    public string Description { get; set;}
    public int Id { get;}
    public List<Vendor> Vendors { get; set;}

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;

      _instances.Add(this);
      Id = _instances.Count;
      Vendors = new List<Vendor>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Category> GetAll()
    {
      return _instances;
    }


  }
}