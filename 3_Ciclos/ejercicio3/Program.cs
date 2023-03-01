namespace ejercicio3;
class Program
{
    /*Una importante marca de computadoras permite elegir cierta configuración del
    equipo a comprar. Para ello existe la siguiente escala de precios:
    i5 (1) i7 (2) i9 (3)
    8 RAM (1) USD 800 USD 900 USD 1200
    16 RAM (2) USD 900 USD 1000 USD 1400
    32 RAM (3) USD 1000 USD 1400 USD 2000
    Además, el equipo viene con un disco que permite almacenar 500 GB de
    información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
    adicional de USD 300.
    Hacer un programa que solicite la opción de procesador, la opción de memoria
    RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender)
    y calcule y emita por pantalla el monto de la máquina seleccionada.*/
    static void Main(string[] args)
    {
        int procesador = 0, memoria = 0, disco = 0; 
        float monto = 0;
       
        Console.WriteLine("Ingrese la opción de procesador que desee, por favor: ");
        procesador = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la opción de la memoria RAM que desee, por favor: ");
        memoria = int.Parse(Console.ReadLine());

        switch(procesador)
        {
            case 1:
                if(procesador == 1 && memoria == 1)
                {
                    monto = 800;
                    Console.WriteLine($"Total a pagar por un procesador i5 y 8 RAM: $USD{monto}");
                }
                else if(procesador == 1 && memoria == 2)
                {
                    monto = 900;
                    Console.WriteLine($"Total a pagar por un procesador i5 y 16 RAM: $USD{monto}");
                }         
                else if(procesador == 1 && memoria == 3)
                {
                    monto = 1000;
                    Console.WriteLine($"Total a pagar por un procesador i5 y 32 RAM: $USD{monto}");
                }       
                break;


            case 2:
                if(procesador == 2 && memoria == 1)
                {
                    monto = 900;
                    Console.WriteLine($"Total a pagar por un procesador i7 y 8 RAM: $USD{monto}");
                }
                else if(procesador == 2 && memoria == 2)
                {
                    monto = 1000;
                    Console.WriteLine($"Total a pagar por un procesador i7 y 16 RAM: $USD{monto}");
                }        
                else if(procesador == 2 && memoria == 3)
                {
                    monto = 1400;
                    Console.WriteLine($"Total a pagar por un procesador i7 y 32 RAM: $USD{monto}");
                }
                break;

                
            case 3:
                if(procesador == 3 && memoria == 1)
                {
                    monto = 1200;
                    Console.WriteLine($"Total a pagar por un procesador i9 y 8 RAM: $USD{monto}");
                }
                else if(procesador == 2 && memoria == 2)
                {
                    monto = 1400;
                    Console.WriteLine($"Total a pagar por un procesador i9 y 16 RAM: $USD{monto}");
                }    
                else if(procesador == 2 && memoria == 3)
                {
                    monto = 2000;
                    Console.WriteLine($"Total a pagar por un procesador i9 y 32 RAM: $USD{monto}");
                }
                break;
            

            default:
                Console.WriteLine("No ingreso ninguna de las opciones disponibles en el sistema.");
                break;
        }
            
        Console.WriteLine("¿Desea extender el disco? (ingresa 1 para extender y 0 para no extender)");
        disco = int.Parse(Console.ReadLine());
        if  (disco == 1)
        {
            monto = monto + 300;
            Console.WriteLine($"Ampliando el disco de 500 GB a 1 TB el total a pagar es de: {monto}");
        }
        
    }
}