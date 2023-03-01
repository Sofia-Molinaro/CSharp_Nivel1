namespace ejercicio_2;
class Program
{
    //Hacer un programa que solicite dos números y luego muestre los números
    //entre el menor y el mayor de ellos. Acordate, usando While.
    static void Main(string[] args)
    {
       
        int n1, n2, res = 0;
        Console.WriteLine("Número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Número: ");
        n2 = int.Parse(Console.ReadLine());


        while(n1 < n2-1)
        {
            Console.WriteLine(n1 + 1);
            n1++;
        }


    }
}

