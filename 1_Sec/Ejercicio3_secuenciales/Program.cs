namespace Ejercicio3_secuenciales;
class Program
{
    //Hacer un programa que permita ingresar el año actual y el año de la fecha de
    //nacimiento de una persona y luego calcule y emita por pantalla su edad.
    //Nota: no hay que tener en cuenta si la persona cumplió años o no,
    //simplemente calcular.
    static void Main(string[] args)
    {
        int anio, anioNacimiento, edad;

        Console.WriteLine("Ingrese el año actual: ");
        anio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el año de la fecha de nacimiento de una persona: ");
        anioNacimiento = int.Parse(Console.ReadLine());

        edad = anio - anioNacimiento;

        Console.WriteLine($"La edad de la persona es: {edad}");
    }
}
