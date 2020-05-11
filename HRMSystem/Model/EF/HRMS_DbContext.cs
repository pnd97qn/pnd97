namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HRMS_DbContext : DbContext
    {
        public HRMS_DbContext()
            : base("name=HRMS_DbContext")
        {
        }

        public virtual DbSet<BusinessPartner> BusinessPartners { get; set; }
        public virtual DbSet<CheckInOut> CheckInOuts { get; set; }
        public virtual DbSet<Insurrance> Insurrances { get; set; }
        public virtual DbSet<LaborContract> LaborContracts { get; set; }
        public virtual DbSet<MasterData> MasterDatas { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LaborContract>()
                .Property(e => e.Salary)
                .HasPrecision(19, 0);
        }
    }
}
