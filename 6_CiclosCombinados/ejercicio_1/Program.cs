namespace ejercicio_1;
{
    //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
    static void Main(string[] args)
    {
        int n1, n2, cantidad, precio, res, resultado;

        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");    
        n2 = int.Parse(Console.ReadLine());
        
        res = producto(n1, n2);
        Console.WriteLine("El producto es: " + res);

        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el precio del producto: ");
        precio = int.Parse(Console.ReadLine());
        
        resultado = producto(cantidad, precio);
        Console.WriteLine("El monto total a pagar es: " + resultado);
    }

    static int producto(int x, int y)
    {
        int multiplicacion;
        multiplicacion = x * y;
        return multiplicacion;
    }
}