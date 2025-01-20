
namespace PrincAC__OCP_
{
    internal class ClientVip
    {
        public void Vip(Data data)
        {
            if (data.cliente == "Vip")
            {
                // LOGICA PARA CALCULAR DESCUENTO DE UN CLIENTE VIP
                data.descuento = data.precio * 0.20;
                Console.WriteLine($"Usted es un cliente {data.cliente} por lo tanto tiene un descuento de {data.descuento}$ pesos.");
            }
        }
    }
}
