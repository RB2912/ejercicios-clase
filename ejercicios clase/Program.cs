// See https://aka.ms/new-console-template for more information

static void saludar(string nomsal)
{
    Console.WriteLine($"un gran saludo a {nomsal}");
}

static int calculo_año_nacimiento(int edad)
{
    int añon = 2023 - edad;
    return añon;
}


static void palindromo(string palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int c = longitud - 1 >= 0; c--)
    {
        pal = pal + palabra[c].ToString().Tollpper();
    }
    if (palabra.Tollpper().Equals(pal))
    {
        return true;
    }
    return false;

    string palabra;
    palabra = "maria";
    marque = (palabra);
    bool espalindromo = palindromo("anA");

    if (espalindromo)
    {
        Console.WriteLine("es palindromo");
    }
    else
    {
        Console.WriteLine("nel");
    }
}


//string nombre;
//int edad;


//Console.Write("Como te llamas?");
//nombre = Console.ReadLine();
//saludar("nombre");

//Console.WriteLine($"Hola,gusto de saludarle{nombre}");
//Console.WriteLine("Cuantos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Bonita edad:{edad}/n naciste en {calculo_año_nacimiento(edad)}");
