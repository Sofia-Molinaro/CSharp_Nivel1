namespace ejercicio_3;
class Program
{
    //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
    //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
    static void Main(string[] args)
    {
        int num, acumPrimos = 0, contadorPrimos= 0;
        float promedioPrimos = 0;

        Console.WriteLine("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());
        
        while(num != 0)      
        {
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            
            if(primo(num))
            {
                contadorPrimos++;
                acumPrimos = acumPrimos + num;
            }
        }
        promedioPrimos = acumPrimos / contadorPrimos;
        Console.WriteLine($"El promedio de los números primos ingresados es: {promedioPrimos}");     
    }

    static bool primo(int n)
    {
        int  esDivisible = 0;
        for(int i = 1; i <= n; i++)
        { 
            if ((n % i) == 0)
            {
                esDivisible++;
            }
                
            if (esDivisible == 2)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
    }

    static bool primo(int n)
    {
        int  esDivisible = 0;
        for(int i = 1; i <= n; i++)
        { 
            if ((n % i) == 0)
            {
                esDivisible++;
            }
                
            if (esDivisible == 2)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
    }
}