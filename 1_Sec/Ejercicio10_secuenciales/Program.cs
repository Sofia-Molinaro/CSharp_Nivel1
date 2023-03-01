namespace Ejercicio10_secuenciales;
class Program
{
    //Hacer un programa que permita ingresar por teclado dos números y que luego
    //muestre por pantalla la suma, la resta, la multiplicación y la división de dichos
    //números. Se deben mostrar cuatro resultados en pantalla. Los números deben
    //ser solicitados una única vez.
    static void Main(string[] args)
    {
        float n1, n2, suma, resta, multiplicacion;


        Console.WriteLine("Ingrese un número: ");
        n1 = float.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese otro número (no puede ser cero): ");
        n2 = float.Parse(Console.ReadLine());


        suma = n1 + n2;
        Console.WriteLine($"La suma de los números es: {suma}");


        resta = n1 - n2;
        Console.WriteLine($"la resta de los números es: {resta}");


        multiplicacion = n1 * n2;
        Console.WriteLine($"La multiplicación de los números es: {multiplicacion}");
       
        division(n1, n2);
    }
    public static float division(float num1, float num2)
    {
        float res = 0;
        if (num2 != 0)
        {
            res = num1/num2;
            Console.WriteLine($"La división de los números es: {res}");
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero");
        }
        return res;
    }
}

