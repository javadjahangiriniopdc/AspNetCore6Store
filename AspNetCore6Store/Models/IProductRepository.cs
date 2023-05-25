namespace AspNetCore6Store.Models
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
