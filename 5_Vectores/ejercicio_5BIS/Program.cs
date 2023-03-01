namespace ejercicio_5BIS;
class Program
{
    //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
    //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
    //Mostrar el resultado en pantalla. Ejemplo:
    
    //CADENA FUENTE: “La mar estaba serena"
    //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
    // CADENA RESULTADO: “Li mir estibi sereni"
    static void Main(string[] args)
    {
        string frase; 
        char letraActual, letraNueva;

        Console.WriteLine("Ingrese la frase: ");
        frase = Console.ReadLine();
        
        Console.WriteLine("Ingrese una letra que deseé reemplazar en la frase: ");
        letraActual = char.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese una letra para reemplazar en la frase: ");
        letraNueva = char.Parse(Console.ReadLine());

      
        frase = frase.Replace(letraActual, letraNueva);

        Console.WriteLine($"La cadena nueva es: {frase}");
    }
}
