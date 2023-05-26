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
        public IViewComponentResult Invoke() {
            var currentCategory = RouteData?.Values["category"];
            ViewBag.Category = currentCategory;
            return View(productRepository.GetAllCategories()); 
        }
    }
}
