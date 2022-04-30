using bootShop.Business;
using Microsoft.AspNetCore.Mvc;

namespace bootShop.Web.ViewComponents
{
    public class MenuViewComponent : ViewComponent // Sonu ViewComponent ile bitmeli
    {
        private ICategoryService categoryService;

        public MenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }
    }
}
