using Microsoft.EntityFrameworkCore;
using BestRestaurant.Models;
using BestRestaurant;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {
    public DBSet<Cuisine> Cuisines { get; set; }
    public DBSet<Restaurant> Restaurants { get; set; }

    public BestRestaurantContext(DBContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}