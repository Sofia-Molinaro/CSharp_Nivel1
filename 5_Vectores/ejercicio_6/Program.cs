namespace ejercicio_6;
class Program
{
    static void Main(string[] args)
    {
        //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        //- Número de Artículo (1 a 15)
        //- Cantidad Vendida 

        //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        //Se pide determinar e informar:
        //a) El número de artículo que más se vendió en total.
        //b) Los números de artículos que no registraron ventas.
        //c) Cuantas unidades se vendieron del número de artículo 10.
        
        int numArticulo;
        int cantidad;
        int [] totalCantVendida = new int [15];

        for(int i= 0; i < 15; i++)
        {
            totalCantVendida[i] = 0;
        }

        Console.WriteLine("Ingrese el número del artículo(del 1 al 15): ");
        numArticulo = int.Parse(Console.ReadLine());
                
        Console.WriteLine("Ingrese la cantidad vendida: ");
        cantidad = int.Parse(Console.ReadLine());

        while(numArticulo != 0)
        {
            totalCantVendida[numArticulo - 1] = totalCantVendida[] + cantidad;  
            
            Console.WriteLine("Ingrese el número del artículo(del 1 al 15): ");
            numArticulo = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());  
        }
        
        //A)
        int maxCantidad = totalCantVendida[0];
        int numMaximo = 1;
        for(int i = 0; i < length; i++)
        {
            if (totalCantVendida[i] > maxCantidad)
            {
                maxCantidad = totalCantVendida[i];
                numArticulo = i + 1;       
            }
        }
        Console.WriteLine($"El producto más vendido es el : {numArticulo}");

        //B)
        for(int i = 0; i < length; i++)
        {
            if (totalCantVendida[i] == 0)
            {
                Console.WriteLine($"El número de artículo que no registraron ventas son: {(i + 1)}");
            }
        }

        //C)
        Console.WriteLine($"Los números de artículos que no registraron ventas son: {totalCantVendida[9]}");
    }
}
