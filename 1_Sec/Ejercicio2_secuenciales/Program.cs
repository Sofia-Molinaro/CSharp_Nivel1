namespace Ejercicio2_secuenciales;
class Program
{
    //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
    static void Main(string[] args)
    {
        int num, res;
        Console.WriteLine("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());
        
        res = num * num * num;

        Console.WriteLine($"{num} elevado al cubo es {res}");
    }
}
