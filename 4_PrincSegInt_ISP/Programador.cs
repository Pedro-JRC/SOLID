

namespace _4_PrincSegInt_ISP
{
    public class Programador : InterTrabajar, InterDescansar, InterComer
    {
        public void Trabajar()
        {
            // LOGICA DEL TRABAJO
            Console.WriteLine("Desarrollando...");
        }

        public void Descansar()
        {   
            // LOGICA PARA TOMAR DESCANSO
            Console.WriteLine("Descansando...\n");
        }

        public void Comer()
        {
            // LOGICA PARA COMER
            Console.WriteLine("Comiendo...");
        }
    }
}
