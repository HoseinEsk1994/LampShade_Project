using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.Slide
{
    public class CreateSlide
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(1000, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Picture { get;  set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureTitle { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(500, ErrorMessage = ValidationMessages.OutOfRange)]
        public string PictureAlt { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Heading { get; set; }


        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Title { get; set; }


        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Text { get; set; }


        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = ValidationMessages.OutOfRange)]
        public string BtnText { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(1000, ErrorMessage = ValidationMessages.OutOfRange)]
        public string Link { get; set; }

    }
}
