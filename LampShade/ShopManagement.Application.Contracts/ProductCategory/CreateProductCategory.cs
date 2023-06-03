﻿using _0_Framework.Application;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        //[MaxLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Name { get;  set; }

        //[MaxLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Description { get;  set; }

        //[MaxLength(1000, ErrorMessage = ValidationMessages.OutOfRange)]
        [StringLength(1000, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Picture { get;  set; }

        //[MaxLength(250, ErrorMessage = ValidationMessages.OutOfRange)]
        [StringLength(250, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureAlt { get;  set; }

        //[MaxLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureTitle { get;  set; }

        //[MaxLength(80, ErrorMessage = ValidationMessages.OutOfRange)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(80, ErrorMessage = ValidationMessages.OutOfRange)]

        public string KeyWords { get; set; }

        //[MaxLength(150, ErrorMessage = ValidationMessages.OutOfRange)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        //[MaxLength(300, ErrorMessage = ValidationMessages.OutOfRange)]
        [StringLength(300, ErrorMessage = ValidationMessages.OutOfRange)]

        public string Slug { get;  set; }
    }
}
