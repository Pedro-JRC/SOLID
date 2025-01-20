namespace _1_PrinResUni_SRP

{
    public class GestorEnvios
    {
        // LOGICA PARA ENVIAR UN PEDIDO
        public void EnviarPedido(Data pedido)
        {
            Console.WriteLine($"\nENVIO\nPedido enviado a la dirección: {pedido.direccion}.\nDel cliente: {pedido.cliente}.");
        }
    }
}
