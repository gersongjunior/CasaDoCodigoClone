using System.Collections.Generic;
using CasaDoCodigo_v1.Models;

namespace CasaDoCodigo_v1.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}