using Personal;  // Importar el namespace donde está Empleado y Cargos
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Program
{
    static void Main()
    {
        // Crear un empleado nuevo
        Empleado emp = new Empleado();

        // Asignar valores
        emp.Nombre = "Juan";
        emp.Apellido = "Pérez";
        emp.Fechadenac = new DateTime(1985, 5, 20);
        emp.Estadocivil = 'C';  // Casado
        emp.IngresoEmpresa = new DateTime(2010, 3, 15);
        emp.Sueldobasico = 1000000;  // Un millón
        emp.Cargo = Cargos.Ingeniero;

        // Mostrar datos calculados
        Console.WriteLine($"Empleado: {emp.Nombre} {emp.Apellido}");
        Console.WriteLine($"Edad: {emp.Edad()} años");
        Console.WriteLine($"Antigüedad: {emp.Antiguedad()} años");
        Console.WriteLine($"Años para jubilarse: {emp.Jubilacion()}");
        Console.WriteLine($"Salario calculado: ${emp.Salario():N0}");

        Console.ReadLine();  // Pausar para ver resultados
    }
}
