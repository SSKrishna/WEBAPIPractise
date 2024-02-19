using WEBAPIPractise.BLL.Interface;
using WEBAPIPractise.DAL.Interface;

namespace WEBAPIPractise.BLL.Implementation
{
    public class ProductBLL : IProductBLL
    {
        private IProductDAL _IProductdal { get; set; }
        private ILogger _Logger;
        public ProductBLL(IProductDAL IPrdtdal,ILogger logger) 
        { 
            _IProductdal = IPrdtdal;
            _Logger = logger;
        }
        public bool DeleteProduct(long productId)
        {
            try
            {
                return _IProductdal.DeleteProduct(productId);
            }
            catch(Exception ex)
            {
                _Logger.LogError("Failed to Delete Product");
            }
            return false;
        }

        public List<Models.Product> GetAllProducts()
        {
            try
            {
                return _IProductdal.GetAllProducts();
            }
            catch(Exception ex)
            {

            }
            return new List<Models.Product>();
        }

        public Models.Product GetProducts(long productId)
        {
            try
            {
                return _IProductdal.GetProducts(productId);
            }
            catch(Exception ex)
            {

            }
            return new Models.Product();
        }

        public void InsertProduct(Models.Product product)
        {
            try
            {
                _IProductdal.InsertProduct(product);
            }
            catch (Exception e)
            {

            }
        }

        public Models.Product UpdateProduct(Models.Product product)
        {
            try
            {
                return _IProductdal.UpdateProduct(product);
            }
            catch(Exception ex)
            {

            }
            return new Models.Product();


        }
    }
}
