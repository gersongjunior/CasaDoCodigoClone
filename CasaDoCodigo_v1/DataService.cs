using System;
using System.Collections.Generic;
using System.IO;
using CasaDoCodigo_v1.Models;
using CasaDoCodigo_v1.Repositories;
using Newtonsoft.Json;

namespace CasaDoCodigo_v1
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();
            List<Livro> livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }

       

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }

    
}
