namespace LocalShops.Models
{
  public class Shop
  {
    public int ShopId { get; set; }
    public int NeighborhoodId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int StarRating { get; set; }
  }
}