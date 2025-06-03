// See https://aka.ms/new-console-template for more information
using SisPersonal;

Empleado Juan = new Empleado("Juan", "Girbau", new DateTime(1980, 8, 3), 'c', new DateTime(1998, 5, 3), 650000, Empleado.Cargo.Ingeniero);
Console.WriteLine($"Nombre y apellido: {Juan.Nombre} {Juan.Apellido}");
int edadDelEmpleado = Juan.Edad();
Console.WriteLine(edadDelEmpleado);
Console.WriteLine(Juan.Jubilarse());
Console.WriteLine(Juan.Antiguedad());
Console.WriteLine(Juan.salarioFinal());