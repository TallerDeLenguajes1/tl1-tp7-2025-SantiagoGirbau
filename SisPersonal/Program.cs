// See https://aka.ms/new-console-template for more information
using SisPersonal;

Empleado Santiago = new Empleado("Mariano", "Girbau Alfaro");
Console.WriteLine($"Nombre y apellido: {Santiago.Nombre} {Santiago.Apellido}");
Santiago.Nombre= "Santiago";
Santiago.Apellido= "Girbau";
Console.WriteLine($"Nombre y apellido: {Santiago.Nombre} {Santiago.Apellido}");
