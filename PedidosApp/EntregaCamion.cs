using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    public class EntregaCamion : IMetodoEntrega
    {

        //Strategy Entrega Camion
        public double CalcularCosto(int km) => 5 * km;
        public string TipoEntrega() => "Camión";
    }
}
