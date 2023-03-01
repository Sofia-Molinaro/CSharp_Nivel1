namespace ejercicio1;
class Program
{
    //Hacer un programa que solicite el ingreso de dos números y luego calcular:
    //*La resta si el primero es mayor que el segundo.
    //*La suma si son iguales.
    //*El producto si el primero es menor.
    //*Se deberá emitir un cartel por pantalla con el resultado correspondiente.
    static void Main(string[] args)
    {
        int num1, num2, resultado;

        Console.WriteLine("Ingrese un número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro número: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            resultado = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {resultado}");
        }
        else if(num1 == num2)
        {
            resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
        else(num1 < num2)
        {
            resultado = num1 * num2;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }
    }
}