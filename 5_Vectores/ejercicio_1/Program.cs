namespace ejercicio_1;
class Program
{
    //Hacer un programa que solicite la edad de un grupo de personas. El programa
    //deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
    //mostrar por pantalla cuántas personas mayores se registraron.
    static void Main(string[] args)
    {
        int edad, cont = 0;
        do
        {
            Console.WriteLine("Edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                cont ++;
            }
        }
        while(edad >= 18);
       
        Console.WriteLine($"Hay {cont} personas mayores a 18 años.");
    }
}
