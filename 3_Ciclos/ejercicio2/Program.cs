namespace ejercicio2;
class Program
{
    /*Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
-Si la venta es de más de 500 litros, el descuento es del 25%.
-Si vende entre 301 y 500 litros, el descuento es del 15%.
-Si vende entre 101 y 300 litros, el descuento es del 10%.
-Si vende menos de 100 litros, no hay descuento.
Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.*/
    static void Main(string[] args)
    {
        float importe_total, litros, descuento;
        
        Console.WriteLine("Ingrese el importe total de la venta, por favor: ");
        importe_total = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de litros vendidos, por favor: ");
        litros = float.Parse(Console.ReadLine());

        if (litros > 500)
        {
            descuento = importe_total - (importe_total * 0.75F);
            Console.WriteLine($"El importe a pagar con el descuento del 25% es: ${descuento}");
        }
        else if (litros >= 301)
        {
            descuento = importe_total - (importe_total * 0.85F);
            Console.WriteLine($"El importe a pagar con el 15% de descuento es: ${descuento}");
        }
        else if (litros < 100)
        {
            descuento = importe_total - (importe_total * 0.90F);
            Console.WriteLine($"El importe a pagar con el 10% descuento es: ${descuento}");
        }
        else
        {
            Console.WriteLine($"No hay descuento. El importe a pagar es de: ${importe_total}");
        }
    }
}