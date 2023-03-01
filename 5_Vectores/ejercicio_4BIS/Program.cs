namespace ejercicio_4BIS;
class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite números enteros y los guarde en un vector.
        // Luego recorrer todos los elementos del vector y determinar cuál es el valor
        // máximo y su posición dentro del vector.

        // TODO: 1 --> Cargar vector
        // TODO: 2 --> Recorrer vector
        // TODO: 3 --> Máximo y posición

        Console.WriteLine("Longitud:");
        int longitud;
        if (int.TryParse(Console.ReadLine(), out longitud))
        {
            int[] numeros = new int[longitud];

            cargarVector(numeros);

            Console.WriteLine($"Máximo: {maximoVector(numeros)}");

        }
        else
        {
            Console.WriteLine("Algo salió mal...");
        }

    }

    public static void cargarVector(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Número:");
            numeros[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int maximoVector(int[] numeros)
    {
        int maximo = numeros[0];
        // int posMax = 1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
                // posMax = i+1;
            }
        }

        return maximo;
    }
}
