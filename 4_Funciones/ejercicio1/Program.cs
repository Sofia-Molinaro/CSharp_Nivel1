namespace ejercicio1;
class Program
{
    //Hacer una función llamada “producto” que reciba dos números enteros y que
    //devuelva el producto de ambos. Luego hacer un programa que pida el precio
    //de un artículo y la cantidad vendida y muestre por pantalla el monto total a
    //pagar. Usar la función.
    static void Main(string[] args)
    {
        int n1, n2;
        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese ptro número: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"El producto de los números ingresados es: {producto(n1, n2)}");

    }
    public static int producto(int num1, int num2)
    {
        int res;
        res = num1 * num2;
        return res;
    }
}
