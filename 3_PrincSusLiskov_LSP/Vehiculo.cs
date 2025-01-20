

namespace _3_PrincSusLiskov_LSP
{
    public abstract class Vehiculo
    {
        public virtual void Conducir()
        {
            // LOGICA PARA CONDUCIR VEHICULO
            Console.WriteLine("Conduciendo Vehiculo.");
        }

        public virtual void AbrirMaletero()
        {
            // LOGICA PARA ABRIR MALETERO
            Console.WriteLine("El vehiculo no tiene maletero.");
        }
    }
}
