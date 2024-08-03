using ProductCRUD.Domain.Models;

namespace ProductCRUD.Application.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService()
            => _products = new List<Product>();

        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public Product DeleteProductById(Guid id)
        {
            /* Product product = null;

             foreach (var item in _products)
             {
                 if (item.Id == id)
                 {
                     product = item;
                     break;
                 }
             }

             _products.Remove(product);
             return product;*/

            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product is null)
            {
                return null;
            }

            _products.Remove(product);
            return product;
        }

        public (Guid Id, string Name, double Price)? GetProductById(Guid id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product is null)
            {
                return null;
            }

            return (product.Id, product.Name, product.Price);
        }

        public List<Product> GetProductByName(string name)
        {
            List<Product> filteredproducts = _products.Where(x => x.Name.Contains(name)).ToList();

            return filteredproducts;
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product UpdateProduct(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        /*  public Product UpdateProduct(Guid id, Product product)
          {
              var existProduct = GetProductById(id);

              //Mapping
              existProduct.Name = product.Name;
              existProduct.Price = product.Price;

              return existProduct;
          }*/
    }
}
