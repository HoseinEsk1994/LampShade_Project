using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel

    {
        [TempData]
        public string ErrorMsg { get; set; }


        private readonly IProductCategoryApplication _productCategoryApplication;

        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategories;

        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(ProductCategorySearchModel searchModel)
        {
            ProductCategories = _productCategoryApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {


            return Partial("./Create", new CreateProductCategory());


        }

        public IActionResult OnPostCreate(CreateProductCategory command)
        {
            //if (ModelState.IsValid)
            //{
                var result = _productCategoryApplication.Create(command);
                return new JsonResult(result);
            //}

            //else
            //{
            //    ErrorMsg = "Œÿ« œ— À»  «ÿ·«⁄« ";
            //    ViewData["error"] = "Œÿ«";

            //    return RedirectToPage("./Index");
            //}

        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryApplication.GetDetails(id);
            return Partial("./Edit", productCategory);
        }

        public JsonResult OnPostEdit(EditProductCategory command)
        {
            var result = _productCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
