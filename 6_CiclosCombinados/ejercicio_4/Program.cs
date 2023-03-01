namespace ejercicio_4;
class Program
{
    //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
    //Que analice el número y escriba variable recibida por referencia con:
    //a. 1 si el número es positivo.
    //b. -1 si el número es negativo.
    //c. 0 si el número es cero.
    static void Main(string[] args)
    {
        int num = 0;
        positivoNegativoCero(ref num);
        if(num == 1)
        {
            Console.WriteLine("El número es positivo");
        }

        else if(num == -1)
        {
            Console.WriteLine("El número es negativo");
        }

        else if(num == 0)
        {
            Console.WriteLine("El número es cero");
        }
        else
        {
            Console.WriteLine("No se ingresó ninguna opción correcta.");
        }
    }

    static void positivoNegativoCero(ref int n)
    {
        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
    }

    static void positivoNegativoCero(ref int n)
    {
        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
    }
}