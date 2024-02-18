using Microsoft.AspNetCore.Mvc;
using WEBAPIPractise.Models;

namespace WEBAPIPractise.DAL.Interface
{
    public interface IProductDAL
    {

        List<Product> GetProducts(long productId);

        Product InsertProduct(Product product);

        Product UpdateProduct(Product product);

        bool DeleteProduct(long productId);
    }
}
