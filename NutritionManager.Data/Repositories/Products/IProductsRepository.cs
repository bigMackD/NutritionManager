using NutritionManager.Data.Models.Product;
using System.Collections.Generic;

namespace NutritionManager.Data.Repositories.Products
{
    public interface IProductsRepository
    {
        IList<ProductModel> GetProducts();
        ProductModel GetProduct(int id);

        void Add(AddProductModel user);
        void Delete(long id);
        void Update(EditProductModel user);
    }
}
