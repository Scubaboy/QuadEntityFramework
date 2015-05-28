using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace QuadEntityFramework.Interfaces
{
    public interface IDbContext
    {
        /// <summary>
        /// Get the set of a certain type
        /// </summary>
        /// <typeparam name="T">The class of the entity</typeparam>
        /// <returns>The <see cref="DbSet"/>.</returns>
        DbSet<T> Set<T>() where T : class;

        /// <summary>
        /// Save changes.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        int Save();

        /// <summary>
        /// The context entry.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <typeparam name="T">The class of the entity</typeparam>
        /// <returns>The <see cref="DbEntityEntry"/>.</returns>
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
