namespace ejercicio_5;
class Program
{
    static void Main(string[] args)
    {
    //     2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

    //     El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    //     Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int num, nroGrupo, totalNumeros, totalImpares;
        float porcentajeImpares;
        float porcentajeMax = -1;
        int grupoMax = 0;


        for (int i = 0; i < 5; i++)
        {
            // Cargar cada una de las listas 👽

           nroGrupo = i+1;
           totalImpares = 0;
           totalNumeros = 0;

           do
           {    
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                if (num % 2 != 0)
                {
                    totalImpares++;
                }

                totalNumeros++;

           } while(num != 0);

           // Calcular el porcentaje de impares de cada grupo 😋

           if (totalNumeros != 0)
           {
                porcentajeImpares = (100 * (float)totalImpares) / totalNumeros;
           }
           else
           {
                porcentajeImpares = 0;
           }

           Console.WriteLine($"Grupo {nroGrupo} ➡ Porcentaje impares: {porcentajeImpares.ToString("0.00")}%");

           // Mayor porcentaje de impares 😑

           if (nroGrupo == 1)
           {
                porcentajeMax = porcentajeImpares;
                grupoMax      = 1; 
           }
           else
           {
                if (porcentajeImpares > porcentajeMax)
                {
                    porcentajeMax = porcentajeImpares;
                    grupoMax      = nroGrupo;
                }
           }

        }

        // Acá se debe mostrar el porcentaje ⚠

        Console.WriteLine();
        Console.WriteLine($"Mayor porcentaje de impares ({porcentajeMax}%) corresponde al Grupo {grupoMax}");

    }
}