using PraktykiLipiec2023.Data;
using PraktykiLipiec2023.Data.Entities;

namespace PraktykiLipiec2023.Repositories;

public class ProductsRepository : IProductsRepository
{
    private readonly ApplicationDbContext _appDbContext;
    
    public ProductsRepository(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public ICollection<ProductEntity> List()
    {
        return _appDbContext.Products
            .Select(n => n)
            .ToList();
    }

    public ProductEntity One(int id)
    {
        return _appDbContext.Products
            .FirstOrDefault(n => n.Id == id) 
               ?? new ProductEntity();
    }

    public int Add(object model)
    {
        throw new NotImplementedException();
    }

    public ProductEntity Edit(object model)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}