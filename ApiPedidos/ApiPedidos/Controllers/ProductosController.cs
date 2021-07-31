using ApiPedidos.BLL.Pedidos;
using Entities.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiPedidos.Controllers
{
    public class ProductosController : ApiController
    {
        private readonly IPedidos _pedidos;
        public ProductosController(IPedidos pedidos)
        {
            _pedidos = pedidos;
        }

        public ProductosController()
        {
            _pedidos = new Pedidos();
        }

        // GET api/values
        public IEnumerable<ProductoET> Get()
        {
            return _pedidos.getProducts();
        }
    }
}