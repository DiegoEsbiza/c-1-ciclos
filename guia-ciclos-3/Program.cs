namespace guia_ciclos_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar los valores de los pesos de distintas encomiendas que se deben enviar a distintos clientes y que finaliza cuando se ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que pueden transportar hasta 200 kilos en total.

        // Por ejemplo:
        //     10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
        //     Camión 1. Camión 2 Camión 3 Camión 4 Camión 5

        // Se pide determinar e informar:

        //     a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
        //     Camión 2: 170kg, etc.).
        //     b. El número de camión que transporta mayor cantidad de encomiendas
        //     (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
        //     c. La cantidad de camiones que se terminaron cargando.

        int peso = 0, carga = 1, camion = 1, pesaje = 0;

        Console.WriteLine("Ingrese el peso de la carga");
        peso = int.Parse(Console.ReadLine());
        while (peso >= 0)
        {   
            carga = 0;
            pesaje = peso;
            while (carga <= 200)
            {
                Console.WriteLine("La carga del camion " + camion + " es " + carga);

                Console.WriteLine("Ingrese el peso de la carga");
                peso = int.Parse(Console.ReadLine());
                
                if(carga <= 200){
                    pesaje += peso;
                    carga += peso;
                }else{
                    Console.WriteLine("Camion " + camion + " despachado con una carga de: " + carga);
                    camion++;
                    
                }
            }
            
        }
    }
}
