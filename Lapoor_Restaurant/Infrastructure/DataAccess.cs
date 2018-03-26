using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapoor_Restaurant.Domain.Infrastructure
{
    public class DataAccess : DbContext
    {
        private string v;

        public DataAccess() : base("MyConnectionString")
        {
  
                new Lapoor_Restaurant.Domain.Infrastructure.DataInitializer();
        }

        public DataAccess(string v)
        {
            this.v = v;
        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public object Database { get; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}