using System;
using CasaDoCodigo_v1.Models;

namespace CasaDoCodigo_v1.Repositories
{
    public interface IItemPedidoRepository
    {

    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
