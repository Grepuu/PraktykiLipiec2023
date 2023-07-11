using Microsoft.EntityFrameworkCore;
using PraktykiLipiec2023.Data.Entities;

namespace PraktykiLipiec2023.Data.Seeds;

public static class ProductCategoriesSeeder
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<ProductCategoryEntity>().HasData(new List<ProductCategoryEntity>()
        {
            new ProductCategoryEntity()
            {
                Id = 1,
                Name = "Spożywcze",
                Description = "opis kategorii - do uzupełnienia"
            },
            new ProductCategoryEntity()
            {
                Id = 2,
                Name = "Elektronika",
                Description = "opis kategorii - do uzupełnienia"
            },
            new ProductCategoryEntity()
            {
                Id = 3,
                Name = "Napoje",
                Description = "opis kategorii - do uzupełnienia"
            }
        });
    }
}