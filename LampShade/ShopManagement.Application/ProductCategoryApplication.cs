using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_productCategoryRepository.Exists(x => x.Name == command.Name));
            {
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد");
            }

            var Slug = command.Slug.Slugify();
            var productCategory = new ProductCategory(command.Name, command.Description, command.Picture
                                                      , command.PictureAlt, command.PictureTitle, command.KeyWords
                                                      , command.MetaDescription, Slug);
            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);
            if(productCategory == null)
            {
                return operation.Failed("رکورد با اطلاعات درخواست شده یافت نشد."); 
            }

            if(_productCategoryRepository.Exists(x => x.Name == command.Name && x.Id != command.Id)) 
            {
                return operation.Failed("امکان تغییر رکورد به دلیل تکراری بودن آن وجود ندارد.");
            }

            var Slug = command.Slug.Slugify();
            productCategory.Edit(command.Name, command.Description, command.Picture, command.PictureAlt
                                 , command.PictureTitle, command.KeyWords, command.MetaDescription, Slug);

            _productCategoryRepository.SaveChanges();
            return operation.Succedded();




        }

        public EditProductCategory GetDetails(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}
