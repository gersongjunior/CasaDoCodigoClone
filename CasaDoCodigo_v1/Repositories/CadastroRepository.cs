using System;
using CasaDoCodigo_v1.Models;

namespace CasaDoCodigo_v1.Repositories
{
    public interface ICadastroRepository
    {

    }

    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
