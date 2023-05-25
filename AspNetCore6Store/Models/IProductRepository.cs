namespace AspNetCore6Store.Models
{
    public interface IProductRepository
    {
        PagedData<Product> GetAll(int pageNumber,int pageSize);
    }
}
