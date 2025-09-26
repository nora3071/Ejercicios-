// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    // Variable global
    static int numeroOriginal;

    // Función que invierte el número
    static int InvertirNumero(int n)
    {
        int invertido = 0;
        while (n > 0)
        {
            int digito = n % 10;           // obtener el último dígito
            invertido = invertido * 10 + digito; // agregarlo al invertido
            n = n / 10;                   // eliminar el último dígito
        }
        return invertido;
    }

    // Función que determina si es capicúa
    static bool EsCapicua()
    {
        int invertido = InvertirNumero(numeroOriginal);
        return numeroOriginal == invertido;
    }

    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        numeroOriginal = int.Parse(Console.ReadLine());

        if (numeroOriginal < 0)
        {
            Console.WriteLine("Debe ingresar un número positivo.");
        }
        else
        {
            if (EsCapicua())
                Console.WriteLine($"{numeroOriginal} es capicúa.");
            else
                Console.WriteLine($"{numeroOriginal} no es capicúa.");
        }
    }
}
