

using System.Net.Mime;

namespace _5_PrincInvDep_DIP
{
    public class SmtpCliente : ClienteCorreo
    {
        public void Enviar(Data data)
        {  
            // LOGICA PARA ENVIAR CORREO SMTP
            Console.WriteLine($"Destinatario: {data.Correo}\nMensaje: {data.Mensaje}");
        }
    }
}
