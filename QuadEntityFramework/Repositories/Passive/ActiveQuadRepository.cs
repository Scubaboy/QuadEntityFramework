using QuadEntityFramework.Entities;
using QuadEntityFramework.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuadEntityFramework.Repositories.Passive
{
    public class ActiveQuadRepository : IRepository<ActiveQuadEntity>
    {
        private DbSet<ActiveQuadEntity> dbSet;
        private IDbContext db;

        public ActiveQuadRepository(IDbContext db)
        {
            this.dbSet = db.GetSet<ActiveQuadEntity>();
            this.db = db;
        }

        public IEnumerable<ActiveQuadEntity> All
        {
            get
            {
                return this.dbSet.ToList();
            }
        }

        public void Add(ActiveQuadEntity item)
        {
            this.dbSet.Add(item);
            
        }

        public void Remove(ActiveQuadEntity item)
        {
            this.dbSet.Remove(item);
        }

        public void Clear()
        {
            if (this.dbSet.Any())
            {
                foreach (var item in this.dbSet)
                {
                    this.dbSet.Remove(item);
                }
            }
        }


        public void Update(ActiveQuadEntity item)
        {
            this.db.GetEntry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            this.db.Save();
        }
    }
}
