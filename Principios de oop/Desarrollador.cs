using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Principios_de_oop
{
    public class Desarrollador : Empleado
    {
        public string LenguajeProgramacion { get; private set; }

        public Desarrollador(string nombre, int edad, string lenguajeProgramacion)
            : base(nombre, edad)
        {
            LenguajeProgramacion = lenguajeProgramacion;
        }

        // Implementación del método abstracto - Polimorfismo
        public override void Trabajar()
        {
            Console.WriteLine($"{Nombre}, el desarrollador, está escribiendo código en {LenguajeProgramacion}.");
        }
    }
}
