namespace _37_for_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura anidada (Nested)
            Es una estructura que dentro de otra estructura, por ejemplo:
            -> un if dentro de otro if
            -> un switch dentro de un do-while
            -> un for dentro de otro for
            -> un if dentro de un for
            -> un for dentro de un if
             
            Ejemplo: haga un programa que le pregunte al usuario el ancho y el alto de un
            rectangulo. El programa va a imprimir el rectangulo utilizando asteriscos.
             */
            try
            {
                int ancho, alto;
                Console.Write("Ancho: ");
                ancho = int.Parse(Console.ReadLine());
                Console.Write("Alto: ");
                alto = int.Parse(Console.ReadLine());

                for(int i = 1; i <= alto; i++)
                {
                    for(int j = 1;  j <= ancho; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); //nuevo renglon
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se acepta numeros enteros");
            }
        }
    }
}
