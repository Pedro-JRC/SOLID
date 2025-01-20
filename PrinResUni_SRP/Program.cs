namespace _1_PrinResUni_SRP

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAS //

            Data pedido = new Data();
            GestorPedidos gestorPedidos = new GestorPedidos();
            GestorEnvios gestorEnvios = new GestorEnvios();
            GestorFacturas gestorFacturas = new GestorFacturas();


            //  INICIO //

            // IMPRIME TITULO
            Console.WriteLine("TIENDA EN LINEA\n");

            // IMPRIME EL PEDIDO
            gestorPedidos.CrearPedido(pedido);

            // IMPRIME EL ENVIO
            gestorEnvios.EnviarPedido(pedido);

            // IMPRIME LA FACTURA
            gestorFacturas.CrearFactura(pedido);
        }
    }
}
