namespace AspNetCore6Store.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public ProductRepository(StoreDbContext storeDbContext) {
            this.storeDbContext = storeDbContext;
        }

        public PagedData<Product> GetAll(int pageNumber, int pageSize)
        {
            var result = new PagedData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                }
            };

            result.Data = storeDbContext.products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            result.PageInfo.TotalCount = storeDbContext.products.Count();
            return result;
        }
    }
}
