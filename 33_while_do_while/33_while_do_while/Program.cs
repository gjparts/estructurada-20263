namespace _33_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructuras de repeticion while y do-while
            Se usan para realizar iteraciones de manera indefinida.
            Es muy utilizada cuando no se sabe en que momento va a terminar
            de repetirse algo, asi como puede ser 3 veces, puede ser 15 veces
            o puede ser tambien que necesite algo que se repita indefinidamente.
            -> Este estructura se basa en el cumplimiento de una o varias condiciones
            -> Para que puedan entender mejor, imaginese un if que si se cumple
               va a repetir lo que hay dentro de él; pero si se deja de cumplirse
               la condicion entonces termina.
            -> diferencia entre while y do-while:
                a) while: pregunta primero, hace despues
                b) do-while: hace primero, pregunta despues
            -> while quiere decir mientras, do quiere decir hacer
             */
            //Ejemplo de while:
            //Haga un programa que imprima los numeros del 1 al 10; pero usando while
            double numero = 1; //la variable que determina la ejecucion de while se llama
                               //variable de control.
            while(numero <= 10)
            {
                Console.WriteLine(numero);
                numero++; //la variable de control se cambia en cada iteracion si desea
                          //que en algun momento termine de repetir la estructura
                          //Si la variable de control nunca cambia, pues la estructura se queda infinita
            }

            //Ejemplo de do-while:
            //Haga un programa que imprima los numeros del 1 al 10; pero usando do-while
            int valor = 1;
            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor <= 10);
            //IMPORTANTE: la estructura do-while SIEMPRE va a ejecutar la primera iteracion

            /*Haga un programa que pregunte al usuario N cantidad de numeros positivos.
             El programa terminará cuando se digite un numero negativo.
            Hagalo usando while*/
            int n = 0;
            while (n >= 0)
            {
                try
                {
                    Console.Write("Digite un entero: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se acepta numeros");
                }
            }
            Console.WriteLine("Programa terminado");
            //Observe que en este programa la variable de control depende de lo que
            //el usuario digite.

            //Haga el programa anterior; pero utilizando una estructura de repeticion do-while
            float x = 777;
            do
            {
                try
                {
                    Console.Write("Digite un entero: ");
                    x = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se acepta numeros");
                }
            } while (x >= 0);
            /*Observe que usando do-while no importa el valor de inicio (777) ya que
             este sera sobre-escrito por el usuario en la primera iteracion
            la cual en do-while siempre sucede.*/
        }
    }
}
