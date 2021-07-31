using Entities.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.BLL.Pedidos
{
    public interface IPedidos
    {
        List<PedidoET> getPedidos();
        List<ClienteET> getClientes();
        List<ProductoET> getProducts();
    }
}
