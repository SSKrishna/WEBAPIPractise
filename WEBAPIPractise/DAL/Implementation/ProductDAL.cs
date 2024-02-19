using WEBAPIPractise.DAL.Interface;
using WEBAPIPractise.Models;

namespace WEBAPIPractise.DAL.Implementation
{
    public class ProductDAL : IProductDAL
    {
        private readonly APIDBContext _dbContext;

        public ProductDAL(APIDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public bool DeleteProduct(long productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
           return _dbContext.Products.ToList();

        }

        public void InsertProduct(Product product)
        {
            
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();             
        }

        public Product UpdateProduct(Product product)
        {
            var pdct = _dbContext.Products.Where(p => p.ProductId == product.ProductId).FirstOrDefault();
            if (pdct != null)
            {
                pdct.ProductPrice = product.ProductPrice; 
                pdct.ProductName = product.ProductName;
                pdct.ProductDescription = product.ProductDescription;
                _dbContext.SaveChanges();

            }
            return pdct ?? product;
        }

        public Product GetProducts(long productId)
        {
            return _dbContext.Products.Where(p => p.ProductId == productId).First();
        }
    }
}
