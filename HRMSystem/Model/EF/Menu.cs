namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public long ID { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Icon { get; set; }

        public long? ParentID { get; set; }

        [StringLength(4000)]
        public string SortOrder { get; set; }

        [StringLength(4000)]
        public string Action { get; set; }

        [StringLength(4000)]
        public string Controller { get; set; }

        [StringLength(4000)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(4000)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? Status { get; set; }
    }
}
