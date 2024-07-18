using ProductCRUD.Application.Services;
using ProductCRUD.Domain.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        IProductService productService = new ProductService();
        productService.AddProduct(new Product("Komputer", 1000));
        productService.AddProduct(new Product("Telefon", 800));
        productService.AddProduct(new Product("Notebook", 5000));
        productService.AddProduct(new Product("Daftar", 1));
        productService.AddProduct(new Product("Ruchka", 1));
        productService.AddProduct(new Product("Gugurt", 0.5));
        productService.AddProduct(new Product("Moshina", 30000));
        productService.AddProduct(new Product("Uy", 70000));

        var gugurtId = productService.GetProductByName("Gugurt")[0].Id;

        productService.UpdateProduct(gugurtId, new Product("Sham", 1));

        //productService.DeleteProductById(gugurtId[0].Id);

        var products = productService.GetProducts();
        foreach (var product in products)
        {
            Console.WriteLine(product.Id + "|" + product.Name + "|" + product.Price);
        }
    }
}