using ApiPedidos.DAO.PedidosDAO;
using Entities.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.BLL.Pedidos
{
    public class Pedidos: IPedidos
    {
        private readonly IPedidosDAO _pedidosDAO;
        public Pedidos(IPedidosDAO pedidosDAO)
        {
            _pedidosDAO = pedidosDAO;
        }

        public Pedidos()
        {
            _pedidosDAO = new PedidosDAO();
        }

        public List<PedidoET> getPedidos()
        {
            List<PedidoET> pedidos = new List<PedidoET>();
            foreach (var item in _pedidosDAO.GetOrdenPedidos())
            {
                PedidoET cl = new PedidoET();
                cl.fechaRegistro = item.FechaRegistro;
                cl.cliente = item.ClienteID.ToString();
                cl.direccionEntrega = item.DireccionEntrega;
                cl.estado = item.Estado;
                cl.prioridad = item.Prioridad;
                cl.valorTotal = item.ValorTotal;
                pedidos.Add(cl);
            }
            return pedidos;
        }

        public List<ClienteET> getClientes() 
        {
            List<ClienteET> clientes = new List<ClienteET>();
            foreach (var item in _pedidosDAO.GetClientes())
            {
                ClienteET cl = new ClienteET();
                cl.idCliente = item.ClienteID;
                cl.nombre = item.Nombre;
                clientes.Add(cl);
            }
            return clientes;
        }

        public List<ProductoET> getProducts()
        {
            List<ProductoET> products = new List<ProductoET>();
            foreach (var item in _pedidosDAO.GetProducts())
            {
                ProductoET cl = new ProductoET();
                cl.idProducto = item.ProductoID;
                cl.nombreProducto = item.Nombre;
                cl.codigoProducto = item.Codigo;
                products.Add(cl);
            }
            return products;
        }
    }
}
