namespace ejercicio_6;
class Program
{
    //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
    static void Main(string[] args)
    {
        int num, contNros = 0, nroGrupo = 0;
        do
        {
            nroGrupo++;
            Console.WriteLine("Ingrese un número, por favor: ");
            num = int.Parse(Console.ReadLine());
            while(num > 0)
            {
                num = int.Parse(Console.ReadLine());
                contNros++;
            }
            
            Console.WriteLine($"La lista N°{nroGrupo} tiene {contNros} números.");
        }while(num >= 0);
    }
}