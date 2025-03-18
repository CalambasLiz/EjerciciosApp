﻿

// SolicitarYProcesarNumero(); 
// SolicitarYProcesarDosNumeros();
// RaizOalCuadrado();
// PerimetroCirculo();
DiaDeLaSemana();

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
static void RaizOalCuadrado()
{
    Console.Write("Ingrese un número: ");
    if (double.TryParse(Console.ReadLine(), out double numero))
    {
        if (numero > 0)
        {
            Console.WriteLine($"Resultado: {Math.Sqrt(numero)}");
        }
        else
        {
            Console.WriteLine($"Resultado: {numero * numero}");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}
static void PerimetroCirculo()
{
    Console.Write("Ingrese el radio de un círculo: ");
    if (double.TryParse(Console.ReadLine(), out double radio))
    {
        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine($"Resultado: {perimetro:F2}");
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}

static void DiaDeLaSemana()
{
    Console.Write("Ingrese un número entre 1 y 7: ");
    if (int.TryParse(Console.ReadLine(), out int dia))
    {
        switch (dia)
        {
            case 1: Console.WriteLine("Resultado: Lunes"); break;
            case 2: Console.WriteLine("Resultado: Martes"); break;
            case 3: Console.WriteLine("Resultado: Miércoles"); break;
            case 4: Console.WriteLine("Resultado: Jueves"); break;
            case 5: Console.WriteLine("Resultado: Viernes"); break;
            default: Console.WriteLine("Resultado: Número fuera del rango laboral."); break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}