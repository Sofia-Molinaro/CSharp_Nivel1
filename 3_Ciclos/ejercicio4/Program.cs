namespace ejercicio4;
class Program
{
    //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

    static void Main(string[] args)
    {
        float n1, n2, n3;

        Console.WriteLine("Ingrese el primer número, por favor: ");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número, por favor: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número, por favor: ");
        n3 = float.Parse(Console.ReadLine());

        if ((n1 + n2) > (n2 * n3)){
            Console.WriteLine("La suma de los dos primeros números es mayor al producto del segundo con el tercero.");
        }
    }
}
