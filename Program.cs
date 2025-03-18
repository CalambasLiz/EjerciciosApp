

// SolicitarYProcesarNumero(); 
SolicitarYProcesarDosNumeros();

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

static void SolicitarYProcesarDosNumeros()
{
    Console.Write("Ingrese el primer número: ");
    if (double.TryParse(Console.ReadLine(), out double numero1))
    {
        Console.Write("Ingrese el segundo número: ");
        if (double.TryParse(Console.ReadLine(), out double numero2))
        {
            if (numero1 > numero2)
            {
                Console.WriteLine($"Resultado: {numero1 * 2}");
            }
        else
        {
            Console.WriteLine($"Resultado: {numero2 * 3}");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida para el segundo número.");
    }
}
else
{
    Console.WriteLine("Entrada no válida para el primer número.");
}
}