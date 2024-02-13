using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Models
{
    public class PageModelView
    {
        public int id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string PageTitle { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string CreateDate { get; set; }

        //public double CreateDate { get; set; }
        //public DateTime CreateDate2 { get; set; }
        public IFormFile Image { get; set; }
        public string Image2 { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string PageGroup { get; set; }
        public string Tags { get; set; }

    }
}
