namespace LocalShops.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public int NeighborhoodId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int StarRating { get; set; }
  }
}