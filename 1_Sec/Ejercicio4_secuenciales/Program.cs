namespace Ejercicio4_secuenciales;
class Program
{
    //Hacer un programa que permita ingresar los kilómetros existentes entre dos
    //ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla
    //el tiempo aproximado que demandará llegar de un punto a otro teniendo en
    //cuenta los datos ingresados.
    static void Main(string[] args)
    {
        float tiempo, velocidad, distancia; 

        Console.WriteLine("Ingrese la distancia que hay entre dos ciudades: ");
        distancia = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la velocidad promedio de un vehículo: ");
        velocidad = float.Parse(Console.ReadLine());

        tiempo = distancia/velocidad;

        Console.WriteLine($"El tiempo aproximado que demandará llegar de un punto a otro es {tiempo} horas.");
    }
}
