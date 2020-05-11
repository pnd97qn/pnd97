namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterData")]
    public partial class MasterData
    {
        public long ID { get; set; }

        public long? Parent_ID { get; set; }

        [StringLength(4000)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        public long? Religion { get; set; }

        public long? Country { get; set; }

        public long? Positon { get; set; }

        public long? Department { get; set; }

        public long? Organ { get; set; }

        public long? Bank { get; set; }

        public long? University { get; set; }

        public long? Specialized { get; set; }

        [StringLength(4000)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(4000)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? Status { get; set; }
    }
}
