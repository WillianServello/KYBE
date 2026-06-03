namespace kybe_application.Interface.Service.Abstract.CRUD
{
    public interface IReadOnlyServiceApp<TDetailsDTO>
    {
        Task<ICollection<TDetailsDTO>> GetAllAsync();
        Task<TDetailsDTO> GetByIdAsync(Guid id);
    }
}
