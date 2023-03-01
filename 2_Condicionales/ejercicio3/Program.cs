namespace ejercicio3;
class Program
{
//Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

//Si el importe es ARS 5000 o más, aplica un descuento del 18%.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es menor a ARS 1000, no hay descuento.
//Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

    static void Main(string[] args)
    {
        float importeVenta, importeFinal;

        Console.WriteLine("Ingrese el importe de venta, por favor: ");
        importeVenta = float.Parse(Console.ReadLine());

        if(importeVenta >= 5000){
            importeFinal = importeVenta - (importeVenta * 0.12F);
            Console.WriteLine($"El importe final con el descuento es de: ${importeFinal}");
            importeFinal = float.Parse(Console.ReadLine());
        }else if(importeVenta >= 1000){
            importeFinal = importeVenta - (importeVenta * 0.10F);
            Console.WriteLine($"El importe final con el descuento es de: ${importeFinal}");
            importeFinal = float.Parse(Console.ReadLine());
        }else{
            importeFinal = importeVenta;
            Console.WriteLine($"No hay descuento. El total a pagar es: ${importeFinal}");
            importeFinal = float.Parse(Console.ReadLine());
        } 
    }
}