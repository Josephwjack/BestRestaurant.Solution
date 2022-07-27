using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class BestRestaurantContext : DbContext
  {
    public DBSet<Cuisine> Cuisines { get; set; }
    public DBSet<Restaurant> Restaurants { get; set; }

    public BestRestaurantContext(DBContextOption options) : base(options) { }

    protected override void OnConfiguring(DBContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}