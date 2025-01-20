namespace _2_PrincAC__OCP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAS //

            Data data = new Data();
            ClientNormal clientNormal = new ClientNormal();
            ClientPremium clientPremium = new ClientPremium();
            ClientVip clientVip = new ClientVip();

            // INICIO //

            // IMPRIME DESCUENTO NORMAL
            clientNormal.normal(data);

            // IMPRIME DESCUENTO PREMIUM
            clientPremium.Premium(data);

            //IMPRIME DESCUENTO VIP
            clientVip.Vip(data);
        }
    }
}
