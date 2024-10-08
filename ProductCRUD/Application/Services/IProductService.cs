﻿using ProductCRUD.Domain.Models;

namespace ProductCRUD.Application.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        List<Product> GetProducts();
        List<Product> GetProductByName(string name);
        (Guid Id, string Name, double Price)? GetProductById(Guid id);
        Product UpdateProduct(Guid id, Product product);
        Product DeleteProductById(Guid id);
    }
}
