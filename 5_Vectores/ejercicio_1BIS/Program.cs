namespace ejercicio_1BIS;
class Program
{
    //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
    static void Main(string[] args)
    { 
        int num, max = 0, min = 0;
        bool esPar = false, esImpar = false; 
        
        for(int i = 0; i < 20; i++)
        { 
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            
            if((num % 2) == 0)
            {
                if(esPar == false) // inicializo(es el primer nro. par)
                {
                    max = num; 
                    esPar = true;
                }
                else if(num > max)
                {
                    max = num;              
                }
            }
            else
            {
                if(esImpar == false)
                {
                    min = num;   
                    esImpar = true;   
                }
                else if(num < min)
                    {
                        min = num;            
                    }
            }
        }    
        Console.WriteLine($"El máximo de los números pares ingresados es: {max}");
        Console.WriteLine($"El mínimo de los números impares ingresados es: {min}");         
    }
}