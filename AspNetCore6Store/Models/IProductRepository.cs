namespace AspNetCore6Store.Models
{
    public interface IProductRepository
    {
        PagedData<Product> GetAll(int pageNumber,int pageSize,string category);
        List<string> GetAllCategories();
    }

}
