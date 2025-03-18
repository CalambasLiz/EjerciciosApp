

// SolicitarYProcesarNumero(); 
// SolicitarYProcesarDosNumeros();
// RaizOalCuadrado();
// PerimetroCirculo();
// DiaDeLaSemana();
// SalarioAnual();
// Buscador();
// SumaDePares();
// DiferenciaDeFracciones();
PromedioDeCuatro();
ElMasPequeñoDe5();

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
static void SalarioAnual()
{
    Console.Write("Ingrese su salario anual: ");
    if (double.TryParse(Console.ReadLine(), out double salario))
    {
        if (salario > 12000)
        {
            double impuesto = (salario - 12000) * 0.15;
            Console.WriteLine($"Resultado: {impuesto}");
        }
        else
        {
            Console.WriteLine("Resultado: No debe impuestos.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}

static void Buscador()
{
    Console.Write("Ingrese el primer número: ");
    if (double.TryParse(Console.ReadLine(), out double numero1))
    {
        Console.Write("Ingrese el segundo número: ");
        if (double.TryParse(Console.ReadLine(), out double numero2))
        {
            double residuo = numero1 % numero2;
            Console.WriteLine($"Resultado: {residuo}");
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
static void SumaDePares()
{
    int suma = 0;
    for (int i = 2; i <= 50; i += 2)
    {
        suma += i;
    }
    Console.WriteLine($"Resultado: {suma}");
}

static void DiferenciaDeFracciones()
{
    Console.Write("Ingrese la primera fracción (a/b): ");
    string[] fraccion1 = Console.ReadLine().Split('/');
    Console.Write("Ingrese la segunda fracción (c/d): ");
    string[] fraccion2 = Console.ReadLine().Split('/');

    if (fraccion1.Length == 2 && fraccion2.Length == 2 &&
        int.TryParse(fraccion1[0], out int a) && int.TryParse(fraccion1[1], out int b) &&
        int.TryParse(fraccion2[0], out int c) && int.TryParse(fraccion2[1], out int d))
    {
        int numerador = a * d - b * c;
        int denominador = b * d;
        Console.WriteLine($"Resultado: {numerador}/{denominador}");
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}
static void StringLength()
{
    Console.Write("Ingrese una palabra: ");
    string palabra = Console.ReadLine();
    Console.WriteLine($"Resultado: {palabra.Length}");
}

static void PromedioDeCuatro()
{
    Console.Write("Ingrese cuatro números separados por espacios: ");
    string[] numeros = Console.ReadLine().Split(' ');

    if (numeros.Length == 4 &&
        double.TryParse(numeros[0], out double num1) &&
        double.TryParse(numeros[1], out double num2) &&
        double.TryParse(numeros[2], out double num3) &&
        double.TryParse(numeros[3], out double num4))
    {
        double promedio = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine($"Resultado: {promedio}");
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}

static void ElMasPequeñoDe5()
{
    Console.Write("Ingrese cinco números separados por espacios: ");
    string[] numeros = Console.ReadLine().Split(' ');

    if (numeros.Length == 5 &&
        double.TryParse(numeros[0], out double num1) &&
        double.TryParse(numeros[1], out double num2) &&
        double.TryParse(numeros[2], out double num3) &&
        double.TryParse(numeros[3], out double num4) &&
        double.TryParse(numeros[4], out double num5))
    {
        double menor = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));
        Console.WriteLine($"Resultado: {menor}");
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}