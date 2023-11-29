using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<Product> GetProductByIdAsync(int id);
    Task<IReadOnlyList<Product>> GetProductsAsnc();
    Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsnc();
    Task<IReadOnlyList<ProductType>> GetProductTypesAsnc();
}
