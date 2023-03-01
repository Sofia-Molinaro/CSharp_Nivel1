namespace ejercicio_4;
class Program
{
    //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
    //Luego recorrer ese vector para calcular el promedio. 
    //Mostrar por pantalla los valores que son mayores al promedio.
    static void Main(string[] args)
    {
        int [] numeros = new int [10];
        
        int acu = 0, mayor = 0;
        float promedio = 0; 
        
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un número, por favor: ");
            numeros[i] = int.Parse(Console.ReadLine());
            acu = numeros[i] + acu;  
        }
       
        promedio = acu / 10;

        Console.WriteLine($"El promedio de los números es: {promedio}");

        for(int x = 0; x < 10; x++)
        {    
            if (promedio < numeros[x])
            {
               mayor = numeros[x];
               Console.WriteLine($"Los valores que son mayores al promedio son: {mayor}");
            }
        }
    }
}