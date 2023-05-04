using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> products;

        public MockProductRepository()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Description = "Powerful laptop with a high resolution display", Price = 1000.00m, CategoryId = 1 },
                new Product { Id = 2, Name = "Mouse", Description = "High precision mouse for gaming and productivity", Price = 50.00m, CategoryId = 2 }
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var index = products.FindIndex(p => p.Id == product.Id);
            if (index >= 0)
            {
                products[index] = product;
            }
        }

        public void DeleteProduct(int id)
        {
            var index = products.FindIndex(p => p.Id == id);
            if (index >= 0)
            {
                products.RemoveAt(index);
            }
        }
    }
}
