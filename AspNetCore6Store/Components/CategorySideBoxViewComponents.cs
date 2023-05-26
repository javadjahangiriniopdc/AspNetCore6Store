using AspNetCore6Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore6Store.Components
{
    public class CategorySideBoxViewComponents:ViewComponent
    {
        private readonly IProductRepository productRepository;

        public CategorySideBoxViewComponents(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IViewComponentResult Invoke() { return View(productRepository.GetAllCategories()); }
    }
}
