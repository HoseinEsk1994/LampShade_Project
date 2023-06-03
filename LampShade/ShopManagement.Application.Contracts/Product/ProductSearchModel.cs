using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ShopManagement.Application.Contracts.Product
{
    public class ProductSearchModel 
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public long CategoryId { get; set; }
    }
    
}
