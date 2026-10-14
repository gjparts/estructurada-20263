namespace _18_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que solicite al usuario digitar tres
             numeros enteros: a,b,c.
             Si a es mayor a 8 Y b es menor a 10 Y c es igual a 14
            entonces muestre el mensaje: COMBINACION CORRECTA de lo
            contrario muestre el mensaje ACCESO NO VALIDO.
            -> Resuelvalo utilizando operadores logicos.*/
            try
            {
                int a, b, c;
                Console.Write("a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c: ");
                c = int.Parse(Console.ReadLine());

                if( a > 8 && b < 10 && c == 14 )
                    Console.WriteLine("COMBINACION CORRECTA");
                else
                    Console.WriteLine("ACCESO NO VALIDO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe digitar numeros enteros");
            }
        }
    }
}
