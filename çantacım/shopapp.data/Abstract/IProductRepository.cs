using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
       Product GetProductDetails(string url);
       List<Product> GetProductsByCategory(string name,int page,int pageSize);
       List<Product> GetPopularProducts();
       List<Product> GetTop5Products();
       int GetCountByCategory(string category);
    }
}