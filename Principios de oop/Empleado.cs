
namespace Principios_de_oop
{
    // Clase base abstracta - Abstracción
     public abstract class Empleado
    {
        // Propiedades encapsuladas
        public string Nombre { get; private set; }
        public int Edad { get; private set; }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método abstracto - Abstracción
        public abstract void Trabajar();
    }
}

