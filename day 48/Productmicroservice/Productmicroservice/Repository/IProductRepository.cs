﻿using Productmicroservice.Model;
using System.Collections.Generic;

namespace ProductMicroservice.Repository

{

    public interface IProductRepository

    {

        IEnumerable<Product> GetProducts();

        Product GetProductByID(int ProductId);

        void InsertProduct(Product product);

        void DeleteProduct(int ProductId);

        void UpdateProduct(Product product);

        void Save();

    }

}