
namespace _1_PrinResUni_SRP

{
    public class GestorFacturas
    {
        public void CrearFactura(Data pedido)
        {
            // LOGICA PARA CREAR UNA FACTURA
            Console.WriteLine($"\nFACTURA\nCliente: {pedido.cliente}\nProducto: {pedido.producto}\nPrecio: {pedido.precio}");
        }


    }
}

