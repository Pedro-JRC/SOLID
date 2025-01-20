

namespace _4_PrincSegInt_ISP
{
    public class Gerente : InterTrabajar, InterDescansar, InterComer
    {
        public void Trabajar()
        {
            // LOGICA PARA GESTION DE PROYECTOS
            Console.WriteLine("Gestionando proyectos...");
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
