using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Calculadora numerito = new Calculadora();

string input;
double a;
do
{
    Console.WriteLine("Escriba la operación a realizar suma, resta, mult, div, limpiar o exit para salir");
    input = Console.ReadLine();
    switch (input)
    {
        case "suma":
            a = LeerNumero();
            numerito.Sumar(a);
            break;
        case "resta":
            a = LeerNumero();
            numerito.Restar(a);
            break;
        case "mult":
            a = LeerNumero();
            numerito.Multiplicar(a);
            break;
        case "div":
             a = LeerNumero();
    
            if (a == 0)
            {
                Console.WriteLine("NO EXISTE LA DIVISIÓN EN CERO");
            }
            else
            {
                numerito.Dividir(a);
            }
            break;
            case "limpiar":
            numerito.Limpiar();
            Console.WriteLine("Limpiado!");
            break;
        case "exit":
            break;
        default:
            Console.WriteLine("No es una opción válida");
            break;
    }
    Console.WriteLine("Resultado = " + numerito.Resultado);
} while (input != "exit");


float LeerNumero()
{
    float a;
    bool Resultado;
    do
    {
        Console.WriteLine("Escriba un numero: ");
        Resultado = float.TryParse(Console.ReadLine(), out a);
        if (!Resultado)
        {
            Console.WriteLine("No es un número válido");
        }
    } while (!Resultado);
    return a;
}