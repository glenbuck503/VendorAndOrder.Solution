using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Vendor 
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set;}
    public int Id { get;}
    public List<Vendor> Vendors { get; set;}

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Vendors = new List<Vendor>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}