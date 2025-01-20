namespace _4_PrincSegInt_ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAS //

            InterTrabajar programador = new Programador();
            InterTrabajar gerente = new Gerente();
            InterTrabajar robotMecanico = new RobotMecanico();

            InterComer comer = new Programador();
            InterComer comer1 = new Gerente();

            InterDescansar descansar = new Programador();
            InterDescansar descansar1 = new Gerente();  

            // INICIO //

            // PROGRAMADOR
            Console.WriteLine("PROGRAMADOR:");
            programador.Trabajar();
            comer.Comer();
            descansar.Descansar();

            // GERENTE
            Console.WriteLine("GERENTE:");
            gerente.Trabajar();
            comer1.Comer();
            descansar1.Descansar();

            // ROBOT MECANICO
            Console.WriteLine("ROBOT MECANICO:");
            robotMecanico.Trabajar();  

        }
    }
}
