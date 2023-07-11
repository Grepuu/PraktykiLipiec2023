using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PraktykiLipiec2023.Data.Entities;
using PraktykiLipiec2023.Data.Enums;
using PraktykiLipiec2023.Data.Seeds;

namespace PraktykiLipiec2023.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    public DbSet<MarketLaneEntity> MarketLanes { get; set; }
    public DbSet<MarketLaneShelfEntity> MarketLaneShelfes { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        
        builder.Entity<MarketLaneEntity>().HasData(new List<MarketLaneEntity>()
        {
            new MarketLaneEntity()
            {
                Id = 1,
                Name = "Alejka główna",
                Description = "do uzupełnienia"
            },
            new MarketLaneEntity()
            {
                Id = 2,
                Name = "Alejka druga",
                Description = "do uzupełnienia"
            },
            new MarketLaneEntity()
            {
                Id = 3,
                Name = "Alejka kas",
                Description = "do uzupełnienia"
            }
        });

        ProductCategoriesSeeder.Seed(builder);
    }
}