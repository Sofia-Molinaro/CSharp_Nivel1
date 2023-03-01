namespace ejercicio5;
class Program
{
    //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles y cuántos son mayores a 100.

    static void Main(string[] args)
    {
        int num, contMayores;

        contMayores = 0;

        for(int i = 0; i<4; i++)
        {
            Console.WriteLine("Ingrese un número, por favor: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

             if (num > 100){
                Console.WriteLine($"{num} es mayor a 100.");
                Console.WriteLine();
                contMayores++;
            }
        }
        Console.WriteLine($"Los números ingresados mayores a 100 son: {contMayores}"); 
    }
}