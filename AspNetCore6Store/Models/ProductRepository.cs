namespace AspNetCore6Store.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public ProductRepository(StoreDbContext storeDbContext) {
            this.storeDbContext = storeDbContext;
        }

        public List<Product> GetAll()
        {
            return storeDbContext.products.ToList();
        }
    }
}
