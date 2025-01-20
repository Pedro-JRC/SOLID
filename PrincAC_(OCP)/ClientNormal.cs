using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincAC__OCP_
{
    public class ClientNormal
    {
        public void normal(Data data)
        {
            // LOGICA PARA CALCULAR DESCUENTO DE UN CLIENTE NORMAL
            if (data.cliente == "Normal")
            {
                data.descuento = data.precio * 0.10;
                Console.WriteLine($"Usted es un cliente {data.cliente} por lo tanto tiene un descuento de {data.descuento}$ pesos");
            }
            
        }
    }
}
