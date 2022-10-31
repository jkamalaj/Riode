using Microsoft.EntityFrameworkCore;
using Riode.Models;

namespace Riode.DAL
{
    public class RiodeContext:DbContext
    {

        public RiodeContext(DbContextOptions<RiodeContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<SaleNews> News { get; set; }
        public DbSet<SeasonSale> SeasonSales { get; set; }


    }
}
