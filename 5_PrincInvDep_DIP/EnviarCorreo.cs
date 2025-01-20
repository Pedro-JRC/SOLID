

namespace _5_PrincInvDep_DIP
{
    public class EnvioDeCorreo
    {
        private readonly ClienteCorreo clienteCorreo;

        // DEPENDENCIA A TRAVES DEL CONSTRUCTOR
        public EnvioDeCorreo(ClienteCorreo clienteCorreo)
        {
            this.clienteCorreo = clienteCorreo;
        }

        public void EnviarCorreo(Data data)
        {
            clienteCorreo.Enviar(data);
        }
    }
}
