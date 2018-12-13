namespace DemoWebsite
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NamesDbContext : System.Data.Entity.DbContext
    {
        public NamesDbContext()
            : base("name=TestConnection")
        {
        }

        public virtual DbSet<Name> Names { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Name>()
                .Property(e => e.F_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Name>()
                .Property(e => e.L_NAME)
                .IsUnicode(false);
        }
    }
}
