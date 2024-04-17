namespace guia_ciclos;

class Program
{
    static void Main(string[] args)
    {
        /* Se dispone de una lista de 10 grupos de números enteros separados entre ellos
           por ceros. Se pide determinar e informar:        

            a.- El número de grupo con mayor porcentaje de números impares positivos respecto al total de números
                que forman el grupo.            
            b.- Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un grupo no 
                hubiera números primos, informarlo con un cartel aclaratorio.            
            c.- Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

        int n, cont, contImparPos, grupoMaxP, ultimoPrimo, orden, mayor, bmayor;
        float porcent, maxPorcent, auxMaxP;
        bool impar, bMaxPorcent;

        //punto A - variables de porcentaje
        bMaxPorcent = false;
        maxPorcent = 0;
        grupoMaxP = 0;

        //punto B - variables números primos
        ultimoPrimo = 0;
        orden = 0;
        
        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Grupo n°: " + (x +1 ));
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            //punto A - variables de porcentaje
            cont = 0;
            porcent = 0;
            contImparPos = 0;

            //Punto B - núemeros primos
            ultimoPrimo = 0;

            //Punto C
            mayor = n;
            bmayor = 0;
            while (n != 0)
            {   
                //punto A - hallar impares positivos
                cont++;
                impar = false;
                impar = hallarImparPos(n, impar, ref contImparPos);

                //punto B - hallar número primo
                if (hallarPrimo(n))
                {
                    ultimoPrimo = n;
                    orden = cont;
                }
               
                if(mayor > n){
                    mayor = n;
                }else{
                    bmayor = 1;
                    Console.WriteLine("bmayor es igual a: " + bmayor);
                }

                Console.WriteLine("Ingrese otro número: ");
                n = int.Parse(Console.ReadLine());
            }

            if (bmayor == 0)
            {
                Console.WriteLine("El grupo esta ordenado");
            }

            //Punto A - grupo con mayor porcentaje
            porcent = hallarPorcent(porcent, cont, contImparPos);
            auxMaxP = hallarMaxPorcent(bMaxPorcent, porcent, maxPorcent);
            hallarGrupoMaxP(ref auxMaxP, ref maxPorcent, ref grupoMaxP, x);
    
            //Resolución del punto B:
            if (ultimoPrimo != 0)
            {
                Console.WriteLine("El ultimo número primo ingresado fue: " + ultimoPrimo + ", ingresó en la posición:" + orden);            
            }else{
                Console.WriteLine("No se registro ingreso de números primos");
            }
        }

        //Resolución del punto A:
        Console.WriteLine("El grupo con mayor porcentaje de números impares positivos es el n° " + grupoMaxP);
    }
    //Funciones:

    //Punto A - impar positivo
    static bool hallarImparPos (int n, bool impar, ref int contImparPos){
        if(n % 2 != 0 && n > 0){
            impar = true;
            contImparPos++;
        }
        return impar;
    }

    //Punto A - porcentaje
    static float hallarPorcent (float porcent, int cont, int contImparPos){
        porcent = (contImparPos * 100)/ cont;
        return porcent;
    }

    //Punto A - porcentaje maximo
    static float hallarMaxPorcent(bool bMaxPorcent, float porcent, float maxPorcent){
        if (bMaxPorcent)
            {
                bMaxPorcent = true;
                maxPorcent = porcent;
            }else if (porcent >= maxPorcent){
                maxPorcent = porcent;
            }
        return maxPorcent;
    }   

    //Punto A - grupo con mayor porcentaje
    static void hallarGrupoMaxP(ref float auxMaxP, ref float maxPorcent, ref int grupoMaxP, int x){
        if (auxMaxP > maxPorcent)
            {
                maxPorcent = auxMaxP;
                grupoMaxP = x + 1;
            }
    }

    //Punto B - número primo
    static bool hallarPrimo(int n){
        int cont = 0;
        for (int x = 1; x < n; x++)
        {
            if (n % x == 0)
            {
                cont ++;
            }
        }

        if (cont == 1)
        {
            return true;
        }else{
            return false;
        }
    }
}