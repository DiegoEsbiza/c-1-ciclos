namespace guia_ciclos_2;

class Program
{
    static void Main(string[] args)
    {
        // Una compañía de electricidad necesita calcular anualmente el consumo que ha registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos. Para ello tiene un lote de registros por cada uno de los usuarios con los siguientes datos:

        //     • Zona (numérico entero).
        //     • Número de cliente (número de cuatro dígitos no correlativos).
        //     • Cantidad de kilovatios consumidos en el periodo.

        // El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro con zona igual a cero.
        // Se pide generar un listado con el siguiente formato:

        //     •Zona: XX
        //     •Cantidad de usuarios de la zona: XX
        //     •Total facturado en la zona: XX

        //     •Zona: XX
        //     •Cantidad de usuarios de la zona: XX
        //     •Total facturado en la zona: XX
        
        // El precio es escalonado según la siguiente escala:
        
        //     • $ 0.10 por kv por los primeros 100 kv de consumo.
        //     • $ 0.12 por kv por el consumo de 101 a 200 kvs.
        //     • $ 0.15 por kv por el consumo de 201 kvs en adelante.

        int zona, zonaActual, nroCliente, cantKv, contClientes;
        double consumoFacturado;

        Console.WriteLine("Ingrese número de cliente (4 digitos): ");
        nroCliente = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de KV consumidos en el periodo: ");
        cantKv = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la zona: ");
        zona = int.Parse(Console.ReadLine());

        while (zona != 0 && zona > 0)
        {
            zonaActual = zona;
            contClientes = 0;
            consumoFacturado = 0;
            while (zonaActual == zona)
            {
                contClientes++;

                consumoFacturado = calcularfacturacion(cantKv, consumoFacturado);

                Console.WriteLine("Ingrese número de cliente (4 digitos): ");
                nroCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de KV consumidos en el periodo: ");
                cantKv = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la zona o 0 para finalizar carga: ");
                zona = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Registro de la zona " + zonaActual);
            Console.WriteLine("Se registro la cantidad de " + contClientes + " de usuarios");
            Console.WriteLine("Se registro una facturación total de " + consumoFacturado);
        }
    
    }

    static double calcularfacturacion(int cantKv, double consumoFacturado){
        if(cantKv > 100){
            consumoFacturado += cantKv * 0.12;
        }else if (cantKv <= 100)
        {
            consumoFacturado += cantKv * 0.10;
        }else{
            consumoFacturado += cantKv * 0.15;    
        }
        return consumoFacturado;        
    }
}
