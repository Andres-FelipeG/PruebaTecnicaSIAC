using ApiPedidos.BLL.Pedidos;
using Entities.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiPedidos.Controllers
{
    public class ClientesController : ApiController
    {
        private readonly IPedidos _pedidos;
        public ClientesController(IPedidos pedidos)
        {
            _pedidos = pedidos;
        }

        public ClientesController()
        {
            _pedidos = new Pedidos();
        }

        // GET api/values
        public IEnumerable<ClienteET> Get()
        {
            return _pedidos.getClientes();
        }
    }
}