// See https://aka.ms/new-console-template for more information
using SisPersonal;

Empleado[] Arreglo = { new Empleado("Mariano", "Girbau", new DateTime(1999, 9, 12), 'c', new DateTime(2011, 5, 3), 650000, Empleado.Cargo.Ingeniero), new Empleado("Santiago", "Girbau", new DateTime(2001, 8, 3), 'c', new DateTime(2013, 8, 25), 650000, Empleado.Cargo.Ingeniero), new Empleado("Joaquina", "Girbau", new DateTime(2005, 8, 3), 'c', new DateTime(2021, 5, 3), 650000, Empleado.Cargo.Administrativo) };
double totalAPagar = 0;
int i = 0;
int proximoAJubilarse = 0;
foreach (var persona in Arreglo)
{

    Console.WriteLine($"Nombre y apellido: {persona.Nombre} {persona.Apellido}");
    int edadDelEmpleado = persona.Edad();
    Console.WriteLine($"Tiene {edadDelEmpleado} años.");
    Console.WriteLine($"Le falta {persona.Jubilarse()} años para jubilarse");
    Console.WriteLine($"Tiene una antiguedad de {persona.Antiguedad()} años");
    Console.WriteLine($"Su sueldo final es de {persona.salarioFinal()}");
    totalAPagar += persona.salarioFinal();
    if (persona.Jubilarse() < proximoAJubilarse)
    {
        proximoAJubilarse = i;
    }
    i++;
}


Console.WriteLine($"Se paga en total a todos los empleados ${totalAPagar}");

Console.WriteLine($"La persona q más cerca está de jubilarse es la de índice {proximoAJubilarse} en el arreglo");