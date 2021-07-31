using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.DAO.PedidosDAO
{
    public interface IPedidosDAO
    {
        List<OrdenPedido> GetOrdenPedidos();
        List<Producto> GetProducts();
        List<Cliente> GetClientes();
        void CreateOrden(int idCliente, List<OrdenProducto> productos, string direccionEntrega, string prioridad, decimal ValorTotalOrden);
    }
}
