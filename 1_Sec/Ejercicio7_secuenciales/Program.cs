namespace Ejercicio7_secuenciales;
class Program
{
    //Hacer un programa para ingresar por teclado los metros cuadrados totales de
    //un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
    //pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
    //metros cuadrados descubiertos.
    static void Main(string[] args)
    {
        float metrosTotales, metrosCubiertos, porcentajeCubierto;


        Console.WriteLine("Ingrese los metros cuadrados totales de un predio: ");
        metrosTotales = float.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese los metros cuadrados cubiertos: ");
        metrosCubiertos = float.Parse(Console.ReadLine());


        porcentajeCubierto = (metrosCubiertos * 100F) / metrosTotales;


        Console.WriteLine($"El porcentaje de metros cuadrado cubiertos es: {porcentajeCubierto}%");
    }
}
