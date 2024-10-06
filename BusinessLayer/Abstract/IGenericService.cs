
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> 
    {
        void TAdd (T t);
        void TUpdate (T t);
        void TDelete (T t);
        List<T> TGetAll ();
        T TGetById(int id);
        //List<T> GetByFilter (Expression<Func<T, bool>> filter); 

    }
}
