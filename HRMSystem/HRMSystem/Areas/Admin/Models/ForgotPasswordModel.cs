using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSystem.Areas.Admin.Models
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage ="Mời bạn xác nhận tài khoản hoặc email")]
        public string UserName { get; set; }
    }
}