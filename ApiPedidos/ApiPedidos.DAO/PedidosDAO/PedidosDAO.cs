using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.DAO.PedidosDAO
{
    public class PedidosDAO: IPedidosDAO
    {
        public List<OrdenPedido> GetOrdenPedidos()
        {
            using (DbConnection db = new DbConnection())
            {
                return db.OrdenPedido.ToList();
            }
        }

        public List<Producto> GetProducts()
        {
            using (DbConnection db = new DbConnection())
            {
                return db.Producto.ToList();
            }
        }

        public List<Cliente> GetClientes()
        {
            using (DbConnection db = new DbConnection())
            {
                return db.Cliente.ToList();
            }
        }

        public void CreateOrden(int idCliente, List<OrdenProducto> productos, string direccionEntrega, string prioridad, decimal ValorTotalOrden)
        {
            using (DbConnection db = new DbConnection())
            {
                db.OrdenPedido.Add(new OrdenPedido()
                {
                    ClienteID = idCliente,
                    FechaRegistro = DateTime.Now,
                    Estado = "Registrado",
                    DireccionEntrega = direccionEntrega,
                    Prioridad = prioridad,
                    ValorTotal = ValorTotalOrden
                });
                db.SaveChanges();
            }
        }
    }
}
