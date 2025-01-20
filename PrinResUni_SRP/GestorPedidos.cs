namespace _1_PrinResUni_SRP

{
    public class GestorPedidos
    {         
        // LOGICA PARA CREAR EL PEDIDO
        public void CrearPedido(Data pedido)
        {
            Console.WriteLine($"PEDIDO\nPedido creado para el cliente: {pedido.cliente}.\nPor una: {pedido.producto}.");
        }
    }
}
