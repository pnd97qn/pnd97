using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMSystem.Areas.Admin.Models
{
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string ConfirmPassword { get; set; }

        public bool Agree { get; set; }
    }
}