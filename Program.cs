Console.WriteLine("Menu de operaciones");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");
Console.WriteLine("5. Salir");
Console.WriteLine("Seleccione una opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());
switch (opcion)
{
    case 1:
        // Console.WriteLine("Ingrese el primer número: ");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Ingrese el segundo número: ");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        // int suma = num1 + num2;
        // Console.WriteLine("La suma es: " + suma);
        int suma = Sumar();
        Console.WriteLine("La suma es: " + suma);
        break;
    case 2:
        Console.WriteLine("Ingrese el primer número: ");
        int num3 = ccc
        Console.WriteLine("Ingrese el segundo número: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int resta = num3 - num4;
        Console.WriteLine("La resta es: " + resta);
        break;
    case 3:
        Console.WriteLine("Ingrese el primer número: ");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        int num6 = Convert.ToInt32(Console.ReadLine());
        int multiplicacion = num5 * num6;
        Console.WriteLine("La multiplicación es: " + multiplicacion);
        break;
    case 4:
        Console.WriteLine("Ingrese el primer número: ");
        int num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        int num8 = Convert.ToInt32(Console.ReadLine());
        int division = num7 / num8;
        Console.WriteLine("La división es: " + division);
        break;
    case 5:
        Console.WriteLine("Saliendo del programa...");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}

int Sumar() 
{
    Console.WriteLine("Incializando el llamado de la funcion sumar");
    return 10 + 30;
}