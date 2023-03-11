static void saludar(string nomsal)

{
    Console.WriteLine($"un gran saludo  a {nomsal}");
}

// la diferencia entre una y otra es que la primera devulve valor y la otra no, cuando un bloque de codigo no devulbe valor se llama metodo de lo contrario es una funcion con respecgto al static void e int 
static int calculo_año_nacimiento(int edad)
{

    int añon = 2023 - edad;
    return añon;
}


//    string nombre;
//    int edad;
//    int año_nac;
//char letra = 'a';
//string palabra = letra; 



static void marque(string palabra)




{

    int longitud = palabra.Length;

    for (int c= longitud; c >0; c--)


    {
        Console.SetCursorPosition(5,10);
        Console.Write(palabra [c] );
        Thread.Sleep(100);



    }


    //Console.WriteLine(palabra[2]);
}

string palabra;
palabra = "maria";
marque(palabra);
bool esPalindromo = palindromo("anA".ToUpper());


if (esPalindromo)
{

    Console.WriteLine("es Palindromo");
}else
{
    Console.WriteLine("nel");
}

static bool palindromo(string palabra)
{

    int longitud = palabra.Length;

    string pal = "";
    for (int c= longitud -1; c >=0; c--)
    {
        pal=pal + palabra[c];
    }
    if (palabra.Equals(pal))
    {
        return true;

    }
    return false;
}












//    Console.Write("como te llamas");
//    nombre = Console.ReadLine();
//    saludar(nombre);



//Console.WriteLine($"hola, gusto de saludarte{nombre}");
//Console.WriteLine("cuantos años tienes");
//edad = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine($"bonita edad:{edad} \nnaciste en {calculo_año_nacimiento(edad)}");
