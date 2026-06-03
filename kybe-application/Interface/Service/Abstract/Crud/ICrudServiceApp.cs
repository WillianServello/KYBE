using kybe_application.Interface.Service.Abstract.CRUD;

namespace kybe_application.Interface.Service.Abstract.Crud
{
    public interface ICrudServiceApp<TDetailsDTO, TUpdateDTO, TCreateDTO>
        : IReadOnlyServiceApp<TDetailsDTO>, IPostServiceApp<TCreateDTO>, IUpdateServiceApp<TUpdateDTO>, IDeleteServiceApp
    {
    }
}
