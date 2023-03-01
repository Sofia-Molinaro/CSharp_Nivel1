namespace Ejercicio9_secuenciales;
class Program
{
    //Una universidad desea conocer los porcentajes de mujeres y hombres en las
    //carreras de ciencias exactas. Se solicita un programa para cargar la cantidad de
    //mujeres y la cantidad de hombres y que el mismo calcule y emita por pantalla
    //los porcentajes correspondientes.
    static void Main(string[] args)
    {
        int hombres, mujeres, porcentajeHombres, porcentajeMujeres, total;


        Console.WriteLine("Ingrese la cantidad de hombres: ");
        hombres = int.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese la cantidad de mujeres: ");
        mujeres = int.Parse(Console.ReadLine());


        total = hombres + mujeres;


        porcentajeHombres = (hombres * 100)/ total;


        porcentajeMujeres = (mujeres * 100)/ total;


        Console.WriteLine($"El {porcentajeHombres}% son hombres");
        Console.WriteLine($"El {porcentajeMujeres}% son mujeres");
    }
}
