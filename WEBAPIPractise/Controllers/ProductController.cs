using Microsoft.AspNetCore.Mvc;
using WEBAPIPractise.BLL.Interface;
using WEBAPIPractise.Models;

namespace WEBAPIPractise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductBLL _productBLL;
        public ProductController(IProductBLL productBLL) 
        { 
            _productBLL = productBLL;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
           var products = _productBLL.GetAllProducts();
            if(products == null)
            {
                return BadRequest();
            }
            return Ok(products);
        }


        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var product =  _productBLL.GetProducts(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]

        public void InsertProduct(Product product)
        {
            _productBLL.InsertProduct(product);
        }

        [HttpPatch]

        public IActionResult UpdateProduct(Product product)
        {
            var updatedProduct =  _productBLL.UpdateProduct(product);
            if(updatedProduct != null)
            {
                return Ok(updatedProduct);
            }         

            return NotFound();
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {
            bool? deleted =  _productBLL.DeleteProduct(id);
            if(deleted != null)
            {
                return Ok(deleted);
            }

            return BadRequest();
        }
    }
}
