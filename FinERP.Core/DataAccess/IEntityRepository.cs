using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinERP.Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // bu da boş geçilebilir yani p=>p.ıd gibi bi kod yazılmayabilir yani
        T Get(Expression<Func<T, bool>> filter); //Expression<Func<T,bool>> şu kod bloğu bize p=>p.ıd gibi bi kod yazma imkanı sunacak filter yerine yazacaz 
    }
}
