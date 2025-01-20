namespace _5_PrincInvDep_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAS //
            ClienteCorreo smtpCliente = new SmtpCliente();
            EnvioDeCorreo envio = new EnvioDeCorreo(smtpCliente);
            Data data = new Data();

            // INICIO //

            // USO DEL SERVICIO PARA ENVIAR EL CORREO
            envio.EnviarCorreo(data);
        }
    }
}
