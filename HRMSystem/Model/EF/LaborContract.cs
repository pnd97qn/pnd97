namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LaborContract")]
    public partial class LaborContract
    {
        public long ID { get; set; }

        [StringLength(4000)]
        public string Number { get; set; }

        [StringLength(4000)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Classify { get; set; }

        [StringLength(4000)]
        public string StatusContract { get; set; }

        public decimal? Salary { get; set; }

        public DateTime? DayToWork { get; set; }

        public DateTime? SignDay { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? DecisionNumber { get; set; }

        [StringLength(4000)]
        public string Content { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(4000)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(4000)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? Status { get; set; }
    }
}
