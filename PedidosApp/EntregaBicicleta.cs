using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{

    //Nueva clase EntregaBicicleta (estrategia)
    public class EntregaBicicleta : IMetodoEntrega
    {
        public double CalcularCosto(int km) => 3 * km;
        public string TipoEntrega() => "bicicleta";
    }
}
