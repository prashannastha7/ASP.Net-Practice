//DbContext class is a bridge betw model and db, interctaing with db and performs CRUD on tables

using Microsoft.EntityFrameworkCore;
using NpWalks.API.Models.Domain;

namespace NpWalks.API.Data
{
    public class NpWalkDbContext: DbContext
    {
        public NpWalkDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        { 

        }
        //DbSet represent a collection of entities in the db
        public DbSet<Difficulty> Difficulties{ get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<Walk> Walks{ get; set; }
    }
}
