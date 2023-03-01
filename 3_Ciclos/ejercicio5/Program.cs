namespace ejercicio5;
class Program
{
    //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.

    static void Main(string[] args)
    {
        int n1, n2, n3, n4;

        Console.WriteLine("Ingrese el primer número, por favor: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número, por favor: ");
        n2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el tercer número, por favor: ");
        n3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el cuarto número, por favor: ");
        n4 = int.Parse(Console.ReadLine());

        if (n1>n2 && n2>n3 && n3>n4)
        {
            Console.WriteLine("Los números se encuentran ordenados en forma decreciente.");
        }
        else
        {
            Console.WriteLine("Los números NO se encuentran ordenados en forma decreciente.");
        }
    }
}
