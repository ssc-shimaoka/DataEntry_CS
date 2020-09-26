namespace DataEntry_CS.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HumanInfoDbContext : DbContext
    {

        public HumanInfoDbContext()
            : base("name=HumanInfoDbContext")
        {
        }

        public DbSet<HumanInfo> HumanInfos { get; set; }

    }
}