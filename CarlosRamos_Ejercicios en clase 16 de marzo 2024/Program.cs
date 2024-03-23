
//Ejercicios Carlos Ramos


//Ejercicio 1. Suma de elementos pares en un arreglo:


static void Suma(string[] args)
{
    int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int sumadenumPares = Suma_de_elementos_Pares(arreglo);
    Console.WriteLine("La suma de los elementos pares es: " + sumadenumPares);
}

static int Suma_de_elementos_Pares(int[] numeros)
{
    int suma = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            suma += numeros[i];
        }
    }
    return suma;
}


//Ejercicio 2. Invertir el orden de un arreglo:



static void invert(string[] args)
{
    int[] originalArray = { 1, 2, 3, 4, 5 };
    int[] reversedArray = ReverseArray(originalArray);

    Console.WriteLine("Original Array:");
    PrintArray(originalArray);

    Console.WriteLine("\nReversed Array:");
    PrintArray(reversedArray);
}

static int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];
    Array.Copy(array, reversedArray, array.Length);
    Array.Reverse(reversedArray);
    return reversedArray;
}

static void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
}

//ejercicio 3. Encontrar el valor máximo en un arreglo:


{
    int[] numeros2 = { 10, 5, 12, 7, 3, 15 };
    int valorMaximo = EncontrarMaximo(numeros2);


    static int EncontrarMaximo(int[] numeros)
    {
        int maximo = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {

            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
            }
        }

        return maximo;
    }
   

    Console.WriteLine("El valor máximo del arreglo es: " + valorMaximo);


}

//Ejercicio 4. Buscar un elemento en un arreglo:

static int BuscarValor(int[] numeros, int valorABuscar)
{

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == valorABuscar)
        {
            return i;
        }
    }

    return -1;
}

int[] numeros = { 10, 5, 12, 7, 3, 15 };
int valorABuscar = 12;
int posicion = BuscarValor(numeros, valorABuscar);

if (posicion == -1)
{
    Console.WriteLine("El valor no se encuentra en el arreglo");
}
else
{
    Console.WriteLine("El valor se encuentra en la posición " + posicion);
}


//Ejercicio 5. Ordenar un arreglo de forma ascendente


static void Main(string[] args)
    {
        int[] array = { 5, 2, 8, 1, 3 };
        Console.WriteLine("Arreglo original:");
        PrintArray(array);

        int[] sortedArray = SortArray(array);
        Console.WriteLine("\nArreglo ordenado:");
        PrintArray(sortedArray);
    }

    static int[] SortArray(int[] array)
    {
        // Clonamos el arreglo original para evitar modificarlo directamente
        int[] sortedArray = (int[])array.Clone();

        // Utilizamos Array.Sort para ordenar el arreglo de forma ascendente
        Array.Sort(sortedArray);

        return sortedArray;
    }

    static void PrintArray2(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
}


//Utilización de métodos de Array

//Ejercicio 1:

{
    static void lista(string[] args)
    {
        Console.WriteLine("Ingrese una lista de nombres separados por espacios:");
        string input = Console.ReadLine();

        // Dividimos la entrada en nombres individuales
        string[] nombres = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Ordenamos los nombres alfabéticamente
        Array.Sort(nombres);

        // Mostramos la lista ordenada
        Console.WriteLine("\nLista de nombres ordenados alfabéticamente:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}



//Ejercicio 2:


    static void lista2(string[] args)
    {
        Console.WriteLine("Ingrese una lista de números enteros separados por espacios:");
        string input = Console.ReadLine();

        // Dividimos la entrada en números individuales
        string[] numerosStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Convertimos los números de cadena a enteros
        int[] numeros = Array.ConvertAll(numerosStr, int.Parse);

        // Encontramos el valor máximo y mínimo utilizando Array.Max() y Array.Min()
        int maximo = numeros.Max();
        int minimo = numeros.Min();

        // Mostramos los resultados al usuario
        Console.WriteLine($"El valor máximo de la lista es: {maximo}");
        Console.WriteLine($"El valor mínimo de la lista es: {minimo}");
}

//Ejercicio 3

    static void paises(string[] args)
    {
        // Declaración del arreglo de nombres de países
        string[] paises = { "Argentina", "Brasil", "Chile", "Colombia", "Ecuador", "Perú", "Uruguay", "Venezuela" };

        // Solicitar al usuario ingresar un nombre de país
        Console.WriteLine("Ingrese un nombre de país:");
        string paisBuscado = Console.ReadLine();

        // Utilizar Array.IndexOf para buscar si el país se encuentra en el arreglo
        int indice = Array.IndexOf(paises, paisBuscado);

        // Mostrar mensaje indicando si el país fue encontrado o no
        if (indice != -1)
        {
            Console.WriteLine($"El país {paisBuscado} fue encontrado en el índice {indice} del arreglo.");
        }
        else
        {
            Console.WriteLine($"El país {paisBuscado} no fue encontrado en el arreglo.");
        }
}


//Ejercicio 4


{
    static void orden(string[] args)
    {
        // Declaración del arreglo de enteros
        int[] arreglo = { 1, 2, 3, 4, 5 };

        // Mostrar el arreglo original
        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(arreglo);

        // Invertir el arreglo utilizando Array.Reverse()
        Array.Reverse(arreglo);

        // Mostrar el arreglo invertido
        Console.WriteLine("\nArreglo invertido:");
        ImprimirArreglo(arreglo);
    }

    // Método para imprimir un arreglo de enteros
    static void ImprimirArreglo(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


//Ejercicio 5


    static void calificaciones(string[] args)
    {
        Console.WriteLine("Ingrese una lista de calificaciones separadas por espacios:");
        string input = Console.ReadLine();

        // Dividir la entrada en calificaciones individuales
        string[] calificacionesStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Convertir las calificaciones de cadena a enteros
        int[] calificaciones = Array.ConvertAll(calificacionesStr, int.Parse);

        // Verificar si hay calificaciones sobresalientes utilizando Array.Exists()
        bool haySobresalientes = Array.Exists(calificaciones, calificacion => calificacion >= 90);

        // Mostrar un mensaje indicando si hay calificaciones sobresalientes o no
        if (haySobresalientes)
        {
            Console.WriteLine("¡Hay calificaciones sobresalientes en la lista!");
        }
        else
        {
            Console.WriteLine("No hay calificaciones sobresalientes en la lista.");
        }
    }




