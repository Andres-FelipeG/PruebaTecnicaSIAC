using ApiPedidos.BLL.Pedidos;
using Entities.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiPedidos.Controllers
{

    public class PedidosController : ApiController
    {
        private readonly IPedidos _pedidos;
        public PedidosController(IPedidos pedidos)
        {
            _pedidos = pedidos;
        }

        public PedidosController()
        {
            _pedidos = new Pedidos();
        }

        // GET api/values
        [DisableCors()]
        public IEnumerable<PedidoET> Get()
        {
            return _pedidos.getPedidos();
        }


        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

    }
}
