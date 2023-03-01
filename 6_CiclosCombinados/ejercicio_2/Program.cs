namespace ejercicio_2;
class Program
{
    //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
    static void Main(string[] args)
    {
        int num, esPar = 0;
        for(int i = 0; i<20; i++)
        {
            Console.WriteLine("Ingrese un número entero: ");
            num = int.Parse(Console.ReadLine());
            
            if (par(num) == 1) 
            {
                esPar++;
            }
        }
        Console.WriteLine($"Los pares ingresados son: {esPar}");
    }
    
    static int par(int n)
    {
        if ((n % 2 ) == 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}