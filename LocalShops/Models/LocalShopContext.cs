using Microsoft.EntityFrameworkCore;

namespace LocalShop.Models
{
  public class LocalShopContext : DbContext
  {
    public LocalShopContext(DbContextOptions<LocalShopContext> options) : base(options)
    {
    }
    public DbSet<Neighborhood> Neighborhoods { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Shop> Shops { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>()
      .HasData(
        new User { Id = 1, Username = ["YOUR-ADMIN-USERNAME-HERE"], Password = ["YOUR-ADMIN-PASSWORD-HERE"], Role = Role.Admin },
        new User { Id = 2, Username = ["YOUR-USER-USERNAME-HERE"], Password = ["YOUR-USER-PASSWORD-HERE"], Role = Role.User },
      );

      builder.Entity<User>()
      .HasData(
        new Neighborhood { NeighborhoodId = 1, Name = "Eastmorland"},
        new Neighborhood { NeighborhoodId = 2, Name = "Sellwood"},
        new Neighborhood { NeighborhoodId = 3, Name = "Woodstock"}
      );

      builder.Entity<User>()
      .HasData(
        new Restaurant { RestaurantId = 1, NeighborhoodId = 1, Name = "Taco Express", Type = "Mexican", StarRating = 3},
        new Restaurant { RestaurantId = 2, NeighborhoodId = 2, Name = "Betrie Lou's Cafe", Type = " American breakfast/lunch", StarRating = 3},
        new Restaurant { RestaurantId = 3, NeighborhoodId = 2, Name = "Bellagios Pizza", Type = "Italian", StarRating = 4},
        new Restaurant { RestaurantId = 4, NeighborhoodId = 3, Name = "Otto's", Type = "German deli", StarRating = 5},
        new Restaurant { RestaurantId = 5, NeighborhoodId = 3, Name = "Tom Yum", Type = "Thai", StarRating = 5},
        new Restaurant { RestaurantId = 6, NeighborhoodId = 3, Name = "Laughing Planet", Type = "burritos/bowls", StarRating = 3}
      );

      builder.Entity<User>()
      .HasData(
        new Restaurant { ShopId = 1, NeighborhoodId = 1, Name = "Wallgreens", Type = "drug store", StarRating = 2},
        new Restaurant { ShopId = 2, NeighborhoodId = 1, Name = "7/11", Type = "convenience", StarRating = 2},
        new Restaurant { ShopId = 3, NeighborhoodId = 2, Name = "Snap Fitness", Type = "gym/wellness", StarRating = 4},
        new Restaurant { ShopId = 4, NeighborhoodId = 3, Name = "Ace Hardware", Type = "hardware store", StarRating = 3},
        new Restaurant { ShopId = 5, NeighborhoodId = 3, Name = "7/11", Type = "convenience store", StarRating = 3},
        new Restaurant { ShopId = 6, NeighborhoodId = 3, Name = "New Seasons", Type = "grocery store", StarRating = 5}
      );
    }
  }
}