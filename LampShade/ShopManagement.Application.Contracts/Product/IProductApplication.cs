using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.Product
{
    public interface IProductApplication
    {
        OperationResult Create(CreateProduct entity);

        OperationResult Edit(EditProduct command);

        EditProduct GetDetails(long id);

        List<ProductViewModel> Search(ProductSearchModel search);

        OperationResult InStock(long id);

        OperationResult NotInStock(long id);

        List<ProductViewModel> GetProducts();


    }
}
