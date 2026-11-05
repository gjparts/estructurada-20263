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
                numero++;
            }
        }
    }
}
