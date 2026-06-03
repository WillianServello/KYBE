namespace kybe_application.Interface.Service.Abstract.Crud
{
    public interface IPostServiceApp<TCreateDTO>
    {
        Task AddAsync(TCreateDTO createDTO);
    }
}
