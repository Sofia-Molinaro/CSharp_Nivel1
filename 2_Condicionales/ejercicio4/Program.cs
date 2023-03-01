namespace ejercicio4;
class Program
{
    //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

    static void Main(string[] args)
    {
        int num, menor; 

        menor = 0;

        Console.WriteLine("A continuación ingrese cuatro números enteros, asegúrese que sean distintos");

        for(int i = 0; i<4; i++)
        {
            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());
            
            if(num < menor)
            {
            menor = num;
            }

            Console.WriteLine($"El menor de los números es:{menor}");
        }  
        
    }
}