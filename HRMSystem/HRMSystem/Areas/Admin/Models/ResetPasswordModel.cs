using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSystem.Areas.Admin.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage ="Mời bạn nhập mật khẩu mới")]
        public string PassWord { get; set; }

        [Required(ErrorMessage ="Mời bạn xác nhận lại mật khẩu mới")]
        public string ConfirmPassword { get; set; }
    }
}