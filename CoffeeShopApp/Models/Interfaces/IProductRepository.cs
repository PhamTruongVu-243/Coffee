namespace TH01.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product GetProductById(int id);
        string? GetProductDetail(int id);
    }
}
