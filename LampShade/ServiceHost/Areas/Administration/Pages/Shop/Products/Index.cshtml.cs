using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        [TempData]
        public string IsSuccedded { get; set; }

        private readonly ShopManagement.Application.Contracts.Product.IProductApplication _productApplication;
        private readonly ShopManagement.Application.Contracts.ProductCategory.IProductCategoryApplication _productCategoryApplication;

        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Products;

        public SelectList ProductCategories;

        public IndexModel(ShopManagement.Application.Contracts.Product.IProductApplication productApplication, ShopManagement.Application.Contracts.ProductCategory.IProductCategoryApplication productCategoryApplication)
        {
            _productApplication = productApplication;
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(ProductSearchModel searchModel)
        {
            Products = _productApplication.Search(searchModel);
            ProductCategories = new SelectList(_productCategoryApplication.GetProductCategories(),
                                               "Id", "Name");
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Categories = _productCategoryApplication.GetProductCategories()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productApplication.GetDetails(id);
            product.Categories = _productCategoryApplication.GetProductCategories();
            return Partial("./Edit", product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetInStock(long id)
        {
            var result = _productApplication.InStock(id);
            if (result.IsSuccedded)
            {
                Message = result.Message;
                IsSuccedded = result.IsSuccedded.ToString();
                return RedirectToPage("./Index");

            }
            Message = result.Message;
            IsSuccedded = result.IsSuccedded.ToString();
            return RedirectToPage("./Index");

        }

        public IActionResult OnGetNotInStock(long id)
        {
            var result = _productApplication.NotInStock(id);
            if (result.IsSuccedded)
            {
                Message = result.Message;
                IsSuccedded = result.IsSuccedded.ToString();
                return RedirectToPage("./Index");

            }
            Message = result.Message;
            IsSuccedded = result.IsSuccedded.ToString();
            return RedirectToPage("./Index");

        }
    }
}
