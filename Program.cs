

SolicitarYProcesarNumero();

static void SolicitarYProcesarNumero()
{
    Console.Write("Ingrese un número: ");
    if (double.TryParse(Console.ReadLine(), out double numero))
    {
        if (numero > 0)
        {
            Console.WriteLine($"Resultado: {numero * numero}");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Resultado: Número negativo.");
        }
        else
        {
            Console.WriteLine("Resultado: 0");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}