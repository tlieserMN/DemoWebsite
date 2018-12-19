namespace DemoWebsite
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HomeDbContext : DbContext
    {
        public HomeDbContext()
            : base("name=DemoDatabase")
        {
        }
        
        public virtual DbSet<Message> HomeMessages { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Message>()
        //        .Property(e => e.Header)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Message>()
        //        .Property(e => e.Body)
        //        .IsUnicode(false);
        //}
    }
}
