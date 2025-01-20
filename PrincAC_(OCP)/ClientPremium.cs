

namespace PrincAC__OCP_
{
    public class ClientPremium
    {
        public void Premium(Data data)
        {
            if (data.cliente == "Premium")
            {
                // LOGICA PARA CALCULAR DESCUENTO DE UN CLIENTE PREMIUM
                data.descuento = data.precio * 0.15;
                Console.WriteLine($"Usted es un cliente {data.cliente} por lo tanto tiene un descuento de {data.descuento}$ pesos.");
            }
        }

    }
}
