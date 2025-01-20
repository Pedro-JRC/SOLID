namespace _3_PrincSusLiskov_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAS //

            Vehiculo vehiculo1 = new Bicicleta();
            Vehiculo vehiculo2 = new Coche();

            // INICIO //

            // IMPRIME LOGICA DE BICICLETA
            Console.WriteLine("BICICLETA:");
            vehiculo1.Conducir();
            vehiculo1.AbrirMaletero();


            // IMPRIME LOGICA DE COCHE
            Console.WriteLine("\nCOCHE:");
            vehiculo2.Conducir();
            vehiculo2.AbrirMaletero();
        }
    }
}
