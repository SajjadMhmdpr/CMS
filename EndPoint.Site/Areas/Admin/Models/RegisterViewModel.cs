using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="{0} را وارد کنید")]
        [Display(Name ="نام کاربری")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "{0} را وارد کنید")]
        [Display(Name = "رمز")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "{0} را وارد کنید")]
        [Display(Name = "رمز")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "{0} را وارد کنید")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

    }
}
