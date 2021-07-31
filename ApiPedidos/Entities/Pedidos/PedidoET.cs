using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Pedidos
{
    public class PedidoET
    {
        public DateTime? fechaRegistro { get; set; }
        public string cliente { get; set; }
        public string estado { get; set; }
        public string direccionEntrega { get; set; }
        public string prioridad { get; set; }
        public decimal? valorTotal { get; set; }
    }
}
