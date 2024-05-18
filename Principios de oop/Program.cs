using Principios_de_oop;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear una lista de empleados
        List<Empleado> empleados = new List<Empleado>
        {
            new Gerente("Ana", 45),
            new Desarrollador("Luis", 30, "C#"),
            new Desarrollador("Marta", 28, "Java")
        };

        // Polimorfismo: Llamar al método Trabajar() de cada empleado
        foreach (Empleado empleado in empleados)
        {
            empleado.Trabajar();
        }
    }
}
