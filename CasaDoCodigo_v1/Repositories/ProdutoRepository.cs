using System;
using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo_v1.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;
        private readonly DbSet<Produto> dbSet;


        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<Produto>();
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        { 
            foreach (var livro in livros)
            {
                if (!dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
                    dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
            }
            contexto.SaveChanges();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
