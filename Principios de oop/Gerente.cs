
namespace Principios_de_oop
{

    // Clase derivada - Herencia
    public class Gerente : Empleado
    {
        public Gerente(string nombre, int edad) : base(nombre, edad) { }

        // Implementación del método abstracto - Polimorfismo
        public override void Trabajar()
        {
            Console.WriteLine($"{Nombre}, el gerente, está supervisando a los empleados.");
        }
    }
}
