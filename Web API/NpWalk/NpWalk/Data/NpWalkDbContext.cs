//DbContext class: Maintaining Connection to Db, Perform CRUD, Bridge between domain and Db

using Microsoft.EntityFrameworkCore;
using NpWalk.Models.Domain;

namespace NpWalk.Data
{
    public class NpWalkDbContext: DbContext
    {
        public NpWalkDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties{ get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<Walk> Walks{ get; set; }
    }
}

//DBset : property of Dbcontext that represent collection of entities(model) in Db