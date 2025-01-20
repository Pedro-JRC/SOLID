

namespace _3_PrincSusLiskov_LSP
{
    public class Coche : Vehiculo
    {
        public override void Conducir()
        {
            // LOGICA PARA CONDUCIR EL COCHE
            Console.WriteLine("Conduciendo el coche.");
        }

        public override void AbrirMaletero()
        {
            // LOGICA PARA ABRIR EL MALETERO
            Console.WriteLine("Abriendo el maletero.");
        }
    }
}
