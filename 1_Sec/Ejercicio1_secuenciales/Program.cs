namespace Ejercicio1_secuenciales;
class Program
{
    //Hacer un programa que sume 2 números.
    static void Main(string[] args)
    {
        int n1, n2, res; 
        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        n2 = int.Parse(Console.ReadLine());

        res = n1 + n2; 

        Console.WriteLine($"El resultado de la suma de {n1} y {n2} es {res}");
    }
}
