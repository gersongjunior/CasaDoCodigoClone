using System;
using CasaDoCodigo_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo_v1.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected private readonly ApplicationContext contexto;
        protected private readonly DbSet<T> dbSet;


        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
