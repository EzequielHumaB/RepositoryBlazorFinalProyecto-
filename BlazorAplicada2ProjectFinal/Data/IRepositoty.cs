using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BlazorAplicada2ProjectFinal.Data
{
    public interface IRepositoty<T> where T : class
    {

        bool Guardar(T entity);
        List<T> GetList(Expression<Func<T, bool>> expression);

        bool CrearEmployee(T entity);
    }
}
