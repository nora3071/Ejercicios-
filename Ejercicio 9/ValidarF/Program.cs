using System;

class Program
{
    
    static bool EsBisiesto(int anio)
    {
        return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
    }

    //  Función que valida si el mes está en el rango 1 - 12 
    static bool MesValido(int mes)
    {
        return mes >= 1 && mes <= 12;
    }

    //  Función que valida si el día es correcto 
    // Tiene en cuenta el mes, los días que corresponden a ese mes
    // y además verifica el caso especial de febrero en año bisiesto.
    static bool DiaValido(int dia, int mes, int anio)
    {
        // Si el mes no es válido, no puede validarse el día
        if (!MesValido(mes)) return false;

        // Cantidad de días por cada mes en un año normal
        int[] diasMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int diasEnMes = diasMes[mes - 1]; // días según el mes ingresado

        // Si es febrero y el año es bisiesto, febrero tiene 29 días
        if (mes == 2 && EsBisiesto(anio))
        {
            diasEnMes = 29;
        }

        // Verifica que el día esté dentro del rango permitido
        return dia >= 1 && dia <= diasEnMes;
    }

    //  Función que valida una fecha completa 
    static bool FechaValida(int dia, int mes, int anio)
    {
        return MesValido(mes) && DiaValido(dia, mes, anio);
    }

    //  Programa Principal 
    static void Main()
    {
        Console.WriteLine("=== Validación de Fecha ===");

        // Pedimos al usuario ingresar los datos
        Console.Write("Ingrese el día: ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes: ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año: ");
        int anio = int.Parse(Console.ReadLine());

        // Verificar si la fecha es válida usando las funciones
        if (FechaValida(dia, mes, anio))
        {
            Console.WriteLine($"La fecha {dia}/{mes}/{anio} es CORRECTA ");

            // También mostramos si el año es bisiesto o no
            if (EsBisiesto(anio))
                Console.WriteLine($"El año {anio} es bisiesto.");
            else
                Console.WriteLine($"El año {anio} no es bisiesto.");
        }
        else
        {
            // Caso en que la fecha no es válida
            Console.WriteLine($"La fecha {dia}/{mes}/{anio} es INCORRECTA ");
        }
    }
}

