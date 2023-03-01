namespace ejercicio_3;
class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int [] numeros = new int [10];
       
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int max = numeros[0];
        int posicion = 0; 

        for (int x = 0; x < 10; x++)
        {
            if(numeros[x] >= max)
            {
                max = numeros[x]; 
                posicion++; 
            }
        }
        Console.WriteLine($"El valor máximo es: {max} en la posición {posicion}");
    }
}
