namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }

        [StringLength(4000)]
        [Display(Name ="Tài khoản")]
        public string UserName { get; set; }

        [StringLength(4000)]
        [Display(Name ="Mật khẩu")]
        public string PassWord { get; set; }

        [StringLength(4000)]
        [Display(Name ="Tên đầy đủ")]
        public string FullName { get; set; }

        [StringLength(4000)]
        [Display(Name ="Xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }

        [Display(Name ="Mã nhân viên")]
        public long? BusinessPartner_ID { get; set; }

        [StringLength(4000)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(4000)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Display(Name ="Trạng thái")]
        public bool Status { get; set; }
    }
}
