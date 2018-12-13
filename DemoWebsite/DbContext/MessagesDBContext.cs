using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DemoWebsite.Models;

namespace DemoWebsite.DbContext
{
    public class MessagesDBContext : System.Data.Entity.DbContext
    {
        public MessagesDBContext()
        {
            this.Database.Connection.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=dbo.test;Trusted_Connection=True";
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}