using TH01.Models.Interfaces;
using TH01.Data;

namespace TH01.Models.Service
{
    public class ProductRepository : IProductRepository
    {
        private TH01DbContext dbContext;
        public ProductRepository(TH01DbContext dbContext)
        { 
            this.dbContext = dbContext;
        }
        private List<Product> ProductsList = new List<Product>()
        {
            new Product { Id = 1, Name = "America", Price= 25, Detail="Name product",
                ImageUrl="https://index.com" },
            new Product {Id = 2, Name = "Vietnam", Price= 20, Detail="Vietnamese product",
                ImageUrl="https://index.com"},
            new Product {Id = 3, Name ="United Kingdom", Price=15, Detail="Name product",
                ImageUrl="https://index.com"}
        };
        public IEnumerable<Product> GetAllProduct()
        {
            return ProductsList;
        }
        public Product? GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
        //VS tự thêm code vào 
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        string? IProductRepository.GetProductDetail(int id)
        {
            throw new NotImplementedException();
        }
    }
}
