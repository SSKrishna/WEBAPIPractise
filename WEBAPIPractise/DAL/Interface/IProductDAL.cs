﻿using Microsoft.AspNetCore.Mvc;
using WEBAPIPractise.Models;

namespace WEBAPIPractise.DAL.Interface
{
    public interface IProductDAL
    {
        List<Product> GetAllProducts();
        Product GetProducts(long productId);

        void InsertProduct(Product product);

        Product UpdateProduct(Product product);

        bool DeleteProduct(long productId);
    }
}
