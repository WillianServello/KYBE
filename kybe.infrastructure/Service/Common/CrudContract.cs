using kybe.infrastructure.Data.Context;
using kybe_domain.Interface.Abstract.Crud;
using kybe_domain.Models.Common.Abstract;
using Microsoft.EntityFrameworkCore;

namespace kybe.infrastructure.Service.Abstract
{
    public abstract class CrudContract<T> : ICrudContract<T> where T : AbstractEntity
    {
        private readonly DatabaseContext _context;

        public DbSet<T> Entity => _context.Set<T>();

        public CrudContract(DatabaseContext context)
            => _context = context ?? throw new ArgumentNullException(nameof(context));

        public virtual async Task AddAsync(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                var error = ex.InnerException?.Message ?? ex.Message;
                throw new Exception(error);
            }
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
            Entity.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
            => await Entity.FirstOrDefaultAsync(x => x.Id == id && x.IsActive)
            ?? throw new ArgumentNullException("Registro não encotrado!");
    }
}
