namespace ejercicio1;
class Program
{
    //// Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

    static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        if(num > 10){
            Console.WriteLine("Es mayor a 10");
        }else{
            Console.WriteLine("No es mayor a 10");
        }
    }
}