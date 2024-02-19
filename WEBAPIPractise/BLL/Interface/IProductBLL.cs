using WEBAPIPractise.Models;

namespace WEBAPIPractise.BLL.Interface
{
    public interface IProductBLL
    {
        List<Product> GetAllProducts();
        Product GetProducts(long productId);

        void InsertProduct(Product product);

        Product UpdateProduct(Product product);

        bool DeleteProduct(long productId);
    }
}
