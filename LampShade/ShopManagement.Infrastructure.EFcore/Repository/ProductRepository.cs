using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Infrastructure.EFcore.Repository
{
    public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProduct GetDetails(long id)
        {
            return _context.Products.Select(x => new EditProduct()
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                Code = x.Code,
                Slug = x.Slug,
                ShortDescription = x.ShortDescription,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Name = x.Name,
                Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt
            }).FirstOrDefault(x => x.Id == id);
        }



        public List<ProductViewModel> Search(ProductSearchModel search)
        {
            var query = _context.Products
                       .Include(x => x.Category)
                       .Select(x => new ProductViewModel
                       {
                           Id = x.Id,
                           Name = x.Name,
                           Category = x.Category.Name,
                           CategoryId = x.CategoryId,
                           Code = x.Code,
                           Picture = x.Picture,
                           UnitPrice = x.UnitPrice,
                           IsInStock = x.IsInStock,
                           CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
                        });
            if (!string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.Contains(search.Name));
            }

            if (!string.IsNullOrWhiteSpace(search.Code))
            {
                query = query.Where(x => x.Code.Contains(search.Code));
            }

            if (search.CategoryId != 0)
            {
                query = query.Where(x => x.CategoryId == search.CategoryId);
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public List<ProductViewModel> GetProducts()
        {
            return _context.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }


    }
}
