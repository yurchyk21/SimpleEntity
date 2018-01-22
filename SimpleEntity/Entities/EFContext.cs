using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEntity.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("ConnectionShopDB")
        {
        }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
