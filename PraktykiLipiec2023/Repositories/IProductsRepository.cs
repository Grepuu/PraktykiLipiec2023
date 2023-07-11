using PraktykiLipiec2023.Data.Entities;

namespace PraktykiLipiec2023.Repositories;

public interface IProductsRepository
{
    ICollection<ProductEntity> List();
    ProductEntity One(int id);
    int Add(object model);
    ProductEntity Edit(object model);
    bool Delete(int id);
}