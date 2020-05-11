namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessPartner")]
    public partial class BusinessPartner
    {
        public long ID { get; set; }

        public long? Parent_ID { get; set; }

        [StringLength(4000)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Image { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(4000)]
        public string PlaceOfBirth { get; set; }

        public bool? Sex { get; set; }

        public long? Religion_ID { get; set; }

        public long? Country_ID { get; set; }

        [StringLength(4000)]
        public string idCardNumber { get; set; }

        public long? Position_ID { get; set; }

        public long? Department_ID { get; set; }

        public long? Organ_ID { get; set; }

        public long? LaborContract_ID { get; set; }

        public long? Insurrance_ID { get; set; }

        [StringLength(4000)]
        public string BankNumber { get; set; }

        public long? Bank_ID { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string Email { get; set; }

        [StringLength(4000)]
        public string Phone { get; set; }

        [StringLength(4000)]
        public string MaritalStatus { get; set; }

        public long? University_ID { get; set; }

        public DateTime? GraduatedYear { get; set; }

        [StringLength(4000)]
        public string DegreeAchieved { get; set; }

        [StringLength(4000)]
        public string Specialized { get; set; }

        [StringLength(4000)]
        public string Skill { get; set; }

        [StringLength(4000)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(4000)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? Status { get; set; }
    }
}
