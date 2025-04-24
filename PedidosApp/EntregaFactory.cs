using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{

    //Implementacion patron factory clase EntregaFactory
    public static class EntregaFactory
    {
        public static class EntregaFactory
        {
            public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
            {
                if (peso > 10)
                    return new EntregaCamion();
                else if (tipoProducto == "tecnología" && urgente)
                    return new EntregaDron();
                else if (tipoProducto == "accesorio")
                    return new EntregaMoto();
                else if (tipoProducto == "componente")
                    return new EntregaCamion();
                else
                    return new EntregaMoto(); // Por defecto
            }
        }
    }
}
