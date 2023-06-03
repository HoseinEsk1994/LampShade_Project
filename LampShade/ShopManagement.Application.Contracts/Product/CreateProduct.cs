﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ShopManagement.Application.Contracts.Product
{
    public class CreateProduct
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Name { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Slug { get;  set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(20, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Code { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public double UnitPrice { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string ShortDescription { get; set; }


        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Description { get; set; }


        [StringLength(1000, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Picture { get; set; }


        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureAlt { get; set; }


        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureTitle { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(100, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Keywords { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(150, ErrorMessage = ValidationMessages.OutOfRange)]
        public string MetaDescription { get; set; }


        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get; set; }

        public List<ProductCategoryViewModel> Categories { get; set; }


    }
}
