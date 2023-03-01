namespace ejercicio_3BIS;
class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite números enteros y los guarde en un vector.
        // Luego recorrer el vector y determinar e informar cuál es la suma de los valores
        // del mismo.

        Console.WriteLine("Longitud del vector:");
        int longitud = int.Parse(Console.ReadLine());

        int[] numeros = new int[longitud];
        
        // Carga del vector 😁
        cargarVector(numeros);

        Console.WriteLine($"Suma de los elementos del vector: {sumar(numeros)}");

        // forEach

        // foreach (int numero in numeros)
        // {
        //     res += numero; 
        // }

        // Console.WriteLine($"Suma de los elementos del vector: {res}");

    }

    public static void cargarVector(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Número:");

            numeros[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int sumar(int[] numeros)
    {
        int suma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        return suma;    
    }
}
