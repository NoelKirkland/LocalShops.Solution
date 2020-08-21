using System;
using System.Collections.Generic;

namespace LocalShops.Models
{
  public class Neighborhood
  {
    public Neighborhood()
    {
      this.Restaurants = new HashSet<Restaurant>();
      this.Shops = new HashSet<Shop>();
    }
    public int NeighborhoodId { get; set; }
    public string Name { get; set; }
    public ICollection<Restaurant> Restaurants { get; set; }
    public ICollection<Shop> Shops { get; set; }
  }
}