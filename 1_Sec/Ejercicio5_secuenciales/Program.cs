namespace Ejercicio5_secuenciales;
class Program
{
    //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
    //más una comisión del 5% sobre el total facturado por cada empleado. Hacer un
    //programa para ingresar el total facturado por un empleado y que luego calcule
    //y emita por pantalla el sueldo total a cobrar por el mismo.
    static void Main(string[] args)
    {
    
        float totalFacturado, sueldoTotal;

        Console.WriteLine("Ingrese el total facturado de un empleado: ");
        totalFacturado = float.Parse(Console.ReadLine());

        sueldoTotal = 15000 + (totalFacturado*0.95F);

        Console.WriteLine($"El sueldo total del empleado es: ${sueldoTotal}");
    }
}
