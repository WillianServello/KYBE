using kybe_domain.Models.Common.Abstract;

namespace kybe_domain.Interface.Abstract.Crud
{
    public interface ICrudContract<T> : ICreateOperation<T>, IReadOnlyOperation<T>, IUpdateOperation<T>, IDeleteOperation<T> where T : AbstractEntity
    {

    }
}
