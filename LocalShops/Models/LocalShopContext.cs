using Microsoft.EntityFrameworkCore;

namespace LocalShops.Models
{
  public class LocalShopsContext : DbContext
  {
    public LocalShopsContext(DbContextOptions<LocalShopsContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Neighborhood> Neighborhoods { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Shop> Shops { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>()
      .HasData(
        new User { Id = 1, Username = ["YOUR-USERNAME-HERE"], Password = ["YOUR-PASSWORD-HERE"], Role = Role.Admin }
      );


      builder.Entity<Neighborhood>()
      .HasData(
        new Neighborhood { NeighborhoodId = 1, Name = "East Morland"},
        new Neighborhood { NeighborhoodId = 2, Name = "Sellwood"},
        new Neighborhood { NeighborhoodId = 3, Name = "Woodstock"}
      );

      builder.Entity<Restaurant>()
      .HasData(
        new Restaurant { RestaurantId = 1, NeighborhoodId = 1, Name = "Taco Express", Type = "Mexican", StarRating = 3},
        new Restaurant { RestaurantId = 2, NeighborhoodId = 2, Name = "Bertie Lou's Cafe", Type = " American breakfast/lunch", StarRating = 3},
        new Restaurant { RestaurantId = 3, NeighborhoodId = 2, Name = "Bellagios Pizza", Type = "Italian", StarRating = 4},
        new Restaurant { RestaurantId = 4, NeighborhoodId = 3, Name = "Otto's", Type = "German deli", StarRating = 5},
        new Restaurant { RestaurantId = 5, NeighborhoodId = 3, Name = "Tom Yum", Type = "Thai", StarRating = 5},
        new Restaurant { RestaurantId = 6, NeighborhoodId = 3, Name = "Laughing Planet", Type = "burritos/bowls", StarRating = 3}
      );

      builder.Entity<Shop>()
      .HasData(
        new Shop { ShopId = 1, NeighborhoodId = 1, Name = "Wallgreens", Type = "drug store", StarRating = 2},
        new Shop { ShopId = 2, NeighborhoodId = 1, Name = "7/11", Type = "convenience", StarRating = 2},
        new Shop { ShopId = 3, NeighborhoodId = 2, Name = "Snap Fitness", Type = "gym/wellness", StarRating = 4},
        new Shop { ShopId = 4, NeighborhoodId = 3, Name = "Ace Hardware", Type = "hardware store", StarRating = 3},
        new Shop { ShopId = 5, NeighborhoodId = 3, Name = "7/11", Type = "convenience store", StarRating = 3},
        new Shop { ShopId = 6, NeighborhoodId = 3, Name = "New Seasons", Type = "grocery store", StarRating = 5}
      );
    }
  }
}