using QuadEFModels.Entities;
using QuadEntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEntityFramework.Repositories.Passive
{
    public class UpdateTrackerRepository : IRepository<UpdateTrackerEntity>
    {
        private DbSet<UpdateTrackerEntity> dbSet;
        private IDbContext db;

        public UpdateTrackerRepository(IDbContext db)
        {
            this.dbSet = db.GetSet<UpdateTrackerEntity>();
            this.db = db;
        }

        public IEnumerable<UpdateTrackerEntity> All
        {
            get
            {
                return this.dbSet.ToList();
            }
        }

        public void Add(UpdateTrackerEntity item)
        {
            this.dbSet.Add(item);
        }

        public void Remove(UpdateTrackerEntity item)
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


        public void Update(UpdateTrackerEntity item)
        {
            this.db.GetEntry(item).State = EntityState.Modified;
            
        }

        public void Save()
        {
            this.db.Save();
        }
    }
}
