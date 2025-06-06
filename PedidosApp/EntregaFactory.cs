﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{

    //Implementacion patron factory clase EntregaFactory
    public static class EntregaFactory
    {

        //Modificacion para implementar a la logica el nuevo metodo de entrega EntregaBicicleta()
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "accesorio" && peso < 2 && !urgente)
                return new EntregaBicicleta();
            else if (peso > 10)
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
