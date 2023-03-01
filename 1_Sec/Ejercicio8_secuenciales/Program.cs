namespace Ejercicio8_secuenciales;
class Program
{
    //Una importante cadena de delivery cuenta con una promoción por tiempo
    //limitado en la que otorga un 15% de descuento sobre el total del valor de la
    //compra realizada. Hacer un programa para solicitar el monto total y el mismo
    //calcule y emita por pantalla el total a cobrar con el descuento aplicado.
    static void Main(string[] args)
    {
        float montoTotal;
        Console.WriteLine("Ingrese el monto total de la compra: ");
        montoTotal = float.Parse(Console.ReadLine());


        descuento = montoTotal * 0.85F;


        Console.WriteLine($"El total con el descuento es: {montoTotal}");
    }
}
