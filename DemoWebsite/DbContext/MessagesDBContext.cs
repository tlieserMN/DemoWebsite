namespace DemoWebsite
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MessagesDbContext : DbContext
    {
        public MessagesDbContext()
            : base("name=DemoDatabase")
        {
        }

        public virtual DbSet<Friend> Conversations { get; set; }
        public virtual DbSet<Message> ConversationMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(e => e.Header)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Body)
                .IsUnicode(false);
        }
    }
}
