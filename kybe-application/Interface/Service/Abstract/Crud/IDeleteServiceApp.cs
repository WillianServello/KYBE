namespace kybe_application.Interface.Service.Abstract.Crud
{
    public interface IDeleteServiceApp
    {
        Task DeleteAsync(Guid Id);
    }
}
