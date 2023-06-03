using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.ProductPicture
{
    public class CreateProductPicture
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long ProductId { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(1000, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Picture { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureAlt { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureTitle { get; set; }

        public List<ProductViewModel> Products { get; set; }


    }
}
