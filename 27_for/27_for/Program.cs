namespace _27_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de Repeticion for
            Permite repetir una o varias instrucciones
            -> Su principal caracteristica es que es
            una estructura de repeticion pensada
            para ser finita ya que en ella se requiere
            conocer el valor de inicio y el valor final.*/

            //Ejemplos:
            //Haga un programa que imprima los numeros
            //del 1 al 10 de 1 en 1.
            for(int i = 1; i <= 10; i++)
                Console.WriteLine(i);
            /*donde:
            int i = 1   inicializar la variable de control
            i <= 10     es la condicion de terminacion
                        indica que mientras se cumpla dicha
                        condicion la estructura va a repetir.
            i++         conocido como salto en ingles es STEP o paso
                        indica cuanto va a incrementar o
                        disminuir la variable de control en cada
                        ciclo o repeticion.
                        -> i++ indica que va a sumar 1 a la variable i
                        -> i++ es lo mismo que decir i = i + 1
            A cada ciclo o vuelta dentro de una estructura
            de repeticion tambien se le conoce como iteracion.
             */
            //Como sucede con if, cualquier estructura en C#, C++, JAVA, etc.
            //si solo hay una instruccion no es necesario poner llaves;
            //pero si tiene mas de una instruccion en la estructura
            //debe poner llaves:
            //Haga un programa que imprima los numeros
            //del 1 al 10 de 1 en 1 y que diga Hola luego de imprimir cada numero.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Hola");
            }

            /*Haga un programa que imprima los numeros del 0 al 10, contanto
             de 2 en 2*/
            //forma 1: 6 iteraciones
            for(int i = 0; i <= 10; i += 2)
                Console.WriteLine(i);

            //forma 2: 6 iteraciones
            for (int i = 0; i <= 10; i = i + 2)
                Console.WriteLine(i);

            //forma 3: 11 iteraciones, cuenta de 1 en 1 desde 0 hasta 10
            //pero solo imprime los multiplos de 2 (menos eficiente)
            for(int i = 0; i <= 10; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);
            }

            //Imprima los numeros del 0 al 50 de 5 en 5
            Console.WriteLine("--------------------------------------");
            for(int i = 0; i <= 50; i+=5)
                Console.WriteLine(i);
            //lo anterior hizo 11 iteraciones

            Console.WriteLine("--------------------------------------");
            //forma no eficiente de hacer lo anterior:
            for (int i = 0; i <= 50; i++)
            {
                if(i%5 == 0)
                    Console.WriteLine(i);
            }
            //el anterior hizo 51 iteraciones

            Console.WriteLine("--------------------------------------");
            //Recorrer los numeros del 1 al 100; pero solo imprima los numeros pares.
            for (int i = 1; i <= 100; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);
            }
            //cuando se le pida Recorrer, pues ahi es mas dicifil optimizar
            //en el anterior ejercicio de hizo 100 iteraciones

            //Imprimia los numeros del 1 al 100 y coloque un signo de admiracion
            //a la derecha de cada numero que sea multiplo de 10.
            //forma 1: usando if tradicional
            Console.WriteLine("--------------------------------------");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine($"{i}!");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
