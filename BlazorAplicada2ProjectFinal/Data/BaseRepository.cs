using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data;

namespace BlazorAplicada2ProjectFinal.Data
{
    public class BaseRepository<T> : IDisposable, IRepositoty<T> where T : class
    {
        internal Contexto Contexto;

        public BaseRepository()
        {
            Contexto = new Contexto();
        }


        public void Dispose()
        {
            Contexto.Dispose();
        }

      

        public bool Guardar(T entity)
        {
            
            bool paso = false;
            try
            {
                if(Contexto.Set<T>().Add(entity)!=null)
                {
                    paso = Contexto.SaveChanges() > 0;
                }

            }catch
            {
                throw;
            }

            return paso;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> lista = new List<T>();
            try
            {
                lista = Contexto.Set<T>().Where(expression).ToList();
            }
            catch
            {
                throw;
            }

            return lista;
        }

        public bool CrearEmployee(T entity)
        {
            bool paso = false;

            try
            {
                if(Contexto.Set<T>().Add(entity)!=null)
                {
                    paso = Contexto.SaveChanges() > 0;
                }
            }catch
            {
                throw;
            }
            return paso;
        }

    }
}
