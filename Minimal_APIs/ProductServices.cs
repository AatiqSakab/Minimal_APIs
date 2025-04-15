namespace Minimal_APIs
{
    public class ProductServices
    {
        private List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99m, Description = "Description for Product 1" },
                new Product { Id = 2, Name = "Product 2", Price = 20.99m, Description = "Description for Product 2" },
                new Product { Id = 3, Name = "Product 3", Price = 30.99m, Description = "Description for Product 3" }
            };


        public IReadOnlyList<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }
   

        public void AddProduct(Product product)
        {
            product.Id = products.Count + 1;
            product.Name = product.Name;
            product.Price = product.Price;
            product.Description = product.Description; 
            products.Add(product);
        }

        public void UpdateProduct(int id, Product updatedProduct)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.Description = updatedProduct.Description;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
