namespace _05_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ley de Precedencia de Operadores
            Las expresiones se evaluan se izquierda a derecha y se da
            prioridad a los operadores de acuerdo a la tabla siguiente:
            1) Parentesis ()
            2) Exponentes (Math.Pow)
            3) Multiplicaciones y Divisiones
            4) Sumas y Restas
            5) Operador logico: NOT !
            6) Operador logico: AND &&
            7) Operador logicos: OR || (ALT+124)
            */
            double d1 = 5, d2 = 9, d3 = 7, d4 = 11;
            Console.WriteLine((d1-d2)/(d3+d4));
            Console.WriteLine(d1-d2/d3+d4);
            //observe que los parentesis cambian el sentido de la expresion
            Console.WriteLine((d1-d2)/d3+d4);
            Console.WriteLine((d3+d4)/(d1)-(d2-d3)/(d1));
            Console.WriteLine((d1 * (d2 + d3)) / (5 * d1) + d4);
            //note el 5 en la expresion anterior
            //este valor se le conoce como valor fijo o constante
            //ya que siempre sera cinco.

            //Concatenar variables cuando hay operadores aritmeticos
            float x = 2, y = 3;
            Console.WriteLine("La suma de x mas y es "+x+y);
            /*Lo anterior imprime que la suma de 2 mas 3 es 23
             lo cual no es correcto. Esto se debe a que el operador
            de sumar en C# es un operador sobrecargado ya que
            sirve tanto para sumar como para concatenar.
            Para evitar dicho problema se hace lo siguiente:*/
            Console.WriteLine("La suma de x mas y es "+(x+y));
            //el problema anrerior se evita de mejor manera
            //usando el interpolador:
            Console.WriteLine($"La suma de x mas y es {x+y}");
        }
    }
}
