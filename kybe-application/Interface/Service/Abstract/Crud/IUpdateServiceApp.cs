namespace kybe_application.Interface.Service.Abstract.Crud
{
    public interface IUpdateServiceApp<TUpdateDTO>
    {
        Task UpdateAsync(Guid id, TUpdateDTO updateDTO);
    }
}
