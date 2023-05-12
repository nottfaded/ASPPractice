using Newtonsoft.Json;
using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContent dBContent;

        public ProductRepository(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Product> GetProducts() { 
             return dBContent.Products;
        
        }

        public Product GetProductById(int id) => dBContent.Products.FirstOrDefault(p => p.Id == id);

        public void AddProduct(Product product)
        {
            product.Id = dBContent.Products.Count() + 1;
            dBContent.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var productToChange = dBContent.Products.FirstOrDefault(p => p.Id == product.Id);
            if (productToChange != null)
            {
                productToChange = product;
            }
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = dBContent.Products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                dBContent.Products.Remove(productToDelete);
            }
        }
    }
}
