using System.Collections.Generic;

namespace CasaDoCodigo_v1.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}