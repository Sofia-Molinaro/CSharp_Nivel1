namespace Ejercicio6_secuenciales;
class Program
{
    //Este programa calcula el promedio de tres notas. 
    static void Main(string[] args)
    {
        float n1, n2, n3, resultado; 

        Console.WriteLine("Ingrese la nota del primer parcial, por favor: ");
        n1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la nota del segundo parcial, por favor: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la nota del tercer parcial, por favor: ");
        n3 = float.Parse(Console.ReadLine());

        resultado = (n1 + n2 + n3) / 3; 

        // Console.WriteLine("El promedio de las notas ingresadas es: " + resultado);
        // Console.WriteLine("El promedio de las notas ingresadas es: {0}",resultado );
        Console.WriteLine($"El promedio de las notas ingresadas es: {resultado.ToString("0.00")}" );
    }
}

