// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Variable global para los caracteres especiales permitidos
    static string caracteresEspeciales = "!@#$%^&*";

    static void Main()
    {
        Console.Write("Ingrese una contraseña: ");
        string password = Console.ReadLine();

        // Validación principal
        bool valida = EsContraseñaValida(password);

        if (valida)
            Console.WriteLine("\n✅ Contraseña segura.");
        else
            Console.WriteLine("\n❌ Contraseña NO cumple con los requisitos.");

        Console.ReadKey();
    }

    // ====== FUNCIÓN PRINCIPAL ======
    static bool EsContraseñaValida(string pass)
    {
        bool longitudOK   = pass.Length >= 8;
        bool mayusOK      = ContieneMayuscula(pass);
        bool minusOK      = ContieneMinuscula(pass);
        bool numeroOK     = ContieneNumero(pass);
        bool especialOK   = ContieneEspecial(pass);

        // Llamada a procedimientos que muestran mensajes
        VerificarLongitud(pass);
        VerificarMayuscula(pass);
        VerificarMinuscula(pass);
        VerificarNumero(pass);
        VerificarEspecial(pass);

        // Devuelve true solo si todos son verdaderos
        return longitudOK && mayusOK && minusOK && numeroOK && especialOK;
    }

    // ====== FUNCIONES AUXILIARES (lógicas) ======
    static bool ContieneMayuscula(string pass)
    {
        foreach (char c in pass)
            if (char.IsUpper(c)) return true;
        return false;
    }

    static bool ContieneMinuscula(string pass)
    {
        foreach (char c in pass)
            if (char.IsLower(c)) return true;
        return false;
    }

    static bool ContieneNumero(string pass)
    {
        foreach (char c in pass)
            if (char.IsDigit(c)) return true;
        return false;
    }

    static bool ContieneEspecial(string pass)
    {
        foreach (char c in pass)
            if (caracteresEspeciales.Contains(c)) return true;
        return false;
    }

    // ====== PROCEDIMIENTOS (solo muestran mensajes) ======
    static void VerificarLongitud(string pass)
    {
        if (pass.Length >= 8)
            Console.WriteLine("✔ Tiene al menos 8 caracteres.");
        else
            Console.WriteLine("❌ Debe tener mínimo 8 caracteres.");
    }

    static void VerificarMayuscula(string pass)
    {
        if (ContieneMayuscula(pass))
            Console.WriteLine("✔ Tiene al menos una mayúscula.");
        else
            Console.WriteLine("❌ Debe contener al menos una mayúscula.");
    }

    static void VerificarMinuscula(string pass)
    {
        if (ContieneMinuscula(pass))
            Console.WriteLine("✔ Tiene al menos una minúscula.");
        else
            Console.WriteLine("❌ Debe contener al menos una minúscula.");
    }

    static void VerificarNumero(string pass)
    {
        if (ContieneNumero(pass))
            Console.WriteLine("✔ Tiene al menos un número.");
        else
            Console.WriteLine("❌ Debe contener al menos un número.");
    }

    static void VerificarEspecial(string pass)
    {
        if (ContieneEspecial(pass))
            Console.WriteLine("✔ Tiene al menos un carácter especial.");
        else
            Console.WriteLine("❌ Debe contener al menos un carácter especial (!@#$%^&*).");
    }
}


