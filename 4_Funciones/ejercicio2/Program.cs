namespace ejercicio2;
class Program
{
    //Hacer una función llamada “mayor” que reciba dos números enteros y
    //devuelva el mayor de ellos o cero si son iguales.
    static void Main(string[] args)
    {
        int n1, n2;
        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"El mayor de los números es: {mayor(n1, n2)}");

    }
    public static int mayor(int num1, int num2)
    {
        int mayor;
        if (num1 > num2)
        {
            mayor = num1;
        }
        else if(num1 == num2)
        {
           mayor = 0;
           Console.WriteLine("Son iguales.");
        }
        else
        {
           mayor = num2; 
        }
        return mayor;
    }
}
