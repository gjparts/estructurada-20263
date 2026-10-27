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
        }
    }
}
