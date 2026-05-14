using kybe.infrastructure.Data.Context;
using kybe_domain.Entity.Abstract;
using kybe_domain.Interface.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Repository.Abstract
{
    public abstract class GenericEntityRepository<T> : IGenericEntity<T> where T : GenericEntity
    {
        private readonly DatabaseContext _context;

        public DbSet<T> Entity => _context.Set<T>();

        public GenericEntityRepository(DatabaseContext context)
            => _context = context ?? throw new ArgumentNullException(nameof(context)); 

        public virtual async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            Entity.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
           => await Entity.Where(x => x.IsActive).ToListAsync();

        public virtual async Task DeleteAsync(T entity)
        {
            Entity.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
            => await Entity.FirstOrDefaultAsync(x => x.Id == id && x.IsActive) 
            ?? throw new ArgumentNullException("Registro não encotrado!");
    }
}
