namespace ejercicio_2BIS;
class Program
{
    // Hacer un programa para ingresar 10 números. 
    //El mismo debe analizar y mostrar por pantalla cuántos de esos 
    //números son primos.
    static void Main(string[] args)
    {
        int num, contPrimo = 0; 
        bool banPrimo = true; 
        
        for(int i = 0; i < 10; i++)
        {
           Console.WriteLine("Ingrese un número");
           num = int.Parse(Console.ReadLine());
           
           for(int x = 1; x <= num; i++)
           {
            if((num % x) == 0)
            {
                if(((num % x) == 0) > 2)
                {
                    banPrimo = false;
                }
            }
            else
            {
                banPrimo = true;
                contPrimo ++;
            }
           }
        }
        Console.WriteLine($"Se ingresaron{contPrimo}");
    }
}