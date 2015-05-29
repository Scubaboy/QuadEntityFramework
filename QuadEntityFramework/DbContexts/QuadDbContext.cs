using QuadEntityFramework.Entities;
using QuadEntityFramework.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace QuadEntityFramework.DbContexts
{
    public class QuadDbContext : DbContext, IDbContext
    {
        public DbSet<ActiveQuadEntity> Quads { get; set; }
        public DbSet<UpdateTrackerEntity> UpdateTracker { get; set; }

        public QuadDbContext():
            base()
        {

        }

        public QuadDbContext(string connectionString) :
            base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveQuadEntity>();
            modelBuilder.Entity<UpdateTrackerEntity>();
        }


        public int Save()
        {
            return this.SaveChanges();
        }


        public DbSet<T> GetSet<T>() where T : class
        {
            return Set<T>();
        }


        public DbEntityEntry<T> GetEntry<T>(T entity) where T : class
        {
            return Entry<T>(entity);
        }
    }
}
